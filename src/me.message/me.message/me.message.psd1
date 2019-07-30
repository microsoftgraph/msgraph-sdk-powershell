@{
  GUID = '2084ad2d-d228-4478-bd70-3c6288ce63c9'
  RootModule = './me.message.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = ''
  CompanyName = ''
  Copyright = ''
  Description = ''
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/me.message.private.dll'
  FormatsToProcess = './me.message.format.ps1xml'
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
