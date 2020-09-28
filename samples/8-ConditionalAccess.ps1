#Minimum required parameters to create a conditional access policy

New-MgIdentityConditionalAccessPolicy -DisplayName 'Minimum required Parameters' `
     -GrantControls @{ `
        BuiltInControls = @('mfa'); `
        Operator = 'OR' `
     } `
     -State 'disabled' `
     -Conditions @{ `
        Applications = @{includeApplications = 'none'}; `
        Users = @{includeUsers = 'none'} `
     }

# Get a list of conditional access policies where DisplayName starts with Minimum.
Get-MgIdentityConditionalAccessPolicy -Filter "StartsWith(DisplayName, 'Minimum')"
