@{
  GUID = '9330422a-069f-47b2-96c7-17fc73d8b6bf'
  RootModule = './Graph.me.message.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft'
  CompanyName = 'Microsoft'
  Copyright = '© Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Graph PowerShell module'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Graph.me.message.private.dll'
  FormatsToProcess = './Graph.me.message.format.ps1xml'
  CmdletsToExport = 'Get-MeMessage', 'New-MeMessage', 'Update-MeMessage', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = ''
      LicenseUri = ''
      ProjectUri = ''
      ReleaseNotes = ''
    }
  }
}
