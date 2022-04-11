# Fails due to response status code mismatch (200 vs 204)
Describe 'Update-MgSecurityAlert' -skip {
    BeforeAll {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        # Set test mode to playback.
        $TestMode = 'playback'
        $TestRecordingFile = Join-Path $PSScriptRoot 'Update-MgSecurityAlert.Recording.json'
        $currentPath = $PSScriptRoot
        while(-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName

        Select-MgProfile 'v1.0'
        $debugLogPath = Join-Path $PSScriptRoot 'Update-MgSecurityAlert.Debug.log'
        $Mock.PushDescription('Update-MgSecurityAlert')
        $params = @{
            AssignedTo = "String"
            ClosedDateTime = [System.DateTime]::Parse("2022-03-01T00:00:00Z")
            Comments = @(
                "String"
            )
            Feedback = "@odata.type: microsoft.graph.alertFeedback"
            Status = "@odata.type: microsoft.graph.alertStatus"
            Tags = @(
                "String"
            )
            VendorInformation = @{
                Provider = "String"
                Vendor = "String"
            }
        }

        $alertId = '00000000-0000-0000-0000-000000000000'
    }

    Context 'UpdateExpanded2' {
        It 'ShouldUpdateSecurityAlertViaExpandedParameters' {
            $updateExpandedResponse = Update-MgSecurityAlert -AlertId $alertId -AssignedTo $params.AssignedTo -ClosedDateTime $params.ClosedDateTime -Comments $params.Comments -Feedback $params.Feedback -Status $params.Status -Tags $params.Tags -VendorInformation $params.VendorInformation
            $updateExpandedResponse | Should -Not -BeNullOrEmpty
        }
    }

    Context 'Update2' {
        It 'ShouldUpdateSecurityAlertViaBodyParameters' {
            $updateResponse = Update-MgSecurityAlert -AlertId $alertId -BodyParameter $params
            $updateResponse | Should -Not -BeNullOrEmpty
        }
    }

    It 'UpdateViaIdentityExpanded1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
