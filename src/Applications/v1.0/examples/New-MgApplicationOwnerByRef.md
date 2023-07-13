### Example 1: Add an owner to an application

```powershell
 $NewOwner = @{
  "@odata.id"= "https://graph.microsoft.com/v1.0/directoryObjects/{075b32dd-edb7-47cf-89ef-f3f733683a3f}"
  }

New-MgApplicationOwnerByRef -ApplicationId 'f6b30057-7095-4e2c-89f8-224149f591b7' -BodyParameter $NewOwner
```

In this example, the first command defines the value for the $NewOwner variable. The second command adds the new owner to the specified application.
