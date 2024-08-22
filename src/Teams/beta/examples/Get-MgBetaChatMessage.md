### Example 1: List chat messages sorted by creation date

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatMessage -ChatId $chatId -Top 2 -Sort "createdDateTime desc" 

```
This example will list chat messages sorted by creation date

### Example 2: List chat messages filtered by last modified date range

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatMessage -ChatId $chatId -Top 2 -Sort "lastModifiedDateTime desc" -Filter "lastModifiedDateTime gt 2022-09-22T00:00:00.000Z and lastModifiedDateTime lt 2022-09-24T00:00:00.000Z" 

```
This example will list chat messages filtered by last modified date range

