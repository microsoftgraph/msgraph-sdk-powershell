@{
  GUID = '326570eb-1651-4244-a506-d863bd2ecf4e'
  RootModule = './Microsoft.Graph.Groups.Actions.psm1'
  ModuleVersion = '0.2.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Graph PowerShell Cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Microsoft.Graph.Groups.Actions.private.dll'
  FormatsToProcess = './Microsoft.Graph.Groups.Actions.format.ps1xml'
  FunctionsToExport = 'Add-MgGroupFavorite', 'Confirm-MgGroupGrantedPermission', 'Confirm-MgGroupMemberGroup', 'Confirm-MgGroupMemberObject', 'Copy-MgGroupOnenoteNotebook', 'Copy-MgGroupOnenoteNotebookSectionGroupSectionPageToSection', 'Copy-MgGroupOnenoteNotebookSectionGroupSectionToNotebook', 'Copy-MgGroupOnenoteNotebookSectionGroupSectionToSectionGroup', 'Copy-MgGroupOnenoteNotebookSectionPageToSection', 'Copy-MgGroupOnenoteNotebookSectionToNotebook', 'Copy-MgGroupOnenoteNotebookSectionToSectionGroup', 'Copy-MgGroupOnenotePageToSection', 'Copy-MgGroupOnenoteSectionGroupSectionPageToSection', 'Copy-MgGroupOnenoteSectionGroupSectionToNotebook', 'Copy-MgGroupOnenoteSectionGroupSectionToSectionGroup', 'Copy-MgGroupOnenoteSectionPageToSection', 'Copy-MgGroupOnenoteSectionToNotebook', 'Copy-MgGroupOnenoteSectionToSectionGroup', 'Get-MgGroup', 'Get-MgGroupCalendarEventCalendarSchedule', 'Get-MgGroupCalendarSchedule', 'Get-MgGroupEventCalendarSchedule', 'Get-MgGroupMemberGroup', 'Get-MgGroupMemberObject', 'Get-MgGroupOnenoteNotebookFromWebUrl', 'Get-MgGroupUserOwnedObject', 'Invoke-MgAcceptGroupCalendarEvent', 'Invoke-MgAcceptGroupCalendarEventInstance', 'Invoke-MgAcceptGroupCalendarEventInstanceTentatively', 'Invoke-MgAcceptGroupCalendarEventTentatively', 'Invoke-MgAcceptGroupEvent', 'Invoke-MgAcceptGroupEventCalendarEvent', 'Invoke-MgAcceptGroupEventCalendarEventTentatively', 'Invoke-MgAcceptGroupEventInstance', 'Invoke-MgAcceptGroupEventInstanceTentatively', 'Invoke-MgAcceptGroupEventTentatively', 'Invoke-MgDeclineGroupCalendarEvent', 'Invoke-MgDeclineGroupCalendarEventInstance', 'Invoke-MgDeclineGroupEvent', 'Invoke-MgDeclineGroupEventCalendarEvent', 'Invoke-MgDeclineGroupEventInstance', 'Invoke-MgDismissGroupCalendarEventInstanceReminder', 'Invoke-MgDismissGroupCalendarEventReminder', 'Invoke-MgDismissGroupEventCalendarEventReminder', 'Invoke-MgDismissGroupEventInstanceReminder', 'Invoke-MgDismissGroupEventReminder', 'Invoke-MgForwardGroupCalendarEvent', 'Invoke-MgForwardGroupCalendarEventInstance', 'Invoke-MgForwardGroupConversationThreadPost', 'Invoke-MgForwardGroupConversationThreadPostInReplyTo', 'Invoke-MgForwardGroupEvent', 'Invoke-MgForwardGroupEventCalendarEvent', 'Invoke-MgForwardGroupEventInstance', 'Invoke-MgForwardGroupThreadPost', 'Invoke-MgForwardGroupThreadPostInReplyTo', 'Invoke-MgRenewGroup', 'Invoke-MgReplyGroupConversationThread', 'Invoke-MgReplyGroupConversationThreadPost', 'Invoke-MgReplyGroupConversationThreadPostInReplyTo', 'Invoke-MgReplyGroupThread', 'Invoke-MgReplyGroupThreadPost', 'Invoke-MgReplyGroupThreadPostInReplyTo', 'Invoke-MgSnoozeGroupCalendarEventInstanceReminder', 'Invoke-MgSnoozeGroupCalendarEventReminder', 'Invoke-MgSnoozeGroupEventCalendarEventReminder', 'Invoke-MgSnoozeGroupEventInstanceReminder', 'Invoke-MgSnoozeGroupEventReminder', 'Invoke-MgSubscribeGroup', 'Invoke-MgUnsubscribeGroup', 'New-MgGroupCalendarEventAttachmentUploadSession', 'New-MgGroupConversationThreadPostAttachmentUploadSession', 'New-MgGroupEventAttachmentUploadSession', 'New-MgGroupThreadPostAttachmentUploadSession', 'Remove-MgGroupFavorite', 'Reset-MgGroupUnseenCount', 'Restore-MgGroup', 'Set-MgGroupLicense', 'Stop-MgGroupCalendarEvent', 'Stop-MgGroupCalendarEventInstance', 'Stop-MgGroupEvent', 'Stop-MgGroupEventCalendarEvent', 'Stop-MgGroupEventInstance', 'Test-MgGroupDynamicMembership', 'Test-MgGroupProperty', 'Update-MgGroupOnenoteNotebookSectionGroupSectionPage', 'Update-MgGroupOnenoteNotebookSectionPage', 'Update-MgGroupOnenotePage', 'Update-MgGroupOnenoteSectionGroupSectionPage', 'Update-MgGroupOnenoteSectionPage', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Microsoft', 'Office365', 'Graph', 'PowerShell'
      LicenseUri = 'https://aka.ms/devservicesagreement'
      ProjectUri = 'https://github.com/microsoftgraph/msgraph-sdk-powershell'
      ReleaseNotes = ''
    }
  }
}
