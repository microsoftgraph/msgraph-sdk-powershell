# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

BeforeAll {
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
    Import-Module $ModulePath -Force -ErrorAction SilentlyContinue
    $RandomId = (New-Guid).Guid

	$MockAuthContext = New-Object Microsoft.Graph.PowerShell.Authentication.AuthContext -Property @{
        ClientId = $RandomId
        TenantId = $RandomId
        AuthType = [Microsoft.Graph.PowerShell.Authentication.AuthenticationType]::UserProvidedAccessToken
        TokenCredentialType = [Microsoft.Graph.PowerShell.Authentication.TokenCredentialType]::UserProvidedTokenCredential
    }
}
Describe 'Disconnect-MgGraph' {
    it 'Should have one ParameterSets' {
        $DisconnectMgGraphCommand = Get-Command Disconnect-MgGraph
        $DisconnectMgGraphCommand | Should -Not -BeNullOrEmpty
        $DisconnectMgGraphCommand.ParameterSets | Should -HaveCount 1
        $DisconnectMgGraphCommand.ParameterSets.Parameters | Should -HaveCount 11 # PS common parameters.
    }

    It 'Should remove current AuthContext' {
        {
            [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.AuthContext = $MockAuthContext
			$AuthContextBeforeDisconnect = Get-MgContext
			Disconnect-MgGraph

			$AuthContextBeforeDisconnect.ClientId | Should -Be $MockAuthContext.ClientId
			$AuthContextBeforeDisconnect.TenantId | Should -Be $MockAuthContext.TenantId
			$AuthContextBeforeDisconnect.AuthType | Should -Be $MockAuthContext.AuthType
			$AuthContextBeforeDisconnect.TokenCredentialType | Should -Be $MockAuthContext.TokenCredentialType
			Get-MgContext | Should -BeNullOrEmpty
			[Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.AuthContext | Should -BeNullOrEmpty
        } | Should -Not -Throw
    }
}
