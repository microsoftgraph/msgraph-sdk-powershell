---
Module Name: Microsoft.Graph.Reports
Module Guid: 2057764a-cc69-4320-b165-bb8e79614fb8
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Reports Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Reports Cmdlets
### [Confirm-MgAuditLogSignInCompromised](Confirm-MgAuditLogSignInCompromised.md)
Allow admins to mark an event in the Azure AD sign in logs as risky.
Events marked as risky by an admin are immediately flagged as high risk in Azure AD Identity Protection, overriding previous risk states.
Admins can confirm that events flagged as risky by Azure AD Identity Protection are in fact risky.
For details about investigating Identity Protection risks, see How to investigate risk.

### [Confirm-MgAuditLogSignInSafe](Confirm-MgAuditLogSignInSafe.md)
Allow admins to mark an event in Azure AD sign in logs as safe.
Admins can either mark the events flagged as risky by Azure AD Identity Protection as safe, or they can mark unflagged events as safe.
For details about investigating Identity Protection risks, see How to investigate risk.

### [Get-MgAuditLogDirectoryAudit](Get-MgAuditLogDirectoryAudit.md)
Get directoryAudits from auditLogs

### [Get-MgAuditLogDirectoryProvisioning](Get-MgAuditLogDirectoryProvisioning.md)
Get directoryProvisioning from auditLogs

### [Get-MgAuditLogProvisioning](Get-MgAuditLogProvisioning.md)
Get provisioning from auditLogs

### [Get-MgAuditLogSignIn](Get-MgAuditLogSignIn.md)
Get signIns from auditLogs

### [Get-MgDeviceManagementReport](Get-MgDeviceManagementReport.md)
Reports singleton

### [Get-MgDeviceManagementReportCachedReportConfiguration](Get-MgDeviceManagementReportCachedReportConfiguration.md)
Entity representing the configuration of a cached report

### [Get-MgDeviceManagementReportExportJob](Get-MgDeviceManagementReportExportJob.md)
Entity representing a job to export a report

### [Get-MgReportApplicationSignInDetailedSummary](Get-MgReportApplicationSignInDetailedSummary.md)
Represents a detailed summary of an application sign-in.

### [Get-MgReportAttackSimulationRepeatOffender](Get-MgReportAttackSimulationRepeatOffender.md)
Invoke function getAttackSimulationRepeatOffenders

### [Get-MgReportAttackSimulationTrainingUserCoverage](Get-MgReportAttackSimulationTrainingUserCoverage.md)
Invoke function getAttackSimulationTrainingUserCoverage

### [Get-MgReportAttackSimulationUserCoverage](Get-MgReportAttackSimulationUserCoverage.md)
Invoke function getAttackSimulationSimulationUserCoverage

### [Get-MgReportAuthenticationMethod](Get-MgReportAuthenticationMethod.md)
Container for navigation properties for Azure AD authentication methods resources.

### [Get-MgReportAuthenticationMethodUserRegistrationDetail](Get-MgReportAuthenticationMethodUserRegistrationDetail.md)
Represents the state of a user's authentication methods, including which methods are registered and which features the user is registered and capable of (such as multi-factor authentication, self-service password reset, and passwordless authentication).

### [Get-MgReportAzureAdApplicationSignInSummary](Get-MgReportAzureAdApplicationSignInSummary.md)
Invoke function getAzureADApplicationSignInSummary

### [Get-MgReportBrowserDistributionUserCount](Get-MgReportBrowserDistributionUserCount.md)
Invoke function getBrowserDistributionUserCounts

### [Get-MgReportBrowserUserCount](Get-MgReportBrowserUserCount.md)
Invoke function getBrowserUserCounts

### [Get-MgReportBrowserUserDetail](Get-MgReportBrowserUserDetail.md)
Invoke function getBrowserUserDetail

### [Get-MgReportCredentialUsageSummary](Get-MgReportCredentialUsageSummary.md)
Invoke function getCredentialUsageSummary

### [Get-MgReportCredentialUserRegistrationCount](Get-MgReportCredentialUserRegistrationCount.md)
Report the current state of how many users in your organization are registered for self-service password reset and multi-factor authentication (MFA) capabilities.

### [Get-MgReportCredentialUserRegistrationDetail](Get-MgReportCredentialUserRegistrationDetail.md)
Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.

### [Get-MgReportDailyPrintUsage](Get-MgReportDailyPrintUsage.md)
Get dailyPrintUsage from reports

### [Get-MgReportDailyPrintUsageByPrinter](Get-MgReportDailyPrintUsageByPrinter.md)
Get dailyPrintUsageByPrinter from reports

### [Get-MgReportDailyPrintUsageByUser](Get-MgReportDailyPrintUsageByUser.md)
Get dailyPrintUsageByUser from reports

### [Get-MgReportDailyPrintUsageSummaryByPrinter](Get-MgReportDailyPrintUsageSummaryByPrinter.md)
Get dailyPrintUsageSummariesByPrinter from reports

### [Get-MgReportDailyPrintUsageSummaryByUser](Get-MgReportDailyPrintUsageSummaryByUser.md)
Get dailyPrintUsageSummariesByUser from reports

### [Get-MgReportDeviceConfigurationDeviceActivity](Get-MgReportDeviceConfigurationDeviceActivity.md)
Metadata for the device configuration device activity report

### [Get-MgReportDeviceConfigurationUserActivity](Get-MgReportDeviceConfigurationUserActivity.md)
Metadata for the device configuration user activity report

### [Get-MgReportEmailActivityCount](Get-MgReportEmailActivityCount.md)
Invoke function getEmailActivityCounts

### [Get-MgReportEmailActivityUserCount](Get-MgReportEmailActivityUserCount.md)
Invoke function getEmailActivityUserCounts

### [Get-MgReportEmailActivityUserDetail](Get-MgReportEmailActivityUserDetail.md)
Invoke function getEmailActivityUserDetail

### [Get-MgReportEmailAppUsageAppUserCount](Get-MgReportEmailAppUsageAppUserCount.md)
Invoke function getEmailAppUsageAppsUserCounts

### [Get-MgReportEmailAppUsageUserCount](Get-MgReportEmailAppUsageUserCount.md)
Invoke function getEmailAppUsageUserCounts

### [Get-MgReportEmailAppUsageUserDetail](Get-MgReportEmailAppUsageUserDetail.md)
Invoke function getEmailAppUsageUserDetail

### [Get-MgReportEmailAppUsageVersionUserCount](Get-MgReportEmailAppUsageVersionUserCount.md)
Invoke function getEmailAppUsageVersionsUserCounts

### [Get-MgReportGroupArchivedPrintJob](Get-MgReportGroupArchivedPrintJob.md)
Invoke function getGroupArchivedPrintJobs

### [Get-MgReportM365AppPlatformUserCount](Get-MgReportM365AppPlatformUserCount.md)
Invoke function getM365AppPlatformUserCounts

### [Get-MgReportM365AppUserCount](Get-MgReportM365AppUserCount.md)
Invoke function getM365AppUserCounts

### [Get-MgReportM365AppUserDetail](Get-MgReportM365AppUserDetail.md)
Invoke function getM365AppUserDetail

### [Get-MgReportMailboxUsageDetail](Get-MgReportMailboxUsageDetail.md)
Invoke function getMailboxUsageDetail

### [Get-MgReportMailboxUsageMailboxCount](Get-MgReportMailboxUsageMailboxCount.md)
Invoke function getMailboxUsageMailboxCounts

### [Get-MgReportMailboxUsageQuotaStatusMailboxCount](Get-MgReportMailboxUsageQuotaStatusMailboxCount.md)
Invoke function getMailboxUsageQuotaStatusMailboxCounts

### [Get-MgReportMailboxUsageStorage](Get-MgReportMailboxUsageStorage.md)
Invoke function getMailboxUsageStorage

### [Get-MgReportManagedDeviceEnrollmentAbandonmentDetail](Get-MgReportManagedDeviceEnrollmentAbandonmentDetail.md)
Metadata for Enrollment abandonment details report

### [Get-MgReportManagedDeviceEnrollmentAbandonmentSummary](Get-MgReportManagedDeviceEnrollmentAbandonmentSummary.md)
Metadata for Enrollment abandonment summary report

### [Get-MgReportManagedDeviceEnrollmentFailureDetail](Get-MgReportManagedDeviceEnrollmentFailureDetail.md)
Invoke function managedDeviceEnrollmentFailureDetails

### [Get-MgReportManagedDeviceEnrollmentFailureTrend](Get-MgReportManagedDeviceEnrollmentFailureTrend.md)
Metadata for the enrollment failure trends report

### [Get-MgReportManagedDeviceEnrollmentTopFailures](Get-MgReportManagedDeviceEnrollmentTopFailures.md)
Invoke function managedDeviceEnrollmentTopFailures

### [Get-MgReportMonthlyPrintUsageByPrinter](Get-MgReportMonthlyPrintUsageByPrinter.md)
Get monthlyPrintUsageByPrinter from reports

### [Get-MgReportMonthlyPrintUsageByUser](Get-MgReportMonthlyPrintUsageByUser.md)
Get monthlyPrintUsageByUser from reports

### [Get-MgReportMonthlyPrintUsageSummaryByPrinter](Get-MgReportMonthlyPrintUsageSummaryByPrinter.md)
Get monthlyPrintUsageSummariesByPrinter from reports

### [Get-MgReportMonthlyPrintUsageSummaryByUser](Get-MgReportMonthlyPrintUsageSummaryByUser.md)
Get monthlyPrintUsageSummariesByUser from reports

### [Get-MgReportOffice365ActivationCount](Get-MgReportOffice365ActivationCount.md)
Invoke function getOffice365ActivationCounts

### [Get-MgReportOffice365ActivationUserCount](Get-MgReportOffice365ActivationUserCount.md)
Invoke function getOffice365ActivationsUserCounts

### [Get-MgReportOffice365ActivationUserDetail](Get-MgReportOffice365ActivationUserDetail.md)
Invoke function getOffice365ActivationsUserDetail

### [Get-MgReportOffice365ActiveUserCount](Get-MgReportOffice365ActiveUserCount.md)
Invoke function getOffice365ActiveUserCounts

### [Get-MgReportOffice365ActiveUserDetail](Get-MgReportOffice365ActiveUserDetail.md)
Invoke function getOffice365ActiveUserDetail

### [Get-MgReportOffice365GroupActivityCount](Get-MgReportOffice365GroupActivityCount.md)
Invoke function getOffice365GroupsActivityCounts

### [Get-MgReportOffice365GroupActivityDetail](Get-MgReportOffice365GroupActivityDetail.md)
Invoke function getOffice365GroupsActivityDetail

### [Get-MgReportOffice365GroupActivityFileCount](Get-MgReportOffice365GroupActivityFileCount.md)
Invoke function getOffice365GroupsActivityFileCounts

### [Get-MgReportOffice365GroupActivityGroupCount](Get-MgReportOffice365GroupActivityGroupCount.md)
Invoke function getOffice365GroupsActivityGroupCounts

### [Get-MgReportOffice365GroupActivityStorage](Get-MgReportOffice365GroupActivityStorage.md)
Invoke function getOffice365GroupsActivityStorage

### [Get-MgReportOffice365ServiceUserCount](Get-MgReportOffice365ServiceUserCount.md)
Invoke function getOffice365ServicesUserCounts

### [Get-MgReportOneDriveActivityFileCount](Get-MgReportOneDriveActivityFileCount.md)
Invoke function getOneDriveActivityFileCounts

### [Get-MgReportOneDriveActivityUserCount](Get-MgReportOneDriveActivityUserCount.md)
Invoke function getOneDriveActivityUserCounts

### [Get-MgReportOneDriveActivityUserDetail](Get-MgReportOneDriveActivityUserDetail.md)
Invoke function getOneDriveActivityUserDetail

### [Get-MgReportOneDriveUsageAccountCount](Get-MgReportOneDriveUsageAccountCount.md)
Invoke function getOneDriveUsageAccountCounts

### [Get-MgReportOneDriveUsageAccountDetail](Get-MgReportOneDriveUsageAccountDetail.md)
Invoke function getOneDriveUsageAccountDetail

### [Get-MgReportOneDriveUsageFileCount](Get-MgReportOneDriveUsageFileCount.md)
Invoke function getOneDriveUsageFileCounts

### [Get-MgReportOneDriveUsageStorage](Get-MgReportOneDriveUsageStorage.md)
Invoke function getOneDriveUsageStorage

### [Get-MgReportPrinterArchivedPrintJob](Get-MgReportPrinterArchivedPrintJob.md)
Invoke function getPrinterArchivedPrintJobs

### [Get-MgReportRelyingPartyDetailedSummary](Get-MgReportRelyingPartyDetailedSummary.md)
Invoke function getRelyingPartyDetailedSummary

### [Get-MgReportSecurity](Get-MgReportSecurity.md)
Provides the ability to launch a realistic simulated phishing attack that organizations can learn from.

### [Get-MgReportSecurityAttackSimulationRepeatOffender](Get-MgReportSecurityAttackSimulationRepeatOffender.md)
Invoke function getAttackSimulationRepeatOffenders

### [Get-MgReportSecurityAttackSimulationTrainingUserCoverage](Get-MgReportSecurityAttackSimulationTrainingUserCoverage.md)
Invoke function getAttackSimulationTrainingUserCoverage

### [Get-MgReportSecurityAttackSimulationUserCoverage](Get-MgReportSecurityAttackSimulationUserCoverage.md)
Invoke function getAttackSimulationSimulationUserCoverage

### [Get-MgReportSharePointActivityFileCount](Get-MgReportSharePointActivityFileCount.md)
Invoke function getSharePointActivityFileCounts

### [Get-MgReportSharePointActivityPage](Get-MgReportSharePointActivityPage.md)
Invoke function getSharePointActivityPages

### [Get-MgReportSharePointActivityUserCount](Get-MgReportSharePointActivityUserCount.md)
Invoke function getSharePointActivityUserCounts

### [Get-MgReportSharePointActivityUserDetail](Get-MgReportSharePointActivityUserDetail.md)
Invoke function getSharePointActivityUserDetail

### [Get-MgReportSharePointSiteUsageDetail](Get-MgReportSharePointSiteUsageDetail.md)
Invoke function getSharePointSiteUsageDetail

### [Get-MgReportSharePointSiteUsageFileCount](Get-MgReportSharePointSiteUsageFileCount.md)
Invoke function getSharePointSiteUsageFileCounts

### [Get-MgReportSharePointSiteUsagePage](Get-MgReportSharePointSiteUsagePage.md)
Invoke function getSharePointSiteUsagePages

### [Get-MgReportSharePointSiteUsageSiteCount](Get-MgReportSharePointSiteUsageSiteCount.md)
Invoke function getSharePointSiteUsageSiteCounts

### [Get-MgReportSharePointSiteUsageStorage](Get-MgReportSharePointSiteUsageStorage.md)
Invoke function getSharePointSiteUsageStorage

### [Get-MgReportSkypeForBusinessActivityCount](Get-MgReportSkypeForBusinessActivityCount.md)
Invoke function getSkypeForBusinessActivityCounts

### [Get-MgReportSkypeForBusinessActivityUserCount](Get-MgReportSkypeForBusinessActivityUserCount.md)
Invoke function getSkypeForBusinessActivityUserCounts

### [Get-MgReportSkypeForBusinessActivityUserDetail](Get-MgReportSkypeForBusinessActivityUserDetail.md)
Invoke function getSkypeForBusinessActivityUserDetail

### [Get-MgReportSkypeForBusinessDeviceUsageDistributionUserCount](Get-MgReportSkypeForBusinessDeviceUsageDistributionUserCount.md)
Invoke function getSkypeForBusinessDeviceUsageDistributionUserCounts

### [Get-MgReportSkypeForBusinessDeviceUsageUserCount](Get-MgReportSkypeForBusinessDeviceUsageUserCount.md)
Invoke function getSkypeForBusinessDeviceUsageUserCounts

### [Get-MgReportSkypeForBusinessDeviceUsageUserDetail](Get-MgReportSkypeForBusinessDeviceUsageUserDetail.md)
Invoke function getSkypeForBusinessDeviceUsageUserDetail

### [Get-MgReportSkypeForBusinessOrganizerActivityCount](Get-MgReportSkypeForBusinessOrganizerActivityCount.md)
Invoke function getSkypeForBusinessOrganizerActivityCounts

### [Get-MgReportSkypeForBusinessOrganizerActivityMinuteCount](Get-MgReportSkypeForBusinessOrganizerActivityMinuteCount.md)
Invoke function getSkypeForBusinessOrganizerActivityMinuteCounts

### [Get-MgReportSkypeForBusinessOrganizerActivityUserCount](Get-MgReportSkypeForBusinessOrganizerActivityUserCount.md)
Invoke function getSkypeForBusinessOrganizerActivityUserCounts

### [Get-MgReportSkypeForBusinessParticipantActivityCount](Get-MgReportSkypeForBusinessParticipantActivityCount.md)
Invoke function getSkypeForBusinessParticipantActivityCounts

### [Get-MgReportSkypeForBusinessParticipantActivityMinuteCount](Get-MgReportSkypeForBusinessParticipantActivityMinuteCount.md)
Invoke function getSkypeForBusinessParticipantActivityMinuteCounts

### [Get-MgReportSkypeForBusinessParticipantActivityUserCount](Get-MgReportSkypeForBusinessParticipantActivityUserCount.md)
Invoke function getSkypeForBusinessParticipantActivityUserCounts

### [Get-MgReportSkypeForBusinessPeerToPeerActivityCount](Get-MgReportSkypeForBusinessPeerToPeerActivityCount.md)
Invoke function getSkypeForBusinessPeerToPeerActivityCounts

### [Get-MgReportSkypeForBusinessPeerToPeerActivityMinuteCount](Get-MgReportSkypeForBusinessPeerToPeerActivityMinuteCount.md)
Invoke function getSkypeForBusinessPeerToPeerActivityMinuteCounts

### [Get-MgReportSkypeForBusinessPeerToPeerActivityUserCount](Get-MgReportSkypeForBusinessPeerToPeerActivityUserCount.md)
Invoke function getSkypeForBusinessPeerToPeerActivityUserCounts

### [Get-MgReportTeamActivityCount](Get-MgReportTeamActivityCount.md)
Invoke function getTeamsTeamActivityCounts

### [Get-MgReportTeamActivityDetail](Get-MgReportTeamActivityDetail.md)
Invoke function getTeamsTeamActivityDetail

### [Get-MgReportTeamActivityDistributionCount](Get-MgReportTeamActivityDistributionCount.md)
Invoke function getTeamsTeamActivityDistributionCounts

### [Get-MgReportTeamDeviceUsageDistributionTotalUserCount](Get-MgReportTeamDeviceUsageDistributionTotalUserCount.md)
Invoke function getTeamsDeviceUsageDistributionTotalUserCounts

### [Get-MgReportTeamDeviceUsageDistributionUserCount](Get-MgReportTeamDeviceUsageDistributionUserCount.md)
Invoke function getTeamsDeviceUsageDistributionUserCounts

### [Get-MgReportTeamDeviceUsageTotalUserCount](Get-MgReportTeamDeviceUsageTotalUserCount.md)
Invoke function getTeamsDeviceUsageTotalUserCounts

### [Get-MgReportTeamDeviceUsageUserCount](Get-MgReportTeamDeviceUsageUserCount.md)
Invoke function getTeamsDeviceUsageUserCounts

### [Get-MgReportTeamDeviceUsageUserDetail](Get-MgReportTeamDeviceUsageUserDetail.md)
Invoke function getTeamsDeviceUsageUserDetail

### [Get-MgReportTeamUserActivityCount](Get-MgReportTeamUserActivityCount.md)
Invoke function getTeamsUserActivityCounts

### [Get-MgReportTeamUserActivityDistributionTotalUserCount](Get-MgReportTeamUserActivityDistributionTotalUserCount.md)
Invoke function getTeamsUserActivityDistributionTotalUserCounts

### [Get-MgReportTeamUserActivityDistributionUserCount](Get-MgReportTeamUserActivityDistributionUserCount.md)
Invoke function getTeamsUserActivityDistributionUserCounts

### [Get-MgReportTeamUserActivityTotalCount](Get-MgReportTeamUserActivityTotalCount.md)
Invoke function getTeamsUserActivityTotalCounts

### [Get-MgReportTeamUserActivityTotalDistributionCount](Get-MgReportTeamUserActivityTotalDistributionCount.md)
Invoke function getTeamsUserActivityTotalDistributionCounts

### [Get-MgReportTeamUserActivityTotalUserCount](Get-MgReportTeamUserActivityTotalUserCount.md)
Invoke function getTeamsUserActivityTotalUserCounts

### [Get-MgReportTeamUserActivityUserCount](Get-MgReportTeamUserActivityUserCount.md)
Invoke function getTeamsUserActivityUserCounts

### [Get-MgReportTeamUserActivityUserDetail](Get-MgReportTeamUserActivityUserDetail.md)
Invoke function getTeamsUserActivityUserDetail

### [Get-MgReportUserArchivedPrintJob](Get-MgReportUserArchivedPrintJob.md)
Invoke function getUserArchivedPrintJobs

### [Get-MgReportUserCredentialUsageDetail](Get-MgReportUserCredentialUsageDetail.md)
Represents the self-service password reset (SSPR) usage for a given tenant.

### [Get-MgReportYammerActivityCount](Get-MgReportYammerActivityCount.md)
Invoke function getYammerActivityCounts

### [Get-MgReportYammerActivityUserCount](Get-MgReportYammerActivityUserCount.md)
Invoke function getYammerActivityUserCounts

### [Get-MgReportYammerActivityUserDetail](Get-MgReportYammerActivityUserDetail.md)
Invoke function getYammerActivityUserDetail

### [Get-MgReportYammerDeviceUsageDistributionUserCount](Get-MgReportYammerDeviceUsageDistributionUserCount.md)
Invoke function getYammerDeviceUsageDistributionUserCounts

### [Get-MgReportYammerDeviceUsageUserCount](Get-MgReportYammerDeviceUsageUserCount.md)
Invoke function getYammerDeviceUsageUserCounts

### [Get-MgReportYammerDeviceUsageUserDetail](Get-MgReportYammerDeviceUsageUserDetail.md)
Invoke function getYammerDeviceUsageUserDetail

### [Get-MgReportYammerGroupActivityCount](Get-MgReportYammerGroupActivityCount.md)
Invoke function getYammerGroupsActivityCounts

### [Get-MgReportYammerGroupActivityDetail](Get-MgReportYammerGroupActivityDetail.md)
Invoke function getYammerGroupsActivityDetail

### [Get-MgReportYammerGroupActivityGroupCount](Get-MgReportYammerGroupActivityGroupCount.md)
Invoke function getYammerGroupsActivityGroupCounts

### [Invoke-MgGraphReportAuthenticationMethod](Invoke-MgGraphReportAuthenticationMethod.md)
Invoke function usersRegisteredByFeature

### [New-MgReportAuthenticationMethodUserRegistrationDetail](New-MgReportAuthenticationMethodUserRegistrationDetail.md)
Create new navigation property to userRegistrationDetails for reports

### [Remove-MgDeviceManagementReport](Remove-MgDeviceManagementReport.md)
Delete navigation property reports for deviceManagement

### [Remove-MgReportAuthenticationMethodUserRegistrationDetail](Remove-MgReportAuthenticationMethodUserRegistrationDetail.md)
Delete navigation property userRegistrationDetails for reports

### [Update-MgDeviceManagementReport](Update-MgDeviceManagementReport.md)
Update the navigation property reports in deviceManagement

### [Update-MgReportAuthenticationMethodUserRegistrationDetail](Update-MgReportAuthenticationMethodUserRegistrationDetail.md)
Update the navigation property userRegistrationDetails in reports

