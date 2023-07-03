# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Remove-MgBetaApplication" {
    BeforeAll {
        $RemoveMgBetaApplication = Get-Command Remove-MgBetaApplication
    }

    It "Should support minimum set of parameter sets" {
        $RemoveMgBetaApplication.ParameterSets.Name | Should -BeIn @("Delete", "DeleteViaIdentity")
        $RemoveMgBetaApplication.Visibility | Should -Be "Public"
        $RemoveMgBetaApplication.CommandType | Should -Be "Function"
    }

    It "Should support Delete parameterSet by default" {
        $RemoveMgBetaApplication.OutputType | Should -Be "System.Boolean"
        $RemoveMgBetaApplication.DefaultParameterSet | Should -Be "Delete"
    }

    It 'Should have Delete parameterSet' {
        $DeleteParameterSet = $RemoveMgBetaApplication.ParameterSets | Where-Object Name -eq "Delete"
        $DeleteParameterSet.Parameters.Name | Should -Contain ApplicationId
        $DeleteParameterSet.Parameters.Name | Should -Contain Confirm
    }

    It 'Should have DeleteViaIdentity parameterSet' {
        $DeleteViaIdentityParameterSet = $RemoveMgBetaApplication.ParameterSets | Where-Object Name -eq "DeleteViaIdentity"
        $DeleteViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $DeleteViaIdentityParameterSet.Parameters.Name | Should -Contain Confirm
    }
}
