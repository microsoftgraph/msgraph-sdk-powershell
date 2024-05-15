Describe "Find-MgGraphCommand Command" {
    BeforeAll {
        . (join-path $PSScriptRoot  ..\custom\Find-MgGraphCommand.ps1)
    }
    Describe "BreakingChanges" {
        $CommandList = @()
        $Reports = @()
        $BreakingChangeReportV1Report = (Join-Path $PSScriptRoot "..\..\..\..\docs\PowerShellBreakingChanges-V1.0.csv")
        $BreakingChangeReportBetaReport = (Join-Path $PSScriptRoot "..\..\..\..\docs\PowerShellBreakingChanges-Beta.csv")
        $Reports += $BreakingChangeReportV1Report
        $Reports += $BreakingChangeReportBetaReport
        foreach ($BreakingChangeReport in $Reports) {
            Import-Csv $BreakingChangeReport |`
                ForEach-Object {
                $CommandTable = @{
                }
                $Command = $_."NewCmdlet"
                $Alias = $_."OldCmdlet"
                $CommandTable.Add("Command", $Command)
                $CommandTable.Add("Alias", $Alias)
                $CommandList += $CommandTable
            }
            It "Returns <Alias> (<Command>)" -ForEach $CommandList {
                $MgCommand = Find-MgGraphCommand -Command "$Command"
                $MgCommand[0].Command | Select-Object -Unique | Should -Be "$Command"
                $MgCommand[0].CommandAlias | Select-Object -Unique | Should -Be "$Alias"
            }
        }
    }

}