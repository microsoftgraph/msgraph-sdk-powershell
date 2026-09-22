# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

BeforeAll {
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
	Import-Module $ModulePath -Force -ErrorAction SilentlyContinue
	$RandomId = (New-Guid).Guid

	# Microsoft.Graph.Authentication.Core is loaded into a private AssemblyLoadContext on PowerShell 7+, so its types
	# cannot be referenced with type literals. Resolve them from the already-loaded assembly instead.
	function Get-MgCoreType {
		param([Parameter(Mandatory)][string]$TypeName)
		$asm = [AppDomain]::CurrentDomain.GetAssemblies() | Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' } | Select-Object -First 1
		return $asm.GetType($TypeName, $true)
	}
	function Get-MgGraphSessionInstance {
		return (Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.GraphSession').GetProperty('Instance').GetValue($null)
	}

	$MockAuthContext = [Activator]::CreateInstance((Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.AuthContext'))
	$MockAuthContext.ClientId = $RandomId
	$MockAuthContext.TenantId = $RandomId
	$MockAuthContext.AuthType = [Enum]::Parse((Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.AuthenticationType'), 'UserProvidedAccessToken')
	$MockAuthContext.TokenCredentialType = [Enum]::Parse((Get-MgCoreType 'Microsoft.Graph.PowerShell.Authentication.TokenCredentialType'), 'UserProvidedAccessToken')
}
Describe 'Disconnect-MgGraph' {
    it 'Should have one ParameterSets' {
        $DisconnectMgGraphCommand = Get-Command Disconnect-MgGraph
        $DisconnectMgGraphCommand | Should -Not -BeNullOrEmpty
        $DisconnectMgGraphCommand.ParameterSets | Should -HaveCount 1
        $DisconnectMgGraphCommand.ParameterSets.Parameters | Should -HaveCount 13 # SignOutFromBroker + PS common parameters.
    }

    It 'Should remove current AuthContext' {
        {
			(Get-MgGraphSessionInstance).AuthContext = $MockAuthContext
			$AuthContextBeforeDisconnect = Get-MgContext
			Disconnect-MgGraph

			$AuthContextBeforeDisconnect.ClientId | Should -Be $MockAuthContext.ClientId
			$AuthContextBeforeDisconnect.TenantId | Should -Be $MockAuthContext.TenantId
			$AuthContextBeforeDisconnect.AuthType | Should -Be $MockAuthContext.AuthType
			$AuthContextBeforeDisconnect.TokenCredentialType | Should -Be $MockAuthContext.TokenCredentialType
			Get-MgContext | Should -BeNullOrEmpty
			(Get-MgGraphSessionInstance).AuthContext | Should -BeNullOrEmpty
        } | Should -Not -Throw
    }
}

Describe 'Disconnect-MgGraph ErrorAction Handling' {
    It 'Should throw error by default' {
        { Disconnect-MgGraph } | Should -Throw -ExpectedMessage "No application to sign out from."
    }

    It 'Should not throw error when ErrorAction is SilentlyContinue' {
        { Disconnect-MgGraph -ErrorAction SilentlyContinue } | Should -Not -Throw
    }
}
