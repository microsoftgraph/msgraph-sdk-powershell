#Minimum required parameters to create a conditional access policy

New-MgConditionalAccessPolicy -DisplayName 'Minimum required Parameters' `
     -GrantControlBuiltInControls @('mfa') `
     -State 'disabled' `
     -GrantControlOperator 'OR' `
     -Conditions @{ `
       applications = @{includeApplications = 'none'}; `
       users = @{includeUsers = 'none'} `
     }

# Get a list of conditional access policies where DisplayName starts with Minimum.
Get-MgConditionalAccessPolicy -Filter "StartsWith(DisplayName, 'Minimum')"
