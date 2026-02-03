### Example 1: Use $extend and $filter to get teamTemplateDefinitions for en-US locale

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamworkTeamTemplate -ExpandProperty "definitions" -Filter "definitions/any(a:a/languageTag eq 'en-US')" 

```
This example will use $extend and $filter to get teamtemplatedefinitions for en-us locale

