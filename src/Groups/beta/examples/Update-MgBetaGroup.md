### Example 1: Update the properties of a group

```powershell
$GroupUpdate= @{
  "Description"= "This is a test group"
  "DisplayName"= "Test Group 1"

Update-MgBetaGroup -GroupId '74a7bfca-7fbc-4a67-b4bb-3ef115b114f1' 
  -BodyParameter $GroupUpdate
```

In this example, the first command defines a list of all properties that need to be updated and assign then the new values in the variable $GroupUpdate .
The second command updates the properties of the group specified by the GroupId.
