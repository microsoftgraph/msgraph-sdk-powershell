---
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
Module Guid: df393c21-a051-4e93-a9d5-267e3037cc69
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.devices.cloudprint
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Devices.CloudPrint Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Devices.CloudPrint Cmdlets
### [Get-MgBetaPrint](Get-MgBetaPrint.md)
Get print

### [Get-MgBetaPrintConnector](Get-MgBetaPrintConnector.md)
The list of available print connectors.

### [Get-MgBetaPrintOperation](Get-MgBetaPrintOperation.md)
Get operations from print

### [Get-MgBetaPrintPrinter](Get-MgBetaPrintPrinter.md)
The list of printers registered in the tenant.

### [Get-MgBetaPrintPrinterCapability](Get-MgBetaPrintPrinterCapability.md)
Invoke function getCapabilities

### [Get-MgBetaPrintPrinterConnector](Get-MgBetaPrintPrinterConnector.md)
The connectors that are associated with the printer.

### [Get-MgBetaPrintPrinterShare](Get-MgBetaPrintPrinterShare.md)
Get share from print

### [Get-MgBetaPrintPrinterShareAllowedGroup](Get-MgBetaPrintPrinterShareAllowedGroup.md)
Retrieve a list of groups that have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintPrinterShareAllowedGroupByRef](Get-MgBetaPrintPrinterShareAllowedGroupByRef.md)
Retrieve a list of groups that have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintPrinterShareAllowedUser](Get-MgBetaPrintPrinterShareAllowedUser.md)
Retrieve a list of users who have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintPrinterShareAllowedUserByRef](Get-MgBetaPrintPrinterShareAllowedUserByRef.md)
Retrieve a list of users who have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintPrinterSharePrinter](Get-MgBetaPrintPrinterSharePrinter.md)
The printer that this printer share is related to.

### [Get-MgBetaPrintPrinterTaskTrigger](Get-MgBetaPrintPrinterTaskTrigger.md)
A list of task triggers that are associated with the printer.

### [Get-MgBetaPrintPrinterTaskTriggerDefinition](Get-MgBetaPrintPrinterTaskTriggerDefinition.md)
An abstract definition that will be used to create a printTask when triggered by a print event.
Read-only.

### [Get-MgBetaPrintService](Get-MgBetaPrintService.md)
The list of available Universal Print service endpoints.

### [Get-MgBetaPrintServiceEndpoint](Get-MgBetaPrintServiceEndpoint.md)
Endpoints that can be used to access the service.
Read-only.
Nullable.

### [Get-MgBetaPrintShare](Get-MgBetaPrintShare.md)
The list of printer shares registered in the tenant.

### [Get-MgBetaPrintShareAllowedGroup](Get-MgBetaPrintShareAllowedGroup.md)
Retrieve a list of groups that have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintShareAllowedGroupByRef](Get-MgBetaPrintShareAllowedGroupByRef.md)
Retrieve a list of groups that have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintShareAllowedUser](Get-MgBetaPrintShareAllowedUser.md)
Retrieve a list of users who have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintShareAllowedUserByRef](Get-MgBetaPrintShareAllowedUserByRef.md)
Retrieve a list of users who have been granted access to submit print jobs to the associated printerShare.

### [Get-MgBetaPrintSharePrinter](Get-MgBetaPrintSharePrinter.md)
The printer that this printer share is related to.

### [Get-MgBetaPrintTaskDefinition](Get-MgBetaPrintTaskDefinition.md)
Get taskDefinitions from print

### [Get-MgBetaPrintTaskDefinitionTask](Get-MgBetaPrintTaskDefinitionTask.md)
A list of tasks that have been created based on this definition.
The list includes currently running tasks and recently completed tasks.
Read-only.

### [Get-MgBetaPrintTaskDefinitionTaskTrigger](Get-MgBetaPrintTaskDefinitionTaskTrigger.md)
The printTaskTrigger that triggered this task's execution.
Read-only.

### [New-MgBetaPrintConnector](New-MgBetaPrintConnector.md)
Create new navigation property to connectors for print

### [New-MgBetaPrintOperation](New-MgBetaPrintOperation.md)
Create new navigation property to operations for print

### [New-MgBetaPrintPrinterShare](New-MgBetaPrintPrinterShare.md)
Create new navigation property to printerShares for print

### [New-MgBetaPrintPrinterShareAllowedGroupByRef](New-MgBetaPrintPrinterShareAllowedGroupByRef.md)
Create new navigation property ref to allowedGroups for print

### [New-MgBetaPrintPrinterShareAllowedUserByRef](New-MgBetaPrintPrinterShareAllowedUserByRef.md)
Create new navigation property ref to allowedUsers for print

### [New-MgBetaPrintPrinterTaskTrigger](New-MgBetaPrintPrinterTaskTrigger.md)
Create a new task trigger on the specified printer.
Currently, only **one** task trigger can be specified per printer, but this limit might be removed in the future.

### [New-MgBetaPrintService](New-MgBetaPrintService.md)
Create new navigation property to services for print

### [New-MgBetaPrintServiceEndpoint](New-MgBetaPrintServiceEndpoint.md)
Create new navigation property to endpoints for print

### [New-MgBetaPrintShare](New-MgBetaPrintShare.md)
Create a new **printerShare** for the specified printer.

### [New-MgBetaPrintShareAllowedGroupByRef](New-MgBetaPrintShareAllowedGroupByRef.md)
Create new navigation property ref to allowedGroups for print

### [New-MgBetaPrintShareAllowedUserByRef](New-MgBetaPrintShareAllowedUserByRef.md)
Create new navigation property ref to allowedUsers for print

### [New-MgBetaPrintTaskDefinition](New-MgBetaPrintTaskDefinition.md)
Create a new task definition.
For details about how to use this API to add pull printing support to Universal Print, see Extending Universal Print to support pull printing.

### [New-MgBetaPrintTaskDefinitionTask](New-MgBetaPrintTaskDefinitionTask.md)
Create new navigation property to tasks for print

### [Remove-MgBetaPrintConnector](Remove-MgBetaPrintConnector.md)
Delete navigation property connectors for print

### [Remove-MgBetaPrintOperation](Remove-MgBetaPrintOperation.md)
Delete navigation property operations for print

### [Remove-MgBetaPrintPrinter](Remove-MgBetaPrintPrinter.md)
Delete navigation property printers for print

### [Remove-MgBetaPrintPrinterShare](Remove-MgBetaPrintPrinterShare.md)
Delete navigation property printerShares for print

### [Remove-MgBetaPrintPrinterShareAllowedGroupByRef](Remove-MgBetaPrintPrinterShareAllowedGroupByRef.md)
Delete ref of navigation property allowedGroups for print

### [Remove-MgBetaPrintPrinterShareAllowedUserByRef](Remove-MgBetaPrintPrinterShareAllowedUserByRef.md)
Delete ref of navigation property allowedUsers for print

### [Remove-MgBetaPrintPrinterTaskTrigger](Remove-MgBetaPrintPrinterTaskTrigger.md)
Delete navigation property taskTriggers for print

### [Remove-MgBetaPrintService](Remove-MgBetaPrintService.md)
Delete navigation property services for print

### [Remove-MgBetaPrintServiceEndpoint](Remove-MgBetaPrintServiceEndpoint.md)
Delete navigation property endpoints for print

### [Remove-MgBetaPrintShare](Remove-MgBetaPrintShare.md)
Delete navigation property shares for print

### [Remove-MgBetaPrintShareAllowedGroupByRef](Remove-MgBetaPrintShareAllowedGroupByRef.md)
Delete ref of navigation property allowedGroups for print

### [Remove-MgBetaPrintShareAllowedUserByRef](Remove-MgBetaPrintShareAllowedUserByRef.md)
Delete ref of navigation property allowedUsers for print

### [Remove-MgBetaPrintTaskDefinition](Remove-MgBetaPrintTaskDefinition.md)
Delete navigation property taskDefinitions for print

### [Remove-MgBetaPrintTaskDefinitionTask](Remove-MgBetaPrintTaskDefinitionTask.md)
Delete navigation property tasks for print

### [Reset-MgBetaPrintPrinterDefault](Reset-MgBetaPrintPrinterDefault.md)
Invoke action resetDefaults

### [Restore-MgBetaPrintPrinterFactoryDefault](Restore-MgBetaPrintPrinterFactoryDefault.md)
Restore a printer's default settings to the values specified by the manufacturer.

### [Update-MgBetaPrint](Update-MgBetaPrint.md)
Update print

### [Update-MgBetaPrintConnector](Update-MgBetaPrintConnector.md)
Update the navigation property connectors in print

### [Update-MgBetaPrintOperation](Update-MgBetaPrintOperation.md)
Update the navigation property operations in print

### [Update-MgBetaPrintPrinter](Update-MgBetaPrintPrinter.md)
Update the navigation property printers in print

### [Update-MgBetaPrintPrinterShare](Update-MgBetaPrintPrinterShare.md)
Update the navigation property printerShares in print

### [Update-MgBetaPrintPrinterTaskTrigger](Update-MgBetaPrintPrinterTaskTrigger.md)
Update the navigation property taskTriggers in print

### [Update-MgBetaPrintService](Update-MgBetaPrintService.md)
Update the navigation property services in print

### [Update-MgBetaPrintServiceEndpoint](Update-MgBetaPrintServiceEndpoint.md)
Update the navigation property endpoints in print

### [Update-MgBetaPrintShare](Update-MgBetaPrintShare.md)
Update the navigation property shares in print

### [Update-MgBetaPrintTaskDefinition](Update-MgBetaPrintTaskDefinition.md)
Update the navigation property taskDefinitions in print

### [Update-MgBetaPrintTaskDefinitionTask](Update-MgBetaPrintTaskDefinitionTask.md)
Update the navigation property tasks in print

