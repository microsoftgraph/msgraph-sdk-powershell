BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    # Set test mode to playback.
    $TestMode = 'playback'
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgSiteByPath.Recording.json'
    $currentPath = $PSScriptRoot

    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName

    Select-MgProfile 'beta'
}

# Skip because /sites/{site-id}/microsoft.graph.getByPath(path='{path}') returns a 400 and is not documented.
Describe 'Get-MgSiteByPath' {
    BeforeAll {
        $Mock.PushDescription('Get-MgSiteByPath')
    }

    Context 'Get' {
        It 'ShouldFailToGetSiteByPath' {
            $Mock.PushScenario('ShouldFailToGetSiteByPath')
            
            $SiteId = "root"
            { Get-MgSiteByPath -SiteId $SiteId -Path "randomPath" -ErrorAction Stop } | Should -Throw -ErrorId 'invalidRequest,Microsoft.Graph.PowerShell.Cmdlets.GetMgSiteByPath_Get' -ExpectedMessage 'Invalid request' -ExceptionType 'Microsoft.Graph.PowerShell.Runtime.RestException<Microsoft.Graph.PowerShell.Models.IOdataError>'
        }
    }

    Context 'GetViaIdentity' {
        It 'ShouldFailToGetSiteByPathViaInputObject' {
            $Mock.PushScenario('ShouldFailToGetSiteByPathViaInputObject')
            
            $SiteId = "root"
            { Get-MgSiteByPath -InputObject @{ SiteId = $SiteId; Path = "randomPath" } -ErrorAction Stop } | Should -Throw -ErrorId 'invalidRequest,Microsoft.Graph.PowerShell.Cmdlets.GetMgSiteByPath_GetViaIdentity' -ExpectedMessage 'Invalid request' -ExceptionType 'Microsoft.Graph.PowerShell.Runtime.RestException<Microsoft.Graph.PowerShell.Models.IOdataError>'

        }
    }
}
