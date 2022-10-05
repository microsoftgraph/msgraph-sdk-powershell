# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Get-MgApplicationOwner" {
    BeforeAll {
        $GetMgApplicationOwner = Get-Command Get-MgApplicationOwner
    }

    It "Should support minimum set of parameter sets" {
        $GetMgApplicationOwner.ParameterSets.Name | Should -BeIn @("List")
        $GetMgApplicationOwner.Visibility | Should -Be "Public"
        $GetMgApplicationOwner.CommandType | Should -Be "Function"
    }

    It "Should return a list of directory objects by default" {
        $GetMgApplicationOwner.OutputType | Should -BeIn @("Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject", "System.String")
        $GetMgApplicationOwner.DefaultParameterSet | Should -Be "List"
    }

    It 'Should have List parameterSet' {
        $ListParameterSet = $GetMgApplicationOwner.ParameterSets | Where-Object Name -eq "List"
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
