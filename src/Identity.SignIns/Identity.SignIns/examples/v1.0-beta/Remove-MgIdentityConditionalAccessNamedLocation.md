### Example 1: Remove a named location

```powershell
Connect-MgBetaGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

Remove-MgBetaIdentityConditionalAccessNamedLocation -NamedLocationId $namedLocationId
```

This example removed the named location specified by `$namedLocationId`.
