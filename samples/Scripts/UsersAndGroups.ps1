$TenantId = "YOUR_TENANT_ID"
$ClientId = "YOUR_CLIENT_ID"
$CertThumbprint = "YOUR_CERTIFICATE_THUMBPRINT"
$AdminMail = "ADMIN_MAIL"

# Consent to permissions using app created in the last demo.
$AdminConsentUrl = "https://login.microsoftonline.com/$TenantId/adminconsent?client_id=$ClientId"
Write-Host -ForeGroundColor Yellow "Please go to the following URL in your browser to provide admin consent"
Write-Host $AdminConsentUrl
Write-Host "Press any key to continue when done ....."
$Key = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")

# Authenticate as a confidential client for app only calls.
Connect-Graph -ClientId $ClientId -TenantId $TenantId -CertificateThumbprint $CertThumbprint

# Get group named 'Weekday Employees'
$WeekdayEmployeesGroup = Get-MgGroup -Filter "DisplayName eq 'Weekday Employees'"

# Get Members of the group.
$GroupMembers = Get-MgGroupMember -GroupId $WeekdayEmployeesGroup.Id
$ToRecipients = @()
foreach ($member in $GroupMembers) {
    $User = Get-MgUser -UserId $member.Id -Select "displayName", "mail", "mailboxSettings" | `
                        Select DisplayName, Mail, MailboxSettings

    # Get users with invalid workdays in their mailbox setting.
    if ( $User.MailboxSettings.WorkingHours.DaysOfWeek -contains "saturday" || `
         $User.MailboxSettings.WorkingHours.DaysOfWeek -contains "sunday" ) {
             Write-Host -ForegroundColor Yellow "User "$User.DisplayName" has an invalid workday."

            $ToRecipients += @{ 
                emailAddress = @{
                    name = $User.DisplayName;
                    address = $User.Mail
                }}
    }
}

if ($ToRecipients.Length) {
    # Compose message.
    $Message = @{
        subject = "Update Your Mailbox Settings!";
        toRecipients = $ToRecipients;
        body = @{
            contentType = "Text";
            content = "Please update to your mailbox settings to reflect your working hours." + `
                    " You currently have Saturday and/or Sunday set as workday."
        }
    }
    
    $Admin = Get-MgUser -UserId $AdminMail

    # Send mail to users with invalid workdays.
    Send-MgUserMail -UserId $Admin.Id -BodyParameter @{message = $Message}
    Write-Host -ForegroundColor Green "Mail sent to affected users."
}

Disconnect-Graph
