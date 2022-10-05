# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "New-MgBetaApplicationOwnerByRef" {
    BeforeAll {
        $NewMgBetaApplicationOwnerByRef = Get-Command New-MgBetaApplicationOwnerByRef
    }

    It "Should support minimum set of parameter sets" {
        $NewMgBetaApplicationOwnerByRef.ParameterSets.Name | Should -BeIn @("Create", "CreateExpanded", "CreateViaIdentity", "CreateViaIdentityExpanded")
        $NewMgBetaApplicationOwnerByRef.Visibility | Should -Be "Public"
        $NewMgBetaApplicationOwnerByRef.CommandType | Should -Be "Function"
    }

    It "Should support CreateExpanded parameterSet by default" {
        $NewMgBetaApplicationOwnerByRef.OutputType | Should -Be "System.Boolean"
        $NewMgBetaApplicationOwnerByRef.DefaultParameterSet | Should -Be "CreateExpanded"
    }

    It 'Should have CreateExpanded parameterSet' {
        $CreateExpandedParameterSet = $NewMgBetaApplicationOwnerByRef.ParameterSets | Where-Object Name -eq "CreateExpanded"
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain ApplicationId
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain OdataId
        $CreateExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $CreateExpandedParameterSet.Parameters.Name | Should -Not -Contain BodyParameter
    }

    It 'Should have Create parameterSet' {
        $CreateParameterSet = $NewMgBetaApplicationOwnerByRef.ParameterSets | Where-Object Name -eq "Create"
        $CreateParameterSet.Parameters.Name | Should -Contain ApplicationId
        $CreateParameterSet.Parameters.Name | Should -Contain BodyParameter
        $CreateParameterSet.Parameters.Name | Should -Not -Contain AdditionalProperties
    }

    It 'Should have CreateViaIdentity parameterSet' {
        $CreateViaIdentityParameterSet = $NewMgBetaApplicationOwnerByRef.ParameterSets | Where-Object Name -eq "CreateViaIdentity"
        $CreateViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $CreateViaIdentityParameterSet.Parameters.Name | Should -Contain BodyParameter
        $CreateViaIdentityParameterSet.Parameters.Name | Should -Not -Contain AdditionalProperties
    }

    It 'Should have CreateViaIdentityExpanded parameterSet' {
        $CreateViaIdentityExpandedParameterSet = $NewMgBetaApplicationOwnerByRef.ParameterSets | Where-Object Name -eq "CreateViaIdentityExpanded"
        $CreateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain InputObject
        $CreateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain OdataId
        $CreateViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $CreateViaIdentityExpandedParameterSet.Parameters.Name | Should -Not -Contain BodyParameter
    }
}
