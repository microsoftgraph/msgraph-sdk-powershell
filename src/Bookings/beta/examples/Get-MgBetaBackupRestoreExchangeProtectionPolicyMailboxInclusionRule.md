### Example 1: Get a mailboxInclusionRule associated with an Exchange protection policy

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBackupRestoreExchangeProtectionPolicyMailboxInclusionRule -ExchangeProtectionPolicyId $exchangeProtectionPolicyId -MailboxProtectionRuleId $mailboxProtectionRuleId

```
This example will get a mailboxinclusionrule associated with an exchange protection policy

