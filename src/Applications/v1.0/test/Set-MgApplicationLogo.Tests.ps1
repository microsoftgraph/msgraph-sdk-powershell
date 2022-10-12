# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Set-MgApplicationLogo" {
    BeforeAll {
        $SetMgApplicationLogo = Get-Command Set-MgApplicationLogo
    }

    It "Should support minimum set of parameter sets" {
        $SetMgApplicationLogo.ParameterSets.Name | Should -BeIn @("Set", "SetViaIdentity")
        $SetMgApplicationLogo.Visibility | Should -Be "Public"
        $SetMgApplicationLogo.CommandType | Should -Be "Function"
    }

    It "Should set an application's logo by default" {
        $SetMgApplicationLogo.OutputType | Should -Be "System.Boolean"
        $SetMgApplicationLogo.DefaultParameterSet | Should -Be "Set"
    }

    It 'Should have Set parameterSet' {
        $SetParameterSet = $SetMgApplicationLogo.ParameterSets | Where-Object Name -eq "Set"
        $SetParameterSet.Parameters.Name | Should -Contain ApplicationId
        $SetParameterSet.Parameters.Name | Should -Contain Data
        $SetParameterSet.Parameters.Name | Should -Contain Confirm
    }

    It 'Should have SetViaIdentity parameterSet' {
        $SetViaIdentityParameterSet = $SetMgApplicationLogo.ParameterSets | Where-Object Name -eq "SetViaIdentity"
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain Data
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain Confirm
    }
}
