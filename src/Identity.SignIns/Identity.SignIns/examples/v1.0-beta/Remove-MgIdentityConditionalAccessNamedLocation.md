### Example 1: Remove a named location

```powershell
Connect-MgGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

Remove-MgIdentityConditionalAccessNamedLocation -NamedLocationId $namedLocationId
```

This example removed the named location specified by `$namedLocationId`.
