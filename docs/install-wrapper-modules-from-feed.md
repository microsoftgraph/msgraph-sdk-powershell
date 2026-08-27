# Install wrapper modules from the internal feed

The wrapper release pipeline publishes `Microsoft.Graph.Wrapper.*` prerelease packages to the
`MSGraph_PowerShell_V3_Build` Azure Artifacts feed for team validation.

## Prerequisites

- Access to the Azure DevOps project and read permission on the feed.
- PowerShellGet 2.x.
- `Microsoft.Graph.Authentication` installed at the version used by the build.

Get the feed's NuGet v2 URL from **Azure Artifacts > Connect to feed > NuGet > v2**. PowerShellGet
2.x requires the v2 endpoint when registering a `PSRepository`.

## Register the feed

Use an Azure DevOps personal access token with Packaging Read permission. Enter the token only at
the secure prompt; do not put it in a script, command history, or source-controlled file.

```powershell
$secureToken = Read-Host 'Azure DevOps PAT (Packaging: Read)' -AsSecureString
$credential = [pscredential]::new('AzureDevOps', $secureToken)
$feedUrl = 'https://pkgs.dev.azure.com/<organization>/<project>/_packaging/MSGraph_PowerShell_V3_Build/nuget/v2'

Register-PSRepository `
    -Name MSGraphPowerShellV3Build `
    -SourceLocation $feedUrl `
    -PublishLocation $feedUrl `
    -InstallationPolicy Trusted `
    -Credential $credential
```

Replace `<organization>/<project>` with the values from **Connect to feed**. Do not infer them from
the feed's display name.

## Install and validate a package

Every pipeline run publishes a version such as `3.0.0-alpha12345`. `-AllowPrerelease` is therefore
required.

```powershell
Install-Module Microsoft.Graph.Authentication -Scope CurrentUser -Force

Install-Module `
    -Name Microsoft.Graph.Wrapper.Users `
    -Repository MSGraphPowerShellV3Build `
    -Credential $credential `
    -AllowPrerelease `
    -Scope CurrentUser `
    -Force

Import-Module Microsoft.Graph.Wrapper.Users -Force

$module = Get-Module Microsoft.Graph.Wrapper.Users
$commands = @(Get-Command -Module $module.Name)
if (-not $module -or $commands.Count -eq 0) {
    throw 'The wrapper module did not import or export any commands.'
}

$module | Select-Object Name, Version, Path
Write-Host "Exported commands: $($commands.Count)"
```

For an operation test, start a clean PowerShell process, import only the wrapper module under test,
connect with the least privileges needed, and invoke a read-only command. Loading the shipping and
wrapper workload modules together can create command-name conflicts, even though their module and
package IDs differ.

## Find or update packages

```powershell
Find-Module Microsoft.Graph.Wrapper.* `
    -Repository MSGraphPowerShellV3Build `
    -Credential $credential `
    -AllowPrerelease

Update-Module Microsoft.Graph.Wrapper.Users -AllowPrerelease -Force
```

Remove the repository registration when testing is complete:

```powershell
Unregister-PSRepository -Name MSGraphPowerShellV3Build
```