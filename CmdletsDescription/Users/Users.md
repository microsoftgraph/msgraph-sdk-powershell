## Users

1. List users in your tenant.

    ``` powershell
    Get-MgUser -Top 10 -Property Id, DisplayName, BusinessPhones | Format-Table Id, DisplayName, BusinessPhones
    ```

2. Filter a user in your tenant.

    ``` powershell
    $user = Get-MgUser -Filter "displayName eq 'Megan Bowen'"
    ```