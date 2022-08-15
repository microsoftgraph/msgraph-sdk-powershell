### Example 1: Configure federation settings for a federated domain

```powershell
New-MgDomainFederationConfiguration -DomainId "contoso.com" -ActiveSignInUri "https://sts.contoso.com/adfs/services/trust/2005/usernamemixed" -DisplayName "Contoso" -IssuerUri "http://contoso.com/adfs/services/trust/" -MetadataExchangeUri "https://sts.contoso.com/adfs/services/trust/mex" -NextSigningCertificate "MIIC3jCCAcagAwIBAgIQEt0T0G5GPZ9" -PassiveSignInUri "https://sts.contoso.com/adfs/ls/" -SignOutUri "https://sts.contoso.com/adfs/ls/" -SigningCertificate "MIIC3jCCAcagAwIBAgIQFsO0R8deG4h" -FederatedIdpMfaBehavior "rejectMfaByFederatedIdp" | Format-List 

ActiveSignInUri                       : https://sts.deverett.info/adfs/services/trust/2005/usernamemixed 
DisplayName                           : Contoso 
FederatedIdpMfaBehavior               : rejectMfaByFederatedIdp 
Id                                    : 2a8ce608-bb34-473f-9e0f-f373ee4cbc5a 
IsSignedAuthenticationRequestRequired : 
IssuerUri                             : http://contoso.com/adfs/services/trust/ 
MetadataExchangeUri                   : https://sts.contoso.com/adfs/services/trust/mex 
NextSigningCertificate                : MIIC3jCCAcagAwIBAgIQEt0T0G5GPZ9 
PassiveSignInUri                      : https://sts.contoso.com/adfs/ls/ 
PreferredAuthenticationProtocol       : wsFed 
PromptLoginBehavior                   :  
SignOutUri                            : https://sts.deverett.info/adfs/ls/ 
SigningCertificate                    : MIIC3jCCAcagAwIBAgIQFsO0R8deG4h 
SigningCertificateUpdateStatus        : Microsoft.Graph.PowerShell.Models.MicrosoftGraphSigningCertificateUpdateStatus 
AdditionalProperties                  : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#domains('contoso.com')/federationConfiguration/$entity]} 
```

This examples creates new federation settings for the specified domain.
