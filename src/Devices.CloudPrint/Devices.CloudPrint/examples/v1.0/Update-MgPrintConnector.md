###Example 1
```
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "ConnectorName"
	FullyQualifiedDomainName = "CONNECTOR-MACHINE"
	OperatingSystem = "Microsoft Windows 10 Enterprise Insider Preview | 10.0.19555"
	AppVersion = "0.19.7338.23496"
	Location = @{
		Latitude = 1.1
		Longitude = 2.2
		AltitudeInMeters = 3
	}
}
Update-MgPrintConnector -PrintConnectorId $printConnectorId -BodyParameter $params
```
