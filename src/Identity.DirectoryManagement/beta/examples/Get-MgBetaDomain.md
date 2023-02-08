### Example 1: Get a list of domaim objects

```powershell
Get-MgBetaDomain | Format-List

AuthenticationType               : Managed
AvailabilityStatus               :
DomainNameReferences             :
Id                               : contoso.com
IsAdminManaged                   : True
IsDefault                        : True
IsInitial                        : True
IsRoot                           : True
IsVerified                       : True
Manufacturer                     :
Model                            :
PasswordNotificationWindowInDays : 14
PasswordValidityPeriodInDays     : 2147483647
ServiceConfigurationRecords      :
State                            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphDomainState
SupportedServices                : {Email, OfficeCommunicationsOnline}
VerificationDnsRecords           :
AdditionalProperties             : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#domains/$entity]}
```

This example retrieves a list of the domain objects.
