@{
  GUID = '6a9fa9cc-485e-4677-899a-306902a2681f'
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
