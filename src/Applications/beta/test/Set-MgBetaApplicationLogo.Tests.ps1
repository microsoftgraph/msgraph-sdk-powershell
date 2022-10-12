# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Set-MgBetaApplicationLogo" {
    BeforeAll {
        $SetMgBetaApplicationLogo = Get-Command Set-MgBetaApplicationLogo
    }

    It "Should support minimum set of parameter sets" {
        $SetMgBetaApplicationLogo.ParameterSets.Name | Should -BeIn @("Set", "SetViaIdentity")
        $SetMgBetaApplicationLogo.Visibility | Should -Be "Public"
        $SetMgBetaApplicationLogo.CommandType | Should -Be "Function"
    }

    It "Should set an application's logo by default" {
        $SetMgBetaApplicationLogo.OutputType | Should -Be "System.Boolean"
        $SetMgBetaApplicationLogo.DefaultParameterSet | Should -Be "Set"
    }

    It 'Should have Set parameterSet' {
        $SetParameterSet = $SetMgBetaApplicationLogo.ParameterSets | Where-Object Name -eq "Set"
        $SetParameterSet.Parameters.Name | Should -Contain ApplicationId
        $SetParameterSet.Parameters.Name | Should -Contain Data
        $SetParameterSet.Parameters.Name | Should -Contain Confirm
    }

    It 'Should have SetViaIdentity parameterSet' {
        $SetViaIdentityParameterSet = $SetMgBetaApplicationLogo.ParameterSets | Where-Object Name -eq "SetViaIdentity"
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain Data
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain Confirm
    }
}
