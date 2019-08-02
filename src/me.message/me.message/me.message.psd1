@{
  GUID = '33ba59ce-14de-4e07-84b5-c789ea8c4a35'
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
