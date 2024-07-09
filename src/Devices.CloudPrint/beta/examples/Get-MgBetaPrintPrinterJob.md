### Example 1: Get print job

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

Get-MgBetaPrintPrinterJob -PrinterId $printerId -PrintJobId $printJobId

```
This example will get print job

### Example 2: Get print job with task list

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

Get-MgBetaPrintPrinterJob -PrinterId $printerId -PrintJobId $printJobId -ExpandProperty "tasks" 

```
This example will get print job with task list

### Example 3: Get a print job and its associated document data

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

Get-MgBetaPrintPrinterJob -PrinterId $printerId -PrintJobId $printJobId -ExpandProperty "documents" 

```
This example will get a print job and its associated document data

