
function Get-GraphAuthenticationLoadContextName {
    param(
        [Parameter(Mandatory = $true)]
        [string] $ModulePath
    )

    $sha256 = [System.Security.Cryptography.SHA256]::Create()
    try {
        $pathBytes = [System.Text.Encoding]::UTF8.GetBytes($ModulePath)
        $hash = [System.BitConverter]::ToString($sha256.ComputeHash($pathBytes)).Replace('-', '').Substring(0, 16)
        "Microsoft.Graph.Authentication.$hash"
    }
    finally {
        $sha256.Dispose()
    }
}

function Initialize-GraphAuthenticationAssemblyResolver {
    if ('Microsoft.Graph.PowerShell.Authentication.Loader.GraphAuthenticationAssemblyResolver' -as [type]) {
        return
    }

    Add-Type -TypeDefinition @'
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace Microsoft.Graph.PowerShell.Authentication.Loader
{
    public static class GraphAuthenticationAssemblyResolver
    {
        private static readonly ConcurrentDictionary<string, string[]> DependencyFolders = new ConcurrentDictionary<string, string[]>(StringComparer.Ordinal);
        private static readonly ConcurrentDictionary<string, bool> RegisteredContexts = new ConcurrentDictionary<string, bool>(StringComparer.Ordinal);

        public static void Register(AssemblyLoadContext context, string[] dependencyFolders)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            string contextName = context.Name ?? string.Empty;
            DependencyFolders[contextName] = dependencyFolders ?? Array.Empty<string>();

            if (RegisteredContexts.TryAdd(contextName, true))
            {
                context.Resolving += Resolve;
            }
        }

        private static Assembly Resolve(AssemblyLoadContext context, AssemblyName assemblyName)
        {
            if (context == null || assemblyName == null || string.IsNullOrWhiteSpace(assemblyName.Name))
            {
                return null;
            }

            if (!DependencyFolders.TryGetValue(context.Name ?? string.Empty, out string[] dependencyFolders))
            {
                return null;
            }

            foreach (string dependencyFolder in dependencyFolders)
            {
                if (string.IsNullOrWhiteSpace(dependencyFolder) || !Directory.Exists(dependencyFolder))
                {
                    continue;
                }

                string dependencyPath = Path.Combine(dependencyFolder, assemblyName.Name + ".dll");
                if (File.Exists(dependencyPath))
                {
                    return context.LoadFromAssemblyPath(Path.GetFullPath(dependencyPath));
                }
            }

            return null;
        }
    }
}
'@
}

function Import-GraphAuthenticationAssembly {
    param(
        [Parameter(Mandatory = $true)]
        [string] $ModulePath
    )

    if ($PSEdition -ne 'Core' -or -not ('System.Runtime.Loader.AssemblyLoadContext' -as [type])) {
        return Import-Module -LiteralPath $ModulePath -PassThru
    }

    $loadContextName = Get-GraphAuthenticationLoadContextName -ModulePath $ModulePath
    $loadContext = [System.Runtime.Loader.AssemblyLoadContext]::All |
        Where-Object { $_.Name -eq $loadContextName } |
        Select-Object -First 1

    if ($null -eq $loadContext) {
        $loadContext = [System.Runtime.Loader.AssemblyLoadContext]::new($loadContextName, $false)
    }

    $moduleRoot = $PSScriptRoot
    $dependencyFolders = @(
        (Join-Path $moduleRoot 'Dependencies\Core'),
        (Join-Path $moduleRoot 'Dependencies'),
        $moduleRoot
    )

    Initialize-GraphAuthenticationAssemblyResolver
    [Microsoft.Graph.PowerShell.Authentication.Loader.GraphAuthenticationAssemblyResolver]::Register($loadContext, [string[]] $dependencyFolders)

    $moduleAssembly = $loadContext.Assemblies |
        Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication' } |
        Select-Object -First 1

    if ($null -eq $moduleAssembly) {
        $moduleAssembly = $loadContext.LoadFromAssemblyPath((Resolve-Path -LiteralPath $ModulePath).Path)
    }

    Import-Module -Assembly $moduleAssembly -PassThru
}

function Test-GraphAuthenticationDoNotExport {
    param(
        [Parameter(Mandatory = $true)]
        [System.Management.Automation.CommandInfo] $Command
    )

    $implementingType = $Command.ImplementingType
    $null -ne $implementingType -and ($implementingType.GetCustomAttributes($false) |
        Where-Object { $_.GetType().FullName -eq 'Microsoft.Graph.PowerShell.Authentication.Utilities.Runtime.DoNotExportAttribute' })
}

function New-GraphAuthenticationCmdletAlias {
    param(
        [Parameter(Mandatory = $true)]
        [System.Management.Automation.CmdletInfo] $Command
    )

    $aliasNames = $Command.ImplementingType.GetCustomAttributes($false) |
        Where-Object { $_.GetType().FullName -eq 'System.Management.Automation.AliasAttribute' } |
        ForEach-Object { $_.AliasNames } |
        Where-Object { -not [string]::IsNullOrWhiteSpace($_) } |
        Select-Object -Unique

    foreach ($aliasName in $aliasNames) {
        New-Alias -Name $aliasName -Value $Command.Name -Force -Scope Script
        $aliasName
    }
}

# Load the module DLL before exporting cmdlets. On PowerShell Core, loading the
# binary through a custom AssemblyLoadContext keeps its dependencies isolated
# from other Microsoft 365 modules that may already be loaded in the process.
$ModulePath = (Join-Path $PSScriptRoot 'Microsoft.Graph.Authentication.dll')
$ModuleInfo = Import-GraphAuthenticationAssembly -ModulePath $ModulePath

# Export nothing to clear implicit exports.
Export-ModuleMember

if (Test-Path -Path "$PSScriptRoot\StartupScripts" -ErrorAction Ignore)
{
    Get-ChildItem "$PSScriptRoot\StartupScripts" -Filter *.ps1 -ErrorAction Stop | ForEach-Object {
        . $_.FullName
    }
}

# Export binary module cmdlets.
$CmdletsToExport = $ModuleInfo.ExportedCommands.Values |
    Where-Object { $_.CommandType -eq 'Cmdlet' -and -not (Test-GraphAuthenticationDoNotExport -Command $_) }

$AliasesToExport = $CmdletsToExport |
    ForEach-Object { New-GraphAuthenticationCmdletAlias -Command $_ } |
    Select-Object -Unique

Export-ModuleMember -Cmdlet ($CmdletsToExport | Select-Object -ExpandProperty Name -Unique) -Alias $AliasesToExport
