### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = [Zip file containing a Teams app package]


New-MgAppCatalogTeamApp -BodyParameter $params

```
This example shows how to use the New-MgAppCatalogTeamApp Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

New-MgAppCatalogTeamApp -Requiresreview true 

```
This example shows how to use the New-MgAppCatalogTeamApp Cmdlet.

