### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	destinationPrinterId = "9a3b3956-ce5b-4d06-a605-5b0bd3e9ddea"
	configuration = @{
		feedOrientation = "longEdgeFirst"
		pageRanges = @(
			@{
				start = 1
				end = 1
			}
		)
		quality = "medium"
		dpi = 600
		orientation = "landscape"
		copies = 1
		duplexMode = "oneSided"
		colorMode = "blackAndWhite"
		inputBin = "by-pass-tray"
		outputBin = "output-tray"
		mediaSize = "A4"
		margin = @{
			top = 0
			bottom = 0
			left = 0
			right = 0
		}
		mediaType = "stationery"
		finishings = $null
		pagesPerSheet = 1
		multipageLayout = "clockwiseFromBottomLeft"
		collate = $false
		scaling = "shrinkToFit"
		fitPdfToPage = $false
	}
}

Invoke-MgBetaRedirectPrintPrinterJob -PrinterId $printerId -PrintJobId $printJobId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaRedirectPrintPrinterJob Cmdlet.

