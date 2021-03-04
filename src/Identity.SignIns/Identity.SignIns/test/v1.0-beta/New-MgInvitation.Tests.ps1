BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    # Set test mode to playback.
    $TestMode = 'playback'
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgInvitation.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
    # Switch to beta profile.
    Select-MgProfile beta
}

Describe 'New-MgInvitation' {
    BeforeAll {
        $Mock.PushDescription('New-MgInvitation')
    }

    Context 'CreateExpanded1' {   
        It 'ShouldCreateInvite' {
            $Mock.PushScenario('ShouldCreateInvite')
            $Params = @{
                InvitedUserDisplayName = $env.Users[0].DisplayName
                InvitedUserEmailAddress = $env.Users[0].Mail
                InviteRedirectUrl = 'https://myapp.contoso.com'
            }
            $Invitation = New-MgInvitation @Params
            $Invitation | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphInvitation1'
            $Invitation | Should -HaveCount 1
            $Invitation.InvitedUserDisplayName | Should -Be $env.Users[0].DisplayName
            $Invitation.Status | Should -Be 'PendingAcceptance'
            $Invitation.AdditionalProperties | Should -HaveCount 1
        }

        It 'ShouldThrowInvalidEmailError' {
            $Mock.PushScenario('ShouldThrowInvalidEmailError')
            $MyUser = [Microsoft.Graph.PowerShell.Models.MicrosoftGraphUser1]@{
                Id = $env.Users[0].UserId
                DisplayName = $env.Users[0].DisplayName
                Mail = $env.Users[0].Mail
                UserPrincipalName = $env.Users[0].Mail
            }
            { New-MgInvitation -InvitedUser $MyUser -ErrorAction Stop } | Should -Throw -ErrorId 'BadRequest,Microsoft.Graph.PowerShell.Cmdlets.NewMgInvitation_CreateExpanded1' -ExpectedMessage 'Invalid Email Address' -ExceptionType 'Microsoft.Graph.PowerShell.Runtime.RestException<Microsoft.Graph.PowerShell.Models.IOdataError>' 
        }
    }

    Context 'Create1' {
        It 'ShouldCreateInvite' {
            $Mock.PushScenario('ShouldCreateInvite')
            $Params = @{
                InvitedUserDisplayName = $env.Users[0].DisplayName
                InvitedUserEmailAddress = $env.Users[0].Mail
                InviteRedirectUrl = 'https://myapp.contoso.com'
            }
            $Invitation = New-MgInvitation -BodyParameter $Params
            $Invitation | Should -BeOfType -ExpectedType 'Microsoft.Graph.PowerShell.Models.MicrosoftGraphInvitation1'
            $Invitation | Should -HaveCount 1
            $Invitation.InvitedUserDisplayName | Should -Be $env.Users[0].DisplayName
            $Invitation.Status | Should -Be 'PendingAcceptance'
            $Invitation.AdditionalProperties | Should -HaveCount 1
        }

        It 'ShouldThrowInvalidEmailError' {
            $Mock.PushScenario('ShouldThrowInvalidEmailError')
            $MyUser = [Microsoft.Graph.PowerShell.Models.MicrosoftGraphUser1]@{
                Id = $env.Users[0].UserId
                DisplayName = $env.Users[0].DisplayName
                Mail = $env.Users[0].Mail
                UserPrincipalName = $env.Users[0].Mail
            }
            { New-MgInvitation -BodyParameter @{ InvitedUser = $MyUser } -ErrorAction Stop } | Should -Throw -ErrorId 'BadRequest,Microsoft.Graph.PowerShell.Cmdlets.NewMgInvitation_Create1' -ExpectedMessage 'Invalid Email Address' -ExceptionType 'Microsoft.Graph.PowerShell.Runtime.RestException<Microsoft.Graph.PowerShell.Models.IOdataError>' 
        }
    }
}