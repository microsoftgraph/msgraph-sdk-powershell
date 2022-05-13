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

    Select-MgProfile 'beta'
}

Describe 'Get-MgSubSite' {
    BeforeAll {
        $Mock.PushDescription('Get-MgSubSite')
    }

    Context 'List' {
        It 'ShouldGetACollectionOfSubSites' {
            $Mock.PushScenario('ShouldGetACollectionOfSubSites')

            $SiteId = "root"
            $SubSites = Get-MgSubSite -SiteId $SiteId
            $SubSites | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphSite1'
            $SubSites | Should -HaveCount 2
            $SubSites.AdditionalProperties | Should -HaveCount 2
        }
    }

    Context 'Get1' {
        It 'ShouldGetASingleSubSite' {
            $Mock.PushScenario('ShouldGetASingleSubSite')

            $SiteId = "root"
            $SubSite = Get-MgSubSite -SiteId $SiteId -SiteId1 "randomId"
            $SubSite | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphSite1'
            $SubSite | Should -HaveCount 1
            $SubSite.Id | Should -Be 'randomId'
            $SubSite.WebUrl | Should -Be 'https://contoso.sharepoint.com/sites/site/subsiteA'
            $SubSite.AdditionalProperties | Should -HaveCount 1
        }
    }

    Context 'GetViaIdentity1' {
        It 'ShouldGetASingleSubSiteViaInputObject' {
            $Mock.PushScenario('ShouldGetASingleSubSiteViaInputObject')

            $SiteId = "root"
            $SubSite = Get-MgSubSite -InputObject @{ SiteId = $SiteId; SiteId1 = "randomId" }
            $SubSite | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphSite1'
            $SubSite | Should -HaveCount 1
            $SubSite.Id | Should -Be 'randomId'
            $SubSite.WebUrl | Should -Be 'https://contoso.sharepoint.com/sites/site/subsiteA'
            $SubSite.AdditionalProperties | Should -HaveCount 1
        }
    }
}
