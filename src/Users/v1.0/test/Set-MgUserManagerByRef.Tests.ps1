# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Set-MgUserManagerByRef" {
    BeforeAll {
        $SetMgUserManagerByRef = Get-Command Set-MgUserManagerByRef
    }

    It "Should support minimum set of parameter sets" {
        $SetMgUserManagerByRef.ParameterSets.Name | Should -BeIn @("Set", "SetExpanded", "SetViaIdentity", "SetViaIdentityExpanded")
        $SetMgUserManagerByRef.Visibility | Should -Be "Public"
        $SetMgUserManagerByRef.CommandType | Should -Be "Function"
    }

    It "Should support SetExpanded parameterSet by default" {
        $SetMgUserManagerByRef.OutputType | Should -Be "System.Boolean"
        $SetMgUserManagerByRef.DefaultParameterSet | Should -Be "SetExpanded"
    }

    It 'Should have SetExpanded parameterSet' {
        $SetExpandedParameterSet = $SetMgUserManagerByRef.ParameterSets | Where-Object Name -eq "SetExpanded"
        $SetExpandedParameterSet.Parameters.Name | Should -Contain UserId
        $SetExpandedParameterSet.Parameters.Name | Should -Contain OdataId
        $SetExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $SetExpandedParameterSet.Parameters.Name | Should -Not -Contain BodyParameter
        $SetMgUserManagerByRef.Parameters.OdataId.ParameterSets.SetExpanded.IsMandatory | Should -be $true
    }

    It 'Should have Set parameterSet' {
        $SetParameterSet = $SetMgUserManagerByRef.ParameterSets | Where-Object Name -eq "Set"
        $SetParameterSet.Parameters.Name | Should -Contain UserId
        $SetParameterSet.Parameters.Name | Should -Contain BodyParameter
        $SetParameterSet.Parameters.Name | Should -Not -Contain AdditionalProperties
    }

    It 'Should have SetViaIdentity parameterSet' {
        $SetViaIdentityParameterSet = $SetMgUserManagerByRef.ParameterSets | Where-Object Name -eq "SetViaIdentity"
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $SetViaIdentityParameterSet.Parameters.Name | Should -Contain BodyParameter
        $SetViaIdentityParameterSet.Parameters.Name | Should -Not -Contain AdditionalProperties
    }

    It 'Should have SetViaIdentityExpanded parameterSet' {
        $SetViaIdentityExpandedParameterSet = $SetMgUserManagerByRef.ParameterSets | Where-Object Name -eq "SetViaIdentityExpanded"
        $SetViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain InputObject
        $SetViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain OdataId
        $SetViaIdentityExpandedParameterSet.Parameters.Name | Should -Contain AdditionalProperties
        $SetViaIdentityExpandedParameterSet.Parameters.Name | Should -Not -Contain BodyParameter
        $SetMgUserManagerByRef.Parameters.OdataId.ParameterSets.SetViaIdentityExpanded.IsMandatory | Should -be $true
    }
}
