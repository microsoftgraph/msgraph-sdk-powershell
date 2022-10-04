Describe "Get-MgApplicationLogo" {
    BeforeAll {
        $GetMgApplicationLogo = Get-Command Get-MgApplicationLogo
    }

    It "Should support minimum set of parameter sets" {
        $GetMgApplicationLogo.ParameterSets.Name | Should -BeIn @("Get", "GetViaIdentity")
        $GetMgApplicationLogo.Visibility | Should -Be "Public"
        $GetMgApplicationLogo.CommandType | Should -Be "Function"
    }

    It "Should return an application's logo by default" {
        $GetMgApplicationLogo.OutputType | Should -Be "System.Boolean"
        $GetMgApplicationLogo.DefaultParameterSet | Should -Be "Get"
    }

    It 'Should have Get parameterSet' {
        $GetParameterSet = $GetMgApplicationLogo.ParameterSets | Where-Object Name -eq "Get"
        $GetParameterSet.Parameters.Name | Should -Contain ApplicationId
        $GetParameterSet.Parameters.Name | Should -Contain OutFile
        $GetParameterSet.Parameters.Name | Should -Contain PassThru
    }

    It 'Should have GetViaIdentity parameterSet' {
        $GetViaIdentityParameterSet = $GetMgApplicationLogo.ParameterSets | Where-Object Name -eq "GetViaIdentity"
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain InputObject
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain OutFile
        $GetViaIdentityParameterSet.Parameters.Name | Should -Contain PassThru
    }
}
