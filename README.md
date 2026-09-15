<h1 align="center">
    <img alt="Microsoft Graph PowerShell" src="./docs/images/graph_color256.png" height="78" />
  <br>Microsoft Graph PowerShell<br>
</h1>

<h4 align="center">
  Consume <a href="https://graph.microsoft.com">Microsoft Graph</a> resources directly from your PowerShell scripts
</h4>

<h3 align="center"><a href="https://learn.microsoft.com/graph/overview">API Documentation</a> | <a href="https://learn.microsoft.com/powershell/microsoftgraph/overview">SDK Documentation</a></h3>

<p align="center">
The Microsoft Graph PowerShell SDK is made up of a set of modules that enable you to interact with the Microsoft Graph API using PowerShell commands. The modules consist of commands that act as wrappers for the API, allowing you to access all the features and functionality of the API through PowerShell.
</p>

<p align="center">
  <a href="#modules">Modules</a> |
  <a href="#getting-started">Getting Started</a> |
  <a href="#api-version">API Version</a> |
  <a href="#notes">Notes</a> |
  <a href="#troubleshooting">Troubleshooting</a> |
  <a href="#known-issues">Known Issues</a> |
  <a href="#feedback">Feedback</a> |
  <a href="#license">License</a>
</p>

## Modules

This repository publishes complete bundle modules, the authentication module, and scenario-specific modules for the Microsoft Graph v1.0 and beta endpoints. For faster installation and import, prefer the scenario-specific modules you need instead of the complete `Microsoft.Graph` and `Microsoft.Graph.Beta` bundle modules. The bundle modules install all their respective scenario-specific modules as dependencies.

| Module | Latest | Preview |
| ------ | ------ | ------- |
| [`Microsoft.Graph`](https://www.powershellgallery.com/packages/Microsoft.Graph/) | [![Microsoft.Graph](https://img.shields.io/powershellgallery/v/Microsoft.Graph?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph/) | - |
| [`Microsoft.Graph.Beta`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta/) | [![Microsoft.Graph.Beta](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta/) | - |
| [`Microsoft.Graph.Authentication`](https://www.powershellgallery.com/packages/Microsoft.Graph.Authentication/) | [![Microsoft.Graph.Authentication](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Authentication?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Authentication/) | - |
| [`Microsoft.Graph.Applications`](https://www.powershellgallery.com/packages/Microsoft.Graph.Applications/) | [![Microsoft.Graph.Applications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Applications?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Applications/) | - |
| [`Microsoft.Graph.Bookings`](https://www.powershellgallery.com/packages/Microsoft.Graph.Bookings/) | [![Microsoft.Graph.Bookings](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Bookings?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Bookings/) | - |
| [`Microsoft.Graph.Calendar`](https://www.powershellgallery.com/packages/Microsoft.Graph.Calendar/) | [![Microsoft.Graph.Calendar](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Calendar?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Calendar/) | - |
| [`Microsoft.Graph.ChangeNotifications`](https://www.powershellgallery.com/packages/Microsoft.Graph.ChangeNotifications/) | [![Microsoft.Graph.ChangeNotifications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.ChangeNotifications?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.ChangeNotifications/) | - |
| [`Microsoft.Graph.CloudCommunications`](https://www.powershellgallery.com/packages/Microsoft.Graph.CloudCommunications/) | [![Microsoft.Graph.CloudCommunications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.CloudCommunications?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.CloudCommunications/) | - |
| [`Microsoft.Graph.Compliance`](https://www.powershellgallery.com/packages/Microsoft.Graph.Compliance/) | [![Microsoft.Graph.Compliance](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Compliance?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Compliance/) | - |
| [`Microsoft.Graph.CrossDeviceExperiences`](https://www.powershellgallery.com/packages/Microsoft.Graph.CrossDeviceExperiences/) | [![Microsoft.Graph.CrossDeviceExperiences](https://img.shields.io/powershellgallery/v/Microsoft.Graph.CrossDeviceExperiences?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.CrossDeviceExperiences/) | - |
| [`Microsoft.Graph.DeviceManagement`](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement/) | [![Microsoft.Graph.DeviceManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement/) | - |
| [`Microsoft.Graph.DeviceManagement.Administration`](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Administration/) | [![Microsoft.Graph.DeviceManagement.Administration](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement.Administration?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Administration/) | - |
| [`Microsoft.Graph.DeviceManagement.Enrollment`](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Enrollment/) | [![Microsoft.Graph.DeviceManagement.Enrollment](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement.Enrollment?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Enrollment/) | - |
| [`Microsoft.Graph.DeviceManagement.Functions`](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Functions/) | [![Microsoft.Graph.DeviceManagement.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement.Functions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Functions/) | - |
| [`Microsoft.Graph.Devices.CloudPrint`](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.CloudPrint/) | [![Microsoft.Graph.Devices.CloudPrint](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Devices.CloudPrint?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.CloudPrint/) | - |
| [`Microsoft.Graph.Devices.CorporateManagement`](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.CorporateManagement/) | [![Microsoft.Graph.Devices.CorporateManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Devices.CorporateManagement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.CorporateManagement/) | - |
| [`Microsoft.Graph.Devices.ServiceAnnouncement`](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.ServiceAnnouncement/) | [![Microsoft.Graph.Devices.ServiceAnnouncement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Devices.ServiceAnnouncement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.ServiceAnnouncement/) | - |
| [`Microsoft.Graph.DirectoryObjects`](https://www.powershellgallery.com/packages/Microsoft.Graph.DirectoryObjects/) | [![Microsoft.Graph.DirectoryObjects](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DirectoryObjects?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.DirectoryObjects/) | - |
| [`Microsoft.Graph.Education`](https://www.powershellgallery.com/packages/Microsoft.Graph.Education/) | [![Microsoft.Graph.Education](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Education?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Education/) | - |
| [`Microsoft.Graph.Files`](https://www.powershellgallery.com/packages/Microsoft.Graph.Files/) | [![Microsoft.Graph.Files](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Files?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Files/) | - |
| [`Microsoft.Graph.Groups`](https://www.powershellgallery.com/packages/Microsoft.Graph.Groups/) | [![Microsoft.Graph.Groups](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Groups?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Groups/) | - |
| [`Microsoft.Graph.Identity.DirectoryManagement`](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.DirectoryManagement/) | [![Microsoft.Graph.Identity.DirectoryManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.DirectoryManagement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.DirectoryManagement/) | - |
| [`Microsoft.Graph.Identity.Governance`](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.Governance/) | [![Microsoft.Graph.Identity.Governance](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.Governance?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.Governance/) | - |
| [`Microsoft.Graph.Identity.SignIns`](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.SignIns/) | [![Microsoft.Graph.Identity.SignIns](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.SignIns?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.SignIns/) | - |
| [`Microsoft.Graph.Mail`](https://www.powershellgallery.com/packages/Microsoft.Graph.Mail/) | [![Microsoft.Graph.Mail](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Mail?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Mail/) | - |
| [`Microsoft.Graph.Notes`](https://www.powershellgallery.com/packages/Microsoft.Graph.Notes/) | [![Microsoft.Graph.Notes](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Notes?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Notes/) | - |
| [`Microsoft.Graph.People`](https://www.powershellgallery.com/packages/Microsoft.Graph.People/) | [![Microsoft.Graph.People](https://img.shields.io/powershellgallery/v/Microsoft.Graph.People?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.People/) | - |
| [`Microsoft.Graph.PersonalContacts`](https://www.powershellgallery.com/packages/Microsoft.Graph.PersonalContacts/) | [![Microsoft.Graph.PersonalContacts](https://img.shields.io/powershellgallery/v/Microsoft.Graph.PersonalContacts?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.PersonalContacts/) | - |
| [`Microsoft.Graph.Planner`](https://www.powershellgallery.com/packages/Microsoft.Graph.Planner/) | [![Microsoft.Graph.Planner](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Planner?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Planner/) | - |
| [`Microsoft.Graph.Reports`](https://www.powershellgallery.com/packages/Microsoft.Graph.Reports/) | [![Microsoft.Graph.Reports](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Reports?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Reports/) | - |
| [`Microsoft.Graph.SchemaExtensions`](https://www.powershellgallery.com/packages/Microsoft.Graph.SchemaExtensions/) | [![Microsoft.Graph.SchemaExtensions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.SchemaExtensions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.SchemaExtensions/) | - |
| [`Microsoft.Graph.Search`](https://www.powershellgallery.com/packages/Microsoft.Graph.Search/) | [![Microsoft.Graph.Search](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Search?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Search/) | - |
| [`Microsoft.Graph.Security`](https://www.powershellgallery.com/packages/Microsoft.Graph.Security/) | [![Microsoft.Graph.Security](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Security?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Security/) | - |
| [`Microsoft.Graph.Sites`](https://www.powershellgallery.com/packages/Microsoft.Graph.Sites/) | [![Microsoft.Graph.Sites](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Sites?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Sites/) | - |
| [`Microsoft.Graph.Teams`](https://www.powershellgallery.com/packages/Microsoft.Graph.Teams/) | [![Microsoft.Graph.Teams](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Teams?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Teams/) | - |
| [`Microsoft.Graph.Users`](https://www.powershellgallery.com/packages/Microsoft.Graph.Users/) | [![Microsoft.Graph.Users](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Users?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Users/) | - |
| [`Microsoft.Graph.Users.Actions`](https://www.powershellgallery.com/packages/Microsoft.Graph.Users.Actions/) | [![Microsoft.Graph.Users.Actions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Users.Actions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Users.Actions/) | - |
| [`Microsoft.Graph.Users.Functions`](https://www.powershellgallery.com/packages/Microsoft.Graph.Users.Functions/) | [![Microsoft.Graph.Users.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Users.Functions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Users.Functions/) | - |
| [`Microsoft.Graph.Beta.Applications`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Applications/) | [![Microsoft.Graph.Beta.Applications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Applications?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Applications/) | - |
| [`Microsoft.Graph.Beta.Bookings`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Bookings/) | [![Microsoft.Graph.Beta.Bookings](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Bookings?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Bookings/) | - |
| [`Microsoft.Graph.Beta.Calendar`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Calendar/) | [![Microsoft.Graph.Beta.Calendar](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Calendar?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Calendar/) | - |
| [`Microsoft.Graph.Beta.ChangeNotifications`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.ChangeNotifications/) | [![Microsoft.Graph.Beta.ChangeNotifications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.ChangeNotifications?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.ChangeNotifications/) | - |
| [`Microsoft.Graph.Beta.CloudCommunications`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.CloudCommunications/) | [![Microsoft.Graph.Beta.CloudCommunications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.CloudCommunications?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.CloudCommunications/) | - |
| [`Microsoft.Graph.Beta.Compliance`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Compliance/) | [![Microsoft.Graph.Beta.Compliance](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Compliance?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Compliance/) | - |
| [`Microsoft.Graph.Beta.CrossDeviceExperiences`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.CrossDeviceExperiences/) | [![Microsoft.Graph.Beta.CrossDeviceExperiences](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.CrossDeviceExperiences?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.CrossDeviceExperiences/) | - |
| [`Microsoft.Graph.Beta.DeviceManagement`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement/) | [![Microsoft.Graph.Beta.DeviceManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.DeviceManagement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement/) | - |
| [`Microsoft.Graph.Beta.DeviceManagement.Administration`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement.Administration/) | [![Microsoft.Graph.Beta.DeviceManagement.Administration](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.DeviceManagement.Administration?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement.Administration/) | - |
| [`Microsoft.Graph.Beta.DeviceManagement.Enrollment`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement.Enrollment/) | [![Microsoft.Graph.Beta.DeviceManagement.Enrollment](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.DeviceManagement.Enrollment?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement.Enrollment/) | - |
| [`Microsoft.Graph.Beta.DeviceManagement.Functions`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement.Functions/) | [![Microsoft.Graph.Beta.DeviceManagement.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.DeviceManagement.Functions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DeviceManagement.Functions/) | - |
| [`Microsoft.Graph.Beta.Devices.CloudPrint`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Devices.CloudPrint/) | [![Microsoft.Graph.Beta.Devices.CloudPrint](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Devices.CloudPrint?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Devices.CloudPrint/) | - |
| [`Microsoft.Graph.Beta.Devices.CorporateManagement`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Devices.CorporateManagement/) | [![Microsoft.Graph.Beta.Devices.CorporateManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Devices.CorporateManagement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Devices.CorporateManagement/) | - |
| [`Microsoft.Graph.Beta.Devices.ServiceAnnouncement`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Devices.ServiceAnnouncement/) | [![Microsoft.Graph.Beta.Devices.ServiceAnnouncement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Devices.ServiceAnnouncement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Devices.ServiceAnnouncement/) | - |
| [`Microsoft.Graph.Beta.DirectoryObjects`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DirectoryObjects/) | [![Microsoft.Graph.Beta.DirectoryObjects](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.DirectoryObjects?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.DirectoryObjects/) | - |
| [`Microsoft.Graph.Beta.Education`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Education/) | [![Microsoft.Graph.Beta.Education](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Education?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Education/) | - |
| [`Microsoft.Graph.Beta.Files`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Files/) | [![Microsoft.Graph.Beta.Files](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Files?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Files/) | - |
| [`Microsoft.Graph.Beta.Financials`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Financials/) | [![Microsoft.Graph.Beta.Financials](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Financials?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Financials/) | - |
| [`Microsoft.Graph.Beta.Groups`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Groups/) | [![Microsoft.Graph.Beta.Groups](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Groups?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Groups/) | - |
| [`Microsoft.Graph.Beta.Identity.DirectoryManagement`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Identity.DirectoryManagement/) | [![Microsoft.Graph.Beta.Identity.DirectoryManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Identity.DirectoryManagement?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Identity.DirectoryManagement/) | - |
| [`Microsoft.Graph.Beta.Identity.Governance`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Identity.Governance/) | [![Microsoft.Graph.Beta.Identity.Governance](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Identity.Governance?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Identity.Governance/) | - |
| [`Microsoft.Graph.Beta.Identity.SignIns`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Identity.SignIns/) | [![Microsoft.Graph.Beta.Identity.SignIns](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Identity.SignIns?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Identity.SignIns/) | - |
| [`Microsoft.Graph.Beta.Mail`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Mail/) | [![Microsoft.Graph.Beta.Mail](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Mail?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Mail/) | - |
| [`Microsoft.Graph.Beta.ManagedTenants`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.ManagedTenants/) | [![Microsoft.Graph.Beta.ManagedTenants](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.ManagedTenants?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.ManagedTenants/) | - |
| [`Microsoft.Graph.Beta.Migrations`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Migrations/) | [![Microsoft.Graph.Beta.Migrations](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Migrations?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Migrations/) | - |
| [`Microsoft.Graph.Beta.Notes`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Notes/) | [![Microsoft.Graph.Beta.Notes](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Notes?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Notes/) | - |
| [`Microsoft.Graph.Beta.People`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.People/) | [![Microsoft.Graph.Beta.People](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.People?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.People/) | - |
| [`Microsoft.Graph.Beta.PersonalContacts`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.PersonalContacts/) | [![Microsoft.Graph.Beta.PersonalContacts](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.PersonalContacts?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.PersonalContacts/) | - |
| [`Microsoft.Graph.Beta.Planner`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Planner/) | [![Microsoft.Graph.Beta.Planner](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Planner?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Planner/) | - |
| [`Microsoft.Graph.Beta.Reports`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Reports/) | [![Microsoft.Graph.Beta.Reports](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Reports?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Reports/) | - |
| [`Microsoft.Graph.Beta.SchemaExtensions`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.SchemaExtensions/) | [![Microsoft.Graph.Beta.SchemaExtensions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.SchemaExtensions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.SchemaExtensions/) | - |
| [`Microsoft.Graph.Beta.Search`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Search/) | [![Microsoft.Graph.Beta.Search](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Search?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Search/) | - |
| [`Microsoft.Graph.Beta.Security`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Security/) | [![Microsoft.Graph.Beta.Security](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Security?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Security/) | - |
| [`Microsoft.Graph.Beta.Sites`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Sites/) | [![Microsoft.Graph.Beta.Sites](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Sites?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Sites/) | - |
| [`Microsoft.Graph.Beta.Teams`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Teams/) | [![Microsoft.Graph.Beta.Teams](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Teams?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Teams/) | - |
| [`Microsoft.Graph.Beta.Users`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users/) | [![Microsoft.Graph.Beta.Users](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Users?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users/) | - |
| [`Microsoft.Graph.Beta.Users.Actions`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users.Actions/) | [![Microsoft.Graph.Beta.Users.Actions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Users.Actions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users.Actions/) | - |
| [`Microsoft.Graph.Beta.Users.Functions`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users.Functions/) | [![Microsoft.Graph.Beta.Users.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Users.Functions?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users.Functions/) | - |
| [`Microsoft.Graph.Beta.WindowsUpdates`](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.WindowsUpdates/) | [![Microsoft.Graph.Beta.WindowsUpdates](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.WindowsUpdates?style=flat-square)](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.WindowsUpdates/) | - |

## Getting Started

### 1. Installation

Microsoft Graph PowerShell module is published on [PowerShell Gallery](https://www.powershellgallery.com/packages/Microsoft.Graph). Installing is as simple as:

```powershell
Install-Module Microsoft.Graph
```

> Run `Install-Module` with `-AllowClobber` and `-Force` parameters if you run into command name conflicts when upgrading to older versions of the module. This may be the case when upgrading from v1.x to v2.x:
>
> ```powershell
> Install-Module Microsoft.Graph -AllowClobber -Force
> ```

See [Install the Microsoft Graph PowerShell Module](https://learn.microsoft.com/powershell/microsoftgraph/installation) guide for detailed installation instructions.

### 2. Authentication

The module supports two main types of authentication:

#### Delegated access

Get access to Microsoft Graph resources on behalf of a user.

```powershell
# Using interactive authentication.
Connect-MgGraph -Scopes "User.ReadBasic.All", "Application.ReadWrite.All"
```

#### App-only access (client credentials grant flow)

Get access to Microsoft Graph resources using the identity on an app and not on behalf of a user.

```powershell
# Using -CertificateThumbprint
Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateThumbprint "YOUR_CERT_THUMBPRINT"
```

See [Authentication](./docs/authentication.md) for more information on the usage of `Connect-MgGraph`.

### 3. List users in your tenant

```powershell
Get-MgUser -Top 10 -Property Id, DisplayName, BusinessPhones | Format-Table Id, DisplayName, BusinessPhones
```

### 4. Filter a user in your tenant

```powershell
$User = Get-MgUser -Filter "displayName eq 'Megan Bowen'"
```

### 5. Create a new app registration

```powershell
New-MgApplication -DisplayName "ScriptedGraphPSApp" `
                  -SignInAudience "AzureADMyOrg" `
                  -Web @{ RedirectUris = "https://localhost"}
```

### 6. Sign out of the current logged-in context i.e. app only or delegated access

```powershell
Disconnect-MgGraph
```

## API Version

Install `Microsoft.Graph.Beta` module to commands that call Microsoft Graph Beta API endpoint.

```powershell
Install-Module Microsoft.Graph.Beta
# Consume Microsoft Graph beta resources.
Connect-MgGraph
$Users = Get-MgBetaUser
```

## Notes

### Update Schedule

The Microsoft Graph PowerShell SDK is scheduled to be updated during the fourth week of each month

### Upgrading to v2

The following breaking changes have been introduced between `v1.x` and `v2.x`:

- Dropped profile support.
- Dropped support for `-ForceRefresh` on `Connect-MgGraph`.
- Renamed `beta` command names from `<Verb>-Mg<Noun>` to `<Verb>-MgBeta<Noun>`.
- Renamed `DeviceManagement.Enrolment` module to `DeviceManagement.Enrollment`.
- Moved directory role and entitlement management commands from `DeviceManagement.Enrollment` to `Identity.Governance` module.
- Changed beta namespace from `Microsoft.Graph.PowerShell.Models.<Entity>` to `Microsoft.Graph.Beta.PowerShell.Models.<Entity>`.
- Changed `-AccessToken` type on `Connect-MgGraph` from `String` to `SecureString`.

See the [v2 upgrade guide](./docs/upgrade-to-v2.md) for more details.

## Troubleshooting

### Permission Related Errors

When working with various operations in the Graph, you may encounter an error such as "Insufficient privileges to complete the operation." For example, this particular error can occur when using the `New-MgApplication` command if the appropriate permissions are not granted.

If permission-related errors occur and the signed-in user/app has been granted the appropriate permissions to perform the operation, you can explicitly fetch a new access token by running `Disconnect-MgGraph`, then `Connect-MgGraph`. This will trigger a refresh of the access token in your cache. Microsoft Authentication Library (MSAL) will only refresh access tokens in your cache if they have expired (usually an hour).

See [Microsoft Graph API Permissions Reference](https://learn.microsoft.com/graph/permissions-reference) for more details.

### Common Errors

See our [troubleshooting guide](https://learn.microsoft.com/powershell/microsoftgraph/troubleshooting) for a detailed view of how to troubleshoot common errors when using Microsoft Graph.

## Known Issues

- Using the `-Property {PropertyName}` parameter will not select the property as the output of the command. All commands return CLR objects, and customers should pipe the command outputs to `Format-Table` or `Select-Object` to return individual properties.

- Customers upgrading from previous versions of the SDK may encounter auth prompts on every command call. If this happens, one can use the following steps to reset their token cache:
  - Use `Disconnect-MgGraph` to sign out of the current session.
  - Run `Remove-Item "$env:USERPROFILE\.mg" -Recurse -Force` to delete your token cache.
  - Run `Connect-MgGraph` to reconstruct a clean token cache.

## Feedback

If you find any bugs when using the Microsoft Graph PowerShell modules, please file an issue on our GitHub issues page.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## License

Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT [license](LICENSE.txt).
