BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
}


Describe 'Check Delta' {
    It 'ShouldNotThrowExceptionWhenAllParameterIsSpecified' {
        { Get-MgUserDelta -All } | Should -Not -Throw
    }
}