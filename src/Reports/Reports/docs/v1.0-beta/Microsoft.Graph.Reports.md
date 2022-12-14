---
Module Name: Microsoft.Graph.Beta.Reports
Module Guid: 2057764a-cc69-4320-b165-bb8e79614fb8
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.reports
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Reports Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Reports Cmdlets
### [Confirm-MgBetaAuditLogSignInCompromised](Confirm-MgBetaAuditLogSignInCompromised.md)
Allow admins to mark an event in the Azure AD sign in logs as risky.
Events marked as risky by an admin are immediately flagged as high risk in Azure AD Identity Protection, overriding previous risk states.
Admins can confirm that events flagged as risky by Azure AD Identity Protection are in fact risky.
For details about investigating Identity Protection risks, see How to investigate risk.

### [Confirm-MgBetaAuditLogSignInSafe](Confirm-MgBetaAuditLogSignInSafe.md)
Allow admins to mark an event in Azure AD sign in logs as safe.
Admins can either mark the events flagged as risky by Azure AD Identity Protection as safe, or they can mark unflagged events as safe.
For details about investigating Identity Protection risks, see How to investigate risk.

### [Get-MgBetaAuditLogDirectoryAudit](Get-MgBetaAuditLogDirectoryAudit.md)
Get directoryAudits from auditLogs

### [Get-MgBetaAuditLogDirectoryProvisioning](Get-MgBetaAuditLogDirectoryProvisioning.md)
Get directoryProvisioning from auditLogs

### [Get-MgBetaAuditLogProvisioning](Get-MgBetaAuditLogProvisioning.md)
Get provisioning from auditLogs

### [Get-MgBetaAuditLogSignIn](Get-MgBetaAuditLogSignIn.md)
Get signIns from auditLogs

### [Get-MgBetaDeviceManagementReport](Get-MgBetaDeviceManagementReport.md)
Reports singleton

### [Get-MgBetaDeviceManagementReportCachedReportConfiguration](Get-MgBetaDeviceManagementReportCachedReportConfiguration.md)
Entity representing the configuration of a cached report

### [Get-MgBetaDeviceManagementReportExportJob](Get-MgBetaDeviceManagementReportExportJob.md)
Entity representing a job to export a report

### [Get-MgBetaReportApplicationSignInDetailedSummary](Get-MgBetaReportApplicationSignInDetailedSummary.md)
Represents a detailed summary of an application sign-in.

### [Get-MgBetaReportAttackSimulationRepeatOffender](Get-MgBetaReportAttackSimulationRepeatOffender.md)
Invoke function getAttackSimulationRepeatOffenders

### [Get-MgBetaReportAttackSimulationTrainingUserCoverage](Get-MgBetaReportAttackSimulationTrainingUserCoverage.md)
Invoke function getAttackSimulationTrainingUserCoverage

### [Get-MgBetaReportAttackSimulationUserCoverage](Get-MgBetaReportAttackSimulationUserCoverage.md)
Invoke function getAttackSimulationSimulationUserCoverage

### [Get-MgBetaReportAuthenticationMethod](Get-MgBetaReportAuthenticationMethod.md)
Container for navigation properties for Azure AD authentication methods resources.

### [Get-MgBetaReportAuthenticationMethodUserRegistrationDetail](Get-MgBetaReportAuthenticationMethodUserRegistrationDetail.md)
Represents the state of a user's authentication methods, including which methods are registered and which features the user is registered and capable of (such as multi-factor authentication, self-service password reset, and passwordless authentication).

### [Get-MgBetaReportAzureAdApplicationSignInSummary](Get-MgBetaReportAzureAdApplicationSignInSummary.md)
Invoke function getAzureADApplicationSignInSummary

### [Get-MgBetaReportBrowserDistributionUserCount](Get-MgBetaReportBrowserDistributionUserCount.md)
Invoke function getBrowserDistributionUserCounts

### [Get-MgBetaReportBrowserUserCount](Get-MgBetaReportBrowserUserCount.md)
Invoke function getBrowserUserCounts

### [Get-MgBetaReportBrowserUserDetail](Get-MgBetaReportBrowserUserDetail.md)
Invoke function getBrowserUserDetail

### [Get-MgBetaReportCredentialUsageSummary](Get-MgBetaReportCredentialUsageSummary.md)
Invoke function getCredentialUsageSummary

### [Get-MgBetaReportCredentialUserRegistrationCount](Get-MgBetaReportCredentialUserRegistrationCount.md)
Report the current state of how many users in your organization are registered for self-service password reset and multi-factor authentication (MFA) capabilities.

### [Get-MgBetaReportCredentialUserRegistrationDetail](Get-MgBetaReportCredentialUserRegistrationDetail.md)
Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.

### [Get-MgBetaReportDailyPrintUsage](Get-MgBetaReportDailyPrintUsage.md)
Get dailyPrintUsage from reports

### [Get-MgBetaReportDailyPrintUsageByPrinter](Get-MgBetaReportDailyPrintUsageByPrinter.md)
Get dailyPrintUsageByPrinter from reports

### [Get-MgBetaReportDailyPrintUsageByUser](Get-MgBetaReportDailyPrintUsageByUser.md)
Get dailyPrintUsageByUser from reports

### [Get-MgBetaReportDailyPrintUsageSummaryByPrinter](Get-MgBetaReportDailyPrintUsageSummaryByPrinter.md)
Get dailyPrintUsageSummariesByPrinter from reports

### [Get-MgBetaReportDailyPrintUsageSummaryByUser](Get-MgBetaReportDailyPrintUsageSummaryByUser.md)
Get dailyPrintUsageSummariesByUser from reports

### [Get-MgBetaReportDeviceConfigurationDeviceActivity](Get-MgBetaReportDeviceConfigurationDeviceActivity.md)
Metadata for the device configuration device activity report

### [Get-MgBetaReportDeviceConfigurationUserActivity](Get-MgBetaReportDeviceConfigurationUserActivity.md)
Metadata for the device configuration user activity report

### [Get-MgBetaReportEmailActivityCount](Get-MgBetaReportEmailActivityCount.md)
Invoke function getEmailActivityCounts

### [Get-MgBetaReportEmailActivityUserCount](Get-MgBetaReportEmailActivityUserCount.md)
Invoke function getEmailActivityUserCounts

### [Get-MgBetaReportEmailActivityUserDetail](Get-MgBetaReportEmailActivityUserDetail.md)
Invoke function getEmailActivityUserDetail

### [Get-MgBetaReportEmailAppUsageAppUserCount](Get-MgBetaReportEmailAppUsageAppUserCount.md)
Invoke function getEmailAppUsageAppsUserCounts

### [Get-MgBetaReportEmailAppUsageUserCount](Get-MgBetaReportEmailAppUsageUserCount.md)
Invoke function getEmailAppUsageUserCounts

### [Get-MgBetaReportEmailAppUsageUserDetail](Get-MgBetaReportEmailAppUsageUserDetail.md)
Invoke function getEmailAppUsageUserDetail

### [Get-MgBetaReportEmailAppUsageVersionUserCount](Get-MgBetaReportEmailAppUsageVersionUserCount.md)
Invoke function getEmailAppUsageVersionsUserCounts

### [Get-MgBetaReportGroupArchivedPrintJob](Get-MgBetaReportGroupArchivedPrintJob.md)
Invoke function getGroupArchivedPrintJobs

### [Get-MgBetaReportM365AppPlatformUserCount](Get-MgBetaReportM365AppPlatformUserCount.md)
Invoke function getM365AppPlatformUserCounts

### [Get-MgBetaReportM365AppUserCount](Get-MgBetaReportM365AppUserCount.md)
Invoke function getM365AppUserCounts

### [Get-MgBetaReportM365AppUserDetail](Get-MgBetaReportM365AppUserDetail.md)
Invoke function getM365AppUserDetail

### [Get-MgBetaReportMailboxUsageDetail](Get-MgBetaReportMailboxUsageDetail.md)
Invoke function getMailboxUsageDetail

### [Get-MgBetaReportMailboxUsageMailboxCount](Get-MgBetaReportMailboxUsageMailboxCount.md)
Invoke function getMailboxUsageMailboxCounts

### [Get-MgBetaReportMailboxUsageQuotaStatusMailboxCount](Get-MgBetaReportMailboxUsageQuotaStatusMailboxCount.md)
Invoke function getMailboxUsageQuotaStatusMailboxCounts

### [Get-MgBetaReportMailboxUsageStorage](Get-MgBetaReportMailboxUsageStorage.md)
Invoke function getMailboxUsageStorage

### [Get-MgBetaReportManagedDeviceEnrollmentAbandonmentDetail](Get-MgBetaReportManagedDeviceEnrollmentAbandonmentDetail.md)
Metadata for Enrollment abandonment details report

### [Get-MgBetaReportManagedDeviceEnrollmentAbandonmentSummary](Get-MgBetaReportManagedDeviceEnrollmentAbandonmentSummary.md)
Metadata for Enrollment abandonment summary report

### [Get-MgBetaReportManagedDeviceEnrollmentFailureDetail](Get-MgBetaReportManagedDeviceEnrollmentFailureDetail.md)
Invoke function managedDeviceEnrollmentFailureDetails

### [Get-MgBetaReportManagedDeviceEnrollmentFailureTrend](Get-MgBetaReportManagedDeviceEnrollmentFailureTrend.md)
Metadata for the enrollment failure trends report

### [Get-MgBetaReportManagedDeviceEnrollmentTopFailures](Get-MgBetaReportManagedDeviceEnrollmentTopFailures.md)
Invoke function managedDeviceEnrollmentTopFailures

### [Get-MgBetaReportMonthlyPrintUsageByPrinter](Get-MgBetaReportMonthlyPrintUsageByPrinter.md)
Get monthlyPrintUsageByPrinter from reports

### [Get-MgBetaReportMonthlyPrintUsageByUser](Get-MgBetaReportMonthlyPrintUsageByUser.md)
Get monthlyPrintUsageByUser from reports

### [Get-MgBetaReportMonthlyPrintUsageSummaryByPrinter](Get-MgBetaReportMonthlyPrintUsageSummaryByPrinter.md)
Get monthlyPrintUsageSummariesByPrinter from reports

### [Get-MgBetaReportMonthlyPrintUsageSummaryByUser](Get-MgBetaReportMonthlyPrintUsageSummaryByUser.md)
Get monthlyPrintUsageSummariesByUser from reports

### [Get-MgBetaReportOffice365ActivationCount](Get-MgBetaReportOffice365ActivationCount.md)
Invoke function getOffice365ActivationCounts

### [Get-MgBetaReportOffice365ActivationUserCount](Get-MgBetaReportOffice365ActivationUserCount.md)
Invoke function getOffice365ActivationsUserCounts

### [Get-MgBetaReportOffice365ActivationUserDetail](Get-MgBetaReportOffice365ActivationUserDetail.md)
Invoke function getOffice365ActivationsUserDetail

### [Get-MgBetaReportOffice365ActiveUserCount](Get-MgBetaReportOffice365ActiveUserCount.md)
Invoke function getOffice365ActiveUserCounts

### [Get-MgBetaReportOffice365ActiveUserDetail](Get-MgBetaReportOffice365ActiveUserDetail.md)
Invoke function getOffice365ActiveUserDetail

### [Get-MgBetaReportOffice365GroupActivityCount](Get-MgBetaReportOffice365GroupActivityCount.md)
Invoke function getOffice365GroupsActivityCounts

### [Get-MgBetaReportOffice365GroupActivityDetail](Get-MgBetaReportOffice365GroupActivityDetail.md)
Invoke function getOffice365GroupsActivityDetail

### [Get-MgBetaReportOffice365GroupActivityFileCount](Get-MgBetaReportOffice365GroupActivityFileCount.md)
Invoke function getOffice365GroupsActivityFileCounts

### [Get-MgBetaReportOffice365GroupActivityGroupCount](Get-MgBetaReportOffice365GroupActivityGroupCount.md)
Invoke function getOffice365GroupsActivityGroupCounts

### [Get-MgBetaReportOffice365GroupActivityStorage](Get-MgBetaReportOffice365GroupActivityStorage.md)
Invoke function getOffice365GroupsActivityStorage

### [Get-MgBetaReportOffice365ServiceUserCount](Get-MgBetaReportOffice365ServiceUserCount.md)
Invoke function getOffice365ServicesUserCounts

### [Get-MgBetaReportOneDriveActivityFileCount](Get-MgBetaReportOneDriveActivityFileCount.md)
Invoke function getOneDriveActivityFileCounts

### [Get-MgBetaReportOneDriveActivityUserCount](Get-MgBetaReportOneDriveActivityUserCount.md)
Invoke function getOneDriveActivityUserCounts

### [Get-MgBetaReportOneDriveActivityUserDetail](Get-MgBetaReportOneDriveActivityUserDetail.md)
Invoke function getOneDriveActivityUserDetail

### [Get-MgBetaReportOneDriveUsageAccountCount](Get-MgBetaReportOneDriveUsageAccountCount.md)
Invoke function getOneDriveUsageAccountCounts

### [Get-MgBetaReportOneDriveUsageAccountDetail](Get-MgBetaReportOneDriveUsageAccountDetail.md)
Invoke function getOneDriveUsageAccountDetail

### [Get-MgBetaReportOneDriveUsageFileCount](Get-MgBetaReportOneDriveUsageFileCount.md)
Invoke function getOneDriveUsageFileCounts

### [Get-MgBetaReportOneDriveUsageStorage](Get-MgBetaReportOneDriveUsageStorage.md)
Invoke function getOneDriveUsageStorage

### [Get-MgBetaReportPrinterArchivedPrintJob](Get-MgBetaReportPrinterArchivedPrintJob.md)
Invoke function getPrinterArchivedPrintJobs

### [Get-MgBetaReportRelyingPartyDetailedSummary](Get-MgBetaReportRelyingPartyDetailedSummary.md)
Invoke function getRelyingPartyDetailedSummary

### [Get-MgBetaReportSecurity](Get-MgBetaReportSecurity.md)
Provides the ability to launch a realistic simulated phishing attack that organizations can learn from.

### [Get-MgBetaReportSecurityAttackSimulationRepeatOffender](Get-MgBetaReportSecurityAttackSimulationRepeatOffender.md)
Invoke function getAttackSimulationRepeatOffenders

### [Get-MgBetaReportSecurityAttackSimulationTrainingUserCoverage](Get-MgBetaReportSecurityAttackSimulationTrainingUserCoverage.md)
Invoke function getAttackSimulationTrainingUserCoverage

### [Get-MgBetaReportSecurityAttackSimulationUserCoverage](Get-MgBetaReportSecurityAttackSimulationUserCoverage.md)
Invoke function getAttackSimulationSimulationUserCoverage

### [Get-MgBetaReportSharePointActivityFileCount](Get-MgBetaReportSharePointActivityFileCount.md)
Invoke function getSharePointActivityFileCounts

### [Get-MgBetaReportSharePointActivityPage](Get-MgBetaReportSharePointActivityPage.md)
Invoke function getSharePointActivityPages

### [Get-MgBetaReportSharePointActivityUserCount](Get-MgBetaReportSharePointActivityUserCount.md)
Invoke function getSharePointActivityUserCounts

### [Get-MgBetaReportSharePointActivityUserDetail](Get-MgBetaReportSharePointActivityUserDetail.md)
Invoke function getSharePointActivityUserDetail

### [Get-MgBetaReportSharePointSiteUsageDetail](Get-MgBetaReportSharePointSiteUsageDetail.md)
Invoke function getSharePointSiteUsageDetail

### [Get-MgBetaReportSharePointSiteUsageFileCount](Get-MgBetaReportSharePointSiteUsageFileCount.md)
Invoke function getSharePointSiteUsageFileCounts

### [Get-MgBetaReportSharePointSiteUsagePage](Get-MgBetaReportSharePointSiteUsagePage.md)
Invoke function getSharePointSiteUsagePages

### [Get-MgBetaReportSharePointSiteUsageSiteCount](Get-MgBetaReportSharePointSiteUsageSiteCount.md)
Invoke function getSharePointSiteUsageSiteCounts

### [Get-MgBetaReportSharePointSiteUsageStorage](Get-MgBetaReportSharePointSiteUsageStorage.md)
Invoke function getSharePointSiteUsageStorage

### [Get-MgBetaReportSkypeForBusinessActivityCount](Get-MgBetaReportSkypeForBusinessActivityCount.md)
Invoke function getSkypeForBusinessActivityCounts

### [Get-MgBetaReportSkypeForBusinessActivityUserCount](Get-MgBetaReportSkypeForBusinessActivityUserCount.md)
Invoke function getSkypeForBusinessActivityUserCounts

### [Get-MgBetaReportSkypeForBusinessActivityUserDetail](Get-MgBetaReportSkypeForBusinessActivityUserDetail.md)
Invoke function getSkypeForBusinessActivityUserDetail

### [Get-MgBetaReportSkypeForBusinessDeviceUsageDistributionUserCount](Get-MgBetaReportSkypeForBusinessDeviceUsageDistributionUserCount.md)
Invoke function getSkypeForBusinessDeviceUsageDistributionUserCounts

### [Get-MgBetaReportSkypeForBusinessDeviceUsageUserCount](Get-MgBetaReportSkypeForBusinessDeviceUsageUserCount.md)
Invoke function getSkypeForBusinessDeviceUsageUserCounts

### [Get-MgBetaReportSkypeForBusinessDeviceUsageUserDetail](Get-MgBetaReportSkypeForBusinessDeviceUsageUserDetail.md)
Invoke function getSkypeForBusinessDeviceUsageUserDetail

### [Get-MgBetaReportSkypeForBusinessOrganizerActivityCount](Get-MgBetaReportSkypeForBusinessOrganizerActivityCount.md)
Invoke function getSkypeForBusinessOrganizerActivityCounts

### [Get-MgBetaReportSkypeForBusinessOrganizerActivityMinuteCount](Get-MgBetaReportSkypeForBusinessOrganizerActivityMinuteCount.md)
Invoke function getSkypeForBusinessOrganizerActivityMinuteCounts

### [Get-MgBetaReportSkypeForBusinessOrganizerActivityUserCount](Get-MgBetaReportSkypeForBusinessOrganizerActivityUserCount.md)
Invoke function getSkypeForBusinessOrganizerActivityUserCounts

### [Get-MgBetaReportSkypeForBusinessParticipantActivityCount](Get-MgBetaReportSkypeForBusinessParticipantActivityCount.md)
Invoke function getSkypeForBusinessParticipantActivityCounts

### [Get-MgBetaReportSkypeForBusinessParticipantActivityMinuteCount](Get-MgBetaReportSkypeForBusinessParticipantActivityMinuteCount.md)
Invoke function getSkypeForBusinessParticipantActivityMinuteCounts

### [Get-MgBetaReportSkypeForBusinessParticipantActivityUserCount](Get-MgBetaReportSkypeForBusinessParticipantActivityUserCount.md)
Invoke function getSkypeForBusinessParticipantActivityUserCounts

### [Get-MgBetaReportSkypeForBusinessPeerToPeerActivityCount](Get-MgBetaReportSkypeForBusinessPeerToPeerActivityCount.md)
Invoke function getSkypeForBusinessPeerToPeerActivityCounts

### [Get-MgBetaReportSkypeForBusinessPeerToPeerActivityMinuteCount](Get-MgBetaReportSkypeForBusinessPeerToPeerActivityMinuteCount.md)
Invoke function getSkypeForBusinessPeerToPeerActivityMinuteCounts

### [Get-MgBetaReportSkypeForBusinessPeerToPeerActivityUserCount](Get-MgBetaReportSkypeForBusinessPeerToPeerActivityUserCount.md)
Invoke function getSkypeForBusinessPeerToPeerActivityUserCounts

### [Get-MgBetaReportTeamActivityCount](Get-MgBetaReportTeamActivityCount.md)
Invoke function getTeamsTeamActivityCounts

### [Get-MgBetaReportTeamActivityDetail](Get-MgBetaReportTeamActivityDetail.md)
Invoke function getTeamsTeamActivityDetail

### [Get-MgBetaReportTeamActivityDistributionCount](Get-MgBetaReportTeamActivityDistributionCount.md)
Invoke function getTeamsTeamActivityDistributionCounts

### [Get-MgBetaReportTeamDeviceUsageDistributionTotalUserCount](Get-MgBetaReportTeamDeviceUsageDistributionTotalUserCount.md)
Invoke function getTeamsDeviceUsageDistributionTotalUserCounts

### [Get-MgBetaReportTeamDeviceUsageDistributionUserCount](Get-MgBetaReportTeamDeviceUsageDistributionUserCount.md)
Invoke function getTeamsDeviceUsageDistributionUserCounts

### [Get-MgBetaReportTeamDeviceUsageTotalUserCount](Get-MgBetaReportTeamDeviceUsageTotalUserCount.md)
Invoke function getTeamsDeviceUsageTotalUserCounts

### [Get-MgBetaReportTeamDeviceUsageUserCount](Get-MgBetaReportTeamDeviceUsageUserCount.md)
Invoke function getTeamsDeviceUsageUserCounts

### [Get-MgBetaReportTeamDeviceUsageUserDetail](Get-MgBetaReportTeamDeviceUsageUserDetail.md)
Invoke function getTeamsDeviceUsageUserDetail

### [Get-MgBetaReportTeamUserActivityCount](Get-MgBetaReportTeamUserActivityCount.md)
Invoke function getTeamsUserActivityCounts

### [Get-MgBetaReportTeamUserActivityDistributionTotalUserCount](Get-MgBetaReportTeamUserActivityDistributionTotalUserCount.md)
Invoke function getTeamsUserActivityDistributionTotalUserCounts

### [Get-MgBetaReportTeamUserActivityDistributionUserCount](Get-MgBetaReportTeamUserActivityDistributionUserCount.md)
Invoke function getTeamsUserActivityDistributionUserCounts

### [Get-MgBetaReportTeamUserActivityTotalCount](Get-MgBetaReportTeamUserActivityTotalCount.md)
Invoke function getTeamsUserActivityTotalCounts

### [Get-MgBetaReportTeamUserActivityTotalDistributionCount](Get-MgBetaReportTeamUserActivityTotalDistributionCount.md)
Invoke function getTeamsUserActivityTotalDistributionCounts

### [Get-MgBetaReportTeamUserActivityTotalUserCount](Get-MgBetaReportTeamUserActivityTotalUserCount.md)
Invoke function getTeamsUserActivityTotalUserCounts

### [Get-MgBetaReportTeamUserActivityUserCount](Get-MgBetaReportTeamUserActivityUserCount.md)
Invoke function getTeamsUserActivityUserCounts

### [Get-MgBetaReportTeamUserActivityUserDetail](Get-MgBetaReportTeamUserActivityUserDetail.md)
Invoke function getTeamsUserActivityUserDetail

### [Get-MgBetaReportUserArchivedPrintJob](Get-MgBetaReportUserArchivedPrintJob.md)
Invoke function getUserArchivedPrintJobs

### [Get-MgBetaReportUserCredentialUsageDetail](Get-MgBetaReportUserCredentialUsageDetail.md)
Represents the self-service password reset (SSPR) usage for a given tenant.

### [Get-MgBetaReportYammerActivityCount](Get-MgBetaReportYammerActivityCount.md)
Invoke function getYammerActivityCounts

### [Get-MgBetaReportYammerActivityUserCount](Get-MgBetaReportYammerActivityUserCount.md)
Invoke function getYammerActivityUserCounts

### [Get-MgBetaReportYammerActivityUserDetail](Get-MgBetaReportYammerActivityUserDetail.md)
Invoke function getYammerActivityUserDetail

### [Get-MgBetaReportYammerDeviceUsageDistributionUserCount](Get-MgBetaReportYammerDeviceUsageDistributionUserCount.md)
Invoke function getYammerDeviceUsageDistributionUserCounts

### [Get-MgBetaReportYammerDeviceUsageUserCount](Get-MgBetaReportYammerDeviceUsageUserCount.md)
Invoke function getYammerDeviceUsageUserCounts

### [Get-MgBetaReportYammerDeviceUsageUserDetail](Get-MgBetaReportYammerDeviceUsageUserDetail.md)
Invoke function getYammerDeviceUsageUserDetail

### [Get-MgBetaReportYammerGroupActivityCount](Get-MgBetaReportYammerGroupActivityCount.md)
Invoke function getYammerGroupsActivityCounts

### [Get-MgBetaReportYammerGroupActivityDetail](Get-MgBetaReportYammerGroupActivityDetail.md)
Invoke function getYammerGroupsActivityDetail

### [Get-MgBetaReportYammerGroupActivityGroupCount](Get-MgBetaReportYammerGroupActivityGroupCount.md)
Invoke function getYammerGroupsActivityGroupCounts

### [Invoke-MgBetaGraphReportAuthenticationMethod](Invoke-MgBetaGraphReportAuthenticationMethod.md)
Invoke function usersRegisteredByFeature

### [New-MgBetaReportAuthenticationMethodUserRegistrationDetail](New-MgBetaReportAuthenticationMethodUserRegistrationDetail.md)
Create new navigation property to userRegistrationDetails for reports

### [Remove-MgBetaDeviceManagementReport](Remove-MgBetaDeviceManagementReport.md)
Delete navigation property reports for deviceManagement

### [Remove-MgBetaReportAuthenticationMethodUserRegistrationDetail](Remove-MgBetaReportAuthenticationMethodUserRegistrationDetail.md)
Delete navigation property userRegistrationDetails for reports

### [Update-MgBetaDeviceManagementReport](Update-MgBetaDeviceManagementReport.md)
Update the navigation property reports in deviceManagement

### [Update-MgBetaReportAuthenticationMethodUserRegistrationDetail](Update-MgBetaReportAuthenticationMethodUserRegistrationDetail.md)
Update the navigation property userRegistrationDetails in reports

