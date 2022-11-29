# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Update-MgBetaApplication" {
    BeforeAll {
        $UpdateMgBetaApplication = Get-Command Update-MgBetaApplication
    }

    It "Should support minimum set of parameter sets" {
        $UpdateMgBetaApplication.ParameterSets.Name | Should -BeIn @("UpdateExpanded", "Update", "UpdateViaIdentityExpanded", "UpdateViaIdentity")
        $UpdateMgBetaApplication.Visibility | Should -Be "Public"
        $UpdateMgBetaApplication.CommandType | Should -Be "Function"
    }

    It "Should support UpdateExpanded parameterSet by default" {
        $UpdateMgBetaApplication.OutputType | Should -Be "System.Boolean"
        $UpdateMgBetaApplication.DefaultParameterSet | Should -Be "UpdateExpanded"
    }

    It 'Should have UpdateExpanded parameterSet' {
        $UpdateExpandedParameterSet = $UpdateMgBetaApplication.ParameterSets | Where-Object Name -eq "UpdateExpanded"
        $UpdateExpandedParameterSet.Parameters.Name | Should -Contain ApplicationId
        $UpdateExpandedParameterSet.Parameters.Name | Should -Contain DisplayName
        $UpdateExpandedParameterSet.Parameters.Name | Should -Contain Description
        $UpdateExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $UpdateExpandedParameterSet.Parameters.Name | Should -Contain Confirm
    }

    It 'Should have Update parameterSet' {
        $UpdateParameterSet = $UpdateMgBetaApplication.ParameterSets | Where-Object Name -eq "Update"
        $UpdateParameterSet.Parameters.Name | Should -Contain ApplicationId
        $UpdateParameterSet.Parameters.Name | Should -Contain BodyParameter
        $UpdateParameterSet.Parameters.Name | Should -Contain Confirm
    }

    It 'Should have UpdateViaIdentityExpanded parameterSet' {
        $UpdateViaIdentityExpandedParameterSet = $UpdateMgBetaApplication.ParameterSets | Where-Object Name -eq "UpdateViaIdentityExpanded"
        $UpdateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain InputObject
        $UpdateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain DisplayName
        $UpdateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain Description
        $UpdateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $UpdateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain Confirm
    }

    It 'Should have UpdateViaIdentity parameterSet' {
        $UpdateViaIdentityParameterSet = $UpdateMgBetaApplication.ParameterSets | Where-Object Name -eq "UpdateViaIdentity"
        $UpdateViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $UpdateViaIdentityParameterSet.Parameters.Name | Should -Contain BodyParameter
        $UpdateViaIdentityParameterSet.Parameters.Name | Should -Contain Confirm
    }
}
