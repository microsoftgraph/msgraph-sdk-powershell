if (($null -eq $TestName) -or ($TestName -contains 'Set-MgUserPhotoContent')) {
    $TestMode = 'playback'
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Set-MgUserPhotoContent.Recording.json'
    $currentPath = $PSScriptRoot
    while (-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Set-MgUserPhotoContent' {
    BeforeAll {
        $Mock.PushDescription('Set-MgUserPhotoContent')
    }
    Context 'Update' {
        It 'ShouldUpdatePhoto' {
            $Mock.PushScenario('ShouldUpdatePhoto')
            { Set-MgUserPhotoContent -UserId contoso@microsoft.com -InFile "src\Users\v1.0\test\Langchain.jpg" } | Should -Not -Throw
        }
    }
}
