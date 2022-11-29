# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Get-MgBetaApplicationOwner" {
    BeforeAll {
        $GetMgBetaApplicationOwner = Get-Command Get-MgBetaApplicationOwner
    }

    It "Should support minimum set of parameter sets" {
        $GetMgBetaApplicationOwner.ParameterSets.Name | Should -BeIn @("List")
        $GetMgBetaApplicationOwner.Visibility | Should -Be "Public"
        $GetMgBetaApplicationOwner.CommandType | Should -Be "Function"
    }

    It "Should return a list of directory objects by default" {
        $GetMgBetaApplicationOwner.OutputType | Should -BeIn @("Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject", "System.String")
        $GetMgBetaApplicationOwner.DefaultParameterSet | Should -Be "List"
    }

    It 'Should have List parameterSet' {
        $ListParameterSet = $GetMgBetaApplicationOwner.ParameterSets | Where-Object Name -eq "List"
        $ListParameterSet.Parameters.Name | Should -Contain ApplicationId
        $ListParameterSet.Parameters.Name | Should -Contain All
        $ListParameterSet.Parameters.Name | Should -Contain PageSize
        $ListParameterSet.Parameters.Name | Should -Contain CountVariable
        $ListParameterSet.Parameters.Name | Should -Contain Filter
        $ListParameterSet.Parameters.Name | Should -Contain Top
        $ListParameterSet.Parameters.Name | Should -Contain Property
        $ListParameterSet.Parameters.Name | Should -Contain ExpandProperty
        $ListParameterSet.Parameters.Name | Should -Contain ConsistencyLevel
    }
}
