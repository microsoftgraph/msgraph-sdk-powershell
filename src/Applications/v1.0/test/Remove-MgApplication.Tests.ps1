Describe "Remove-MgApplication" {
    BeforeAll {
        $RemoveMgApplication = Get-Command Remove-MgApplication
    }

    It "Should support minimum set of parameter sets" {
        $RemoveMgApplication.ParameterSets.Name | Should -BeIn @("Delete", "DeleteViaIdentity")
        $RemoveMgApplication.Visibility | Should -Be "Public"
        $RemoveMgApplication.CommandType | Should -Be "Function"
    }

    It "Should support Delete parameterSet by default" {
        $RemoveMgApplication.OutputType | Should -Be "System.Boolean"
        $RemoveMgApplication.DefaultParameterSet | Should -Be "Delete"
    }

    It 'Should have Delete parameterSet' {
        $DeleteParameterSet = $RemoveMgApplication.ParameterSets | Where-Object Name -eq "Delete"
        $DeleteParameterSet.Parameters.Name | Should -Contain ApplicationId
        $DeleteParameterSet.Parameters.Name | Should -Contain Confirm
    }

    It 'Should have DeleteViaIdentity parameterSet' {
        $DeleteViaIdentityParameterSet = $RemoveMgApplication.ParameterSets | Where-Object Name -eq "DeleteViaIdentity"
        $DeleteViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $DeleteViaIdentityParameterSet.Parameters.Name | Should -Contain Confirm
    }
}
