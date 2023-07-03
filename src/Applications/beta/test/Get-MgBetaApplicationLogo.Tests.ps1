# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Get-MgBetaApplicationLogo" {
    BeforeAll {
        $GetMgBetaApplicationLogo = Get-Command Get-MgBetaApplicationLogo
    }

    It "Should support minimum set of parameter sets" {
        $GetMgBetaApplicationLogo.ParameterSets.Name | Should -BeIn @("Get", "GetViaIdentity")
        $GetMgBetaApplicationLogo.Visibility | Should -Be "Public"
        $GetMgBetaApplicationLogo.CommandType | Should -Be "Function"
    }

    It "Should return an application's logo by default" {
        $GetMgBetaApplicationLogo.OutputType | Should -Be "System.Boolean"
        $GetMgBetaApplicationLogo.DefaultParameterSet | Should -Be "Get"
    }

    It 'Should have Get parameterSet' {
        $GetParameterSet = $GetMgBetaApplicationLogo.ParameterSets | Where-Object Name -eq "Get"
        $GetParameterSet.Parameters.Name | Should -Contain ApplicationId
        $GetParameterSet.Parameters.Name | Should -Contain OutFile
        $GetParameterSet.Parameters.Name | Should -Contain PassThru
    }

    It 'Should have GetViaIdentity parameterSet' {
        $GetViaIdentityParameterSet = $GetMgBetaApplicationLogo.ParameterSets | Where-Object Name -eq "GetViaIdentity"
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain OutFile
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain PassThru
    }
}
