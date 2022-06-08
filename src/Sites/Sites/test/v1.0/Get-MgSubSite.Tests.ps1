BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    # Set test mode to playback.
    $TestMode = 'playback'
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgSubSite.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName

    Select-MgProfile 'v1.0'
}

Describe 'Get-MgSubSite' {
    BeforeAll {
        $Mock.PushDescription('Get-MgSubSite')
    }

    Context 'List2' {
        It 'ShouldGetACollectionOfSubSites' {
            $Mock.PushScenario('ShouldGetACollectionOfSubSites')

            $SiteId = "root"
            $SubSites = Get-MgSubSite -SiteId $SiteId
            $SubSites | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphSite'
            $SubSites | Should -HaveCount 2
            $SubSites.AdditionalProperties | Should -HaveCount 2
        }
    }
}
