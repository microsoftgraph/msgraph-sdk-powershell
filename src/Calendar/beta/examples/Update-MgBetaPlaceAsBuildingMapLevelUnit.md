### Example 1: Update an existing unitMap

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	placeId = $null
	properties = '{"id":"005eb3b8-c95d-4d35-a8a0-22d3cb4d6542","type":"Feature","feature_type":"unit","geometry":{"type":"Polygon","coordinates":[[[-121.8889415,37.3295396],[-121.8889137,37.329503],[-121.8889082,37.3294956],[-121.888907,37.3294941],[-121.8888551,37.3295189],[-121.8888895,37.3295644],[-121.8889415,37.3295396]]]},"properties":{"name":{"en":"Test room from Test Floor 1 (120.3)"},"level_id":"e537d463-475b-43c3-a650-184566c68bc9","display_point":{"type":"Point","coordinates":[-121.8888983,37.3295292]},"category":"room"}}'
}

Update-MgBetaPlaceAsBuildingMapLevelUnit -PlaceId $placeId -LevelMapId $levelMapId -UnitMapId $unitMapId -BodyParameter $params

```
This example will update an existing unitmap

### Example 2: Create a unitMap if it doesn't exist

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	properties = '{"id":"005eb3b8-c95d-4d35-a8a0-22d3cb4d6996","type":"Feature","feature_type":"unit","geometry":{"type":"Polygon","coordinates":[[[-121.8889415,37.3295396],[-121.8889137,37.329503],[-121.8889082,37.3294956],[-121.888907,37.3294941],[-121.8888551,37.3295189],[-121.8888895,37.3295644],[-121.8889415,37.3295396]]]},"properties":{"name":{"en":"Test Create room111111111111"},"level_id":"e537d463-475b-43c3-a650-184566c68bc9","display_point":{"type":"Point","coordinates":[-121.8888983,37.3295292]},"category":"room"}}'
}

Update-MgBetaPlaceAsBuildingMapLevelUnit -PlaceId $placeId -LevelMapId $levelMapId -UnitMapId $unitMapId -BodyParameter $params

```
This example will create a unitmap if it doesn't exist

