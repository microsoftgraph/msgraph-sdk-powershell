using module "..\Microsoft.Graph.Tools.Migration.psm1"
Describe "New-MgMigrationPlan Command" {
      Context "V1.0 scripts" {
        It 'Should not output anything' {
            {
                $FilePath = Join-Path $PSScriptRoot "..\..\..\samples\6-Sites.ps1"
                $MgCommand = New-MgMigrationPlan -FilePath $FilePath
                $MgCommand | Should -Be $null
            } | Should -Not -Throw
        }
      }
    #   Context "Scripts with Select-MgProfile -Name Beta declaration at the start" {
    #     It 'Should output an object' {
    #         {
    #             $FilePath = Join-Path $PSScriptRoot "..\..\..\samples\5-Teams.ps1"
    #             $MgCommand = New-MgMigrationPlan -FilePath $FilePath
    #             $MgCommand | Should -BeOfType [System.Object]
    #         } | Should -Not -Throw
    #     }
    #   }
    #   Context "Scripts without Select-MgProfile -Name Beta declaration but are used for beta functions" {
    #     It 'Should output an object' {
    #         {
    #             $FilePath = Join-Path $PSScriptRoot "..\..\..\samples\6-Sites.ps1"
    #             $MgCommand = New-MgMigrationPlan -FilePath $FilePath -GraphProfile Beta
    #             $MgCommand | Should -BeOfType [System.Object]
    #         } | Should -Not -Throw
    #     }
    #   }
    #   Context "Scripts that have random declarations of Select-MgProfile -Name Beta and Select-MgProfile -Name V1.0" {
    #     It 'Should output an object' {
    #         {
    #             $FilePath = Join-Path $PSScriptRoot "..\..\..\samples\10-RandomProfileChanges.ps1"
    #             $MgCommand = New-MgMigrationPlan -FilePath $FilePath
    #             $MgCommand | Should -BeOfType [System.Object]
    #         } | Should -Not -Throw
    #     }
    #   }
      Context "Extract updated script from migration tool" {
        It 'Should output an object' {
            {
                $FilePath = Join-Path $PSScriptRoot "..\..\..\samples\5-Teams.ps1"
                $UpdatedFilePath = Join-Path $PSScriptRoot "..\..\..\samples"
                $MgCommand = New-MgMigrationPlan -FilePath $FilePath -UpdatedFilePath $UpdatedFilePath
                $MgCommand | Should -BeOfType [System.Object]
            } | Should -Not -Throw
        }
      }
      Context "Extract updated script from migration tool - wrong path provided" {
        It 'Should throw' {
            {
                $FilePath = Join-Path $PSScriptRoot "..\..\..\samples\5-Teams.ps1"
                $UpdatedFilePath = Join-Path $PSScriptRoot "..\..\..\samplesx"
                $MgCommand = New-MgMigrationPlan -FilePath $FilePath -UpdatedFilePath $UpdatedFilePath
            } | Should -Throw
        }
      }
} 
