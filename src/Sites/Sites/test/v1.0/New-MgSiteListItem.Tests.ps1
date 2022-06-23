BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    # Set test mode to playback.
    $TestMode = 'playback'
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgSiteListItem.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName

    Select-MgProfile 'v1.0'
}

Describe 'New-MgSiteListItem' {
    BeforeAll {
        $Mock.PushDescription('New-MgSiteListItem')
        $siteId = "root"
        $listId = "listId"
        $fields = @{
            Title = "Test"
        }
    }

    Context 'CreateExpanded' {
        It 'Should create site list item with custom fields' {
            $Mock.PushScenario('ShouldCreateSiteListItemWithFields')
            # Redirect debug stream to variable.
            $ListItem = New-MgSiteListItem -SiteId $siteId -ListId $listId -Fields $fields -Debug -Confirm:$false 5>&1

            $ListItem.Fields.AdditionalProperties.Title | Should -Be $fields.Title
            $HttpRequestLog = $ListItem | Where-Object { $_ -Like "*HTTP REQUEST*" }
            $HttpRequestLog.Message | Should -BeLikeExactly '*"Title": "Test"*'
        }
    }

    Context 'Create' {
        It 'Should create site list item with custom fields' {
            $Mock.PushScenario('ShouldCreateSiteListItemWithFields')
            $params = @{
                Fields = $fields
            }
            # Redirect debug stream to variable.
            $ListItem = New-MgSiteListItem -SiteId $siteId -ListId $listId -BodyParameter $params -Debug -Confirm:$false 5>&1

            $ListItem.Fields.AdditionalProperties.Title | Should -Be $fields.Title
            $HttpRequestLog = $ListItem | Where-Object { $_ -Like "*HTTP REQUEST*" }
            $HttpRequestLog.Message | Should -BeLikeExactly '*"Title": "Test"*'
        }
    }
}
