### Example 1: Add a password credential to an application with a six month expiry

```powershell

Connect-MgGraph -Scopes 'Application.ReadWrite.All'

$appObjectId = 'eaf1e531-0d58-4874-babe-b9a9f436e6c3'

$passwordCred = @{
   displayName = 'Created in PowerShell'
   endDateTime = (Get-Date).AddMonths(6)
}

$secret = Add-MgApplicationPassword -applicationId $appObjectId -PasswordCredential $passwordCred
$secret | Format-List

CustomKeyIdentifier  :
DisplayName          : Created in PowerShell
EndDateTime          : 26/11/2022 12:03:31 pm
Hint                 : Q_e
KeyId                : c82bb763-741b-4575-9d9d-df7e766f6999
SecretText           : Q_e8Q~ZDWJD.bkgajbREp-VFFUayCuEk8b1hDcr9
StartDateTime        : 26/5/2022 1:03:31 pm
AdditionalProperties : {[@odata.context,
                       https://graph.microsoft.com/v1.0/$metadata#microsoft.graph.passwordCredential]}
```

Add a password to an application that expires in six months from the current date.

### Example 2: Add a password credential to an application with a start date

```powershell

Connect-MgGraph -Scopes 'Application.ReadWrite.All'

$appObjectId = 'eaf1e531-0d58-4874-babe-b9a9f436e6c3'

$startDate = (Get-Date).AddDays(1).Date
$endDate = $startDate.AddMonths(6)

$passwordCred = @{
   displayName = 'Created in PowerShell'
   startDateTime = $startDate
   endDateTime = $endDate
}

$secret = Add-MgApplicationPassword -applicationId $appObjectId -PasswordCredential $passwordCred
$secret | Format-List

CustomKeyIdentifier  :
DisplayName          : Created in PowerShell
EndDateTime          : 26/11/2022 1:00:00 pm
Hint                 : TiA
KeyId                : 082bf20f-63d6-4970-bb4e-55e504f50d8b
SecretText           : TiA8Q~Zs7ej1cGtlW0qnmuFi~JlxXTZew_tU1bGA
StartDateTime        : 26/5/2022 2:00:00 pm
AdditionalProperties : {[@odata.context,
                       https://graph.microsoft.com/v1.0/$metadata#microsoft.graph.passwordCredential]}
```

Add a password to an application that becomes valid at 12:00 am the next day and is valid for six months.

Use `$secret.StartDateTime.ToLocalTime()` to convert the returned dates from UTC to the local timezone.
