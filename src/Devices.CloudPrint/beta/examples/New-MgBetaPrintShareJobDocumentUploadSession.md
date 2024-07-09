### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	properties = @{
		documentName = "TestFile.pdf"
		contentType = "application/pdf"
		size = 4533322
	}
}

New-MgBetaPrintShareJobDocumentUploadSession -PrinterShareId $printerShareId -PrintJobId $printJobId -PrintDocumentId $printDocumentId -BodyParameter $params

```
This example shows how to use the New-MgBetaPrintShareJobDocumentUploadSession Cmdlet.

