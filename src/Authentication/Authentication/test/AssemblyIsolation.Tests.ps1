# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
[Diagnostics.CodeAnalysis.SuppressMessageAttribute('PSAvoidUsingConvertToSecureStringWithPlainText', '', Justification='Just an example for testing purposes.')]
param()

# These tests verify that, on PowerShell 7+, Microsoft.Graph.Authentication.Core and all of its third-party dependencies
# (Azure.Identity, Microsoft.Identity.Client, Microsoft.Kiota.*, Microsoft.Graph.Core, ...) are loaded into the module's private
# AssemblyLoadContext and never into the default context, so they can no longer conflict with other modules.
# Each scenario runs in a fresh pwsh process so the load contexts are not polluted by previous tests.

BeforeAll {
	$ModuleName = "Microsoft.Graph.Authentication"
	$ModulePath = (Resolve-Path (Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1")).Path
	$DummyToken = "eyJhbGciOiJIUzI1NiJ9.eyJSb2xlIjoiVGVzdCIsIklzc3VlciI6Iklzc3VlciIsIlVzZXJuYW1lIjoiVGVzdCIsImV4cCI6MTkxMTIzMDM1NiwiaWF0IjoxNjc4NDg4ODE2fQ.yjRvogDyxlQrrQV3EaEsZJKhpYuNzaCyrh5Ip9WvdjU"

	function Invoke-InFreshPwsh {
		param([Parameter(Mandatory)][string]$Script)
		$pwsh = (Get-Process -Id $PID).Path
		$encoded = [Convert]::ToBase64String([Text.Encoding]::Unicode.GetBytes($Script))
		$output = & $pwsh -NoProfile -NonInteractive -NoLogo -EncodedCommand $encoded 2>&1
		if ($LASTEXITCODE -ne 0) {
			throw "Child pwsh failed ($LASTEXITCODE):`n$($output -join "`n")"
		}
		return ($output | Where-Object { $_ -is [string] }) -join "`n" | ConvertFrom-Json
	}

	# Emits, as JSON, for each assembly of interest the name of the AssemblyLoadContext it was loaded into.
	$ProbeScript = @"
`$ErrorActionPreference = 'Stop'
Import-Module '$ModulePath' -Force
Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String '$DummyToken' -Force) | Out-Null
`$null = Get-MgContext
# Force the HTTP pipeline (and therefore Kiota / Graph.Core) to be materialised.
`$null = [Microsoft.Graph.PowerShell.Authentication.Helpers.HttpHelpers]::GetGraphHttpClient()
`$names = 'Microsoft.Graph.Authentication','Microsoft.Graph.Authentication.Core','Microsoft.Graph.Authentication.Loader','Microsoft.Identity.Client','Azure.Identity','Azure.Core','Microsoft.Graph.Core','Microsoft.Kiota.Abstractions','Newtonsoft.Json'
`$result = @{}
foreach (`$asm in [AppDomain]::CurrentDomain.GetAssemblies()) {
	`$n = `$asm.GetName().Name
	if (`$names -contains `$n) {
		`$alc = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext(`$asm)
		`$key = if (`$result.ContainsKey(`$n)) { "`$n#2" } else { `$n }
		`$result[`$key] = `$alc.Name
	}
}
`$result | ConvertTo-Json -Compress
"@
}

Describe 'AssemblyLoadContext isolation' -Skip:($PSEdition -ne 'Core') {

	It 'Should not ship Microsoft.Graph.Authentication.Core.dll in the module root' {
		$root = Split-Path $ModulePath
		Test-Path (Join-Path $root 'Microsoft.Graph.Authentication.Core.dll') | Should -BeFalse
		Test-Path (Join-Path $root 'Dependencies\Core\Microsoft.Graph.Authentication.Core.dll') | Should -BeTrue
		Test-Path (Join-Path $root 'Dependencies\Core\Microsoft.Graph.Authentication.Loader.dll') | Should -BeTrue
		Test-Path (Join-Path $root 'Newtonsoft.Json.dll') | Should -BeTrue
	}

	It 'Should not declare NestedModules or RequiredAssemblies (the psm1 loads the dll after initializing the load context)' {
		$manifest = Import-PowerShellDataFile $ModulePath
		$manifest.ContainsKey('NestedModules') | Should -BeFalse
		$manifest.ContainsKey('RequiredAssemblies') | Should -BeFalse
	}

	It 'Should load Core and its dependencies into the private load context' {
		$contexts = Invoke-InFreshPwsh -Script $ProbeScript

		$contexts.'Microsoft.Graph.Authentication'        | Should -Be 'Default'
		$contexts.'Microsoft.Graph.Authentication.Loader' | Should -Be 'Default'
		$contexts.'Newtonsoft.Json'                       | Should -Be 'Default'

		$contexts.'Microsoft.Graph.Authentication.Core'   | Should -Be 'Microsoft.Graph.Authentication'
		$contexts.'Microsoft.Identity.Client'             | Should -Be 'Microsoft.Graph.Authentication'
		$contexts.'Azure.Identity'                        | Should -Be 'Microsoft.Graph.Authentication'
		$contexts.'Azure.Core'                            | Should -Be 'Microsoft.Graph.Authentication'
		$contexts.'Microsoft.Graph.Core'                  | Should -Be 'Microsoft.Graph.Authentication'
		$contexts.'Microsoft.Kiota.Abstractions'          | Should -Be 'Microsoft.Graph.Authentication'
	}

	It 'Should keep working when a conflicting Microsoft.Identity.Client is already loaded in the default context' {
		# Simulate another module (e.g. Az.Accounts / ExchangeOnlineManagement) that has already loaded a *different*
		# Microsoft.Identity.Client into the default context by loading a stub assembly with that name first.
		$stubSource = @'
using System.Reflection;
[assembly: AssemblyVersion("1.0.0.0")]
namespace Microsoft.Identity.Client { public static class Stub { } }
'@
		$stubDir = Join-Path ([IO.Path]::GetTempPath()) ("mg-alc-" + [Guid]::NewGuid().ToString('N'))
		New-Item -ItemType Directory -Path $stubDir | Out-Null
		$stubPath = Join-Path $stubDir 'Microsoft.Identity.Client.dll'
		Add-Type -TypeDefinition $stubSource -OutputAssembly $stubPath -OutputType Library | Out-Null

		$script = @"
`$ErrorActionPreference = 'Stop'
`$null = [System.Reflection.Assembly]::LoadFrom('$stubPath')
$ProbeScript
"@
		$contexts = Invoke-InFreshPwsh -Script $script

		# Two copies of MSAL must coexist: the stub in Default, the real one in our context.
		$msal = @($contexts.PSObject.Properties | Where-Object { $_.Name -like 'Microsoft.Identity.Client*' })
		$msal.Count | Should -Be 2
		($msal.Value | Sort-Object) | Should -Be @('Default', 'Microsoft.Graph.Authentication')
		$contexts.'Microsoft.Graph.Authentication.Core' | Should -Be 'Microsoft.Graph.Authentication'

		Remove-Item $stubDir -Recurse -Force -ErrorAction Ignore
	}
}
