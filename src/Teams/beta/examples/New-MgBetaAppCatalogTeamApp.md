### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = [Zip file containing a Teams app package]


New-MgBetaAppCatalogTeamApp -BodyParameter $params

```
This example shows how to use the New-MgBetaAppCatalogTeamApp Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

New-MgBetaAppCatalogTeamApp -Requiresreview true 

```
This example shows how to use the New-MgBetaAppCatalogTeamApp Cmdlet.

