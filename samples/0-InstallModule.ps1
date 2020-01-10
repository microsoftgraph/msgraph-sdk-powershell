# Installing the Module

# Temporarily, register this repository
Register-PSRepository `
-Name GraphPowerShell `
-SourceLocation https://graphpowershellrepository.azurewebsites.net/nuget

# Installing the Graph PowerShell module for the Beta API 
Install-module Microsoft.Graph.Beta -Repository GraphPowerShell
