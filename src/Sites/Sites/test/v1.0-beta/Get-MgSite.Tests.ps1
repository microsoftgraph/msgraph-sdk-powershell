BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
     # Set test mode to playback.
     $TestMode = 'playback'
     $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgSite.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName

    Select-MgProfile 'beta'
}

Describe 'Get-MgSite' {
    BeforeAll {
        $Mock.PushDescription('Get-MgSite')
    }
    
    Context 'List3'{
        It 'ShouldGetACollectionOfSites' {
            $Mock.PushScenario('ShouldGetACollectionOfSites')

            # The API currently returns an empy collection.
            $Sites = Get-MgSite
            $Sites | Should -HaveCount 0
        } 
    }

    Context 'Get5'{
        It 'ShouldGetASingleSite' {
            $Mock.PushScenario('ShouldGetASingleSite')

            $SiteId = 'root'
            $Site = Get-MgSite -SiteId $SiteId
            $Site | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphSite'
            $Site | Should -HaveCount 1
            $Site.Id | Should -Be 'dummyRootId'
            $Site.SiteCollection.HostName | Should -Be 'dummyroot.sharepoint.com'
            $Site.AdditionalProperties | Should -HaveCount 1
        }
    }

    Context 'GetViaIdentity5'{
        It 'ShouldGetASingleSiteViaInputObject' {
            $Mock.PushScenario('ShouldGetASingleSiteViaInputObject')

            $SiteId = 'root'
            $Site = Get-MgSite -InputObject @{ SiteId = $SiteId }
            $Site | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphSite'
            $Site | Should -HaveCount 1
            $Site.Id | Should -Be 'dummyRootId'
            $Site.SiteCollection.HostName | Should -Be 'dummyroot.sharepoint.com'
            $Site.AdditionalProperties | Should -HaveCount 1
        }
    }
}
