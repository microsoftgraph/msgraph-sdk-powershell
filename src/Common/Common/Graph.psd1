@{
    GUID = '33ba59ce-14de-4e07-84b5-c789ea8c4a49'
    RootModule = './Graph.psm1'
    ModuleVersion = '0.0.1'
    CompatiblePSEditions = 'Core', 'Desktop'
    Author = 'Microsoft'
    CompanyName = 'Microsoft'
    Copyright = '© Microsoft Corporation. All rights reserved'
    Description = 'Microsoft Graph MeMessage PowerShell module'
    PowerShellVersion = '5.1'
    DotNetFrameworkVersion = '4.7.2'
    RequiredAssemblies = './bin/Common.dll'
    #FormatsToProcess = './me.message.format.ps1xml'
    CmdletsToExport = 'Connect-Graph', 'Disconnect-Graph', '*'
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
  