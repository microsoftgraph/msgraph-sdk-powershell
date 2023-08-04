$permissionData = [PSCustomObject] @{
    Value = [PSCustomObject] @{
        Oauth2PermissionScopes=@(
            @{
                id = 'bc100f98-e72f-4ec1-8b05-67416fa62c97'
                value = 'RoleAssignmentSchedule.ReadWrite.Directory'
                type = 'admin'
                adminConsentDescription = "Allows the app to read and manage the active role-based access control (RBAC) assignments"
                userConsentDescription = ' Allows the user to read RBAC assignments'
                isEnabled = $true
            }
            @{
                id = 'dba67884-e7a5-4693-8a20-257f83a0a8ce'
                value = 'User.Read.Basic'
                type = 'User'
                adminConsentDescription = 'Basic read permission for directoryObjects for the organization'
                userConsentDescription = 'Allows the signed-in user to read basic information about other users'
                isEnabled = $true
            }
            @{
                id = '4fc2b8b7-cab6-4366-af7e-30398f2eb34d'
                value = 'Group.Read.Basic'
                type = 'User'
                adminConsentDescription = 'Basic read permission for group information for the organization'
                userConsentDescription = 'Allows the signed-in user to read basic information about groups'
                isEnabled = $true
            }

        )
        AppRoles=@(
            @{
                id = '88f16f48-5cec-4143-9494-8da33ccecad3'
                value = 'WorkforceIntegration.ReadWrite.All'
                origin = 'Application'
                displayName = 'Read and write workforce integrations'
                description = 'Allows the app to manage workforce integrations to synchronize data from Microsoft Teams Shifts without a user'
                isEnabled = $true
            }
            @{
                id = '8c59c222-4ecb-4229-821e-3e85a81d85e5'
                value = 'Directory.ReadWrite.All'
                origin = 'Application'
                displayName = 'Read and write workforce integrations'
                description = 'Allows the app to manage workforce integrations to synchronize data from Microsoft Teams Shifts without a user'
                isEnabled = $true
            }
            @{
                id = '975c63a6-9913-47cf-8a14-66c10cfaaf43'
                value = 'Group.ReadWrite.All'
                origin = 'Application'
                description = 'Allows the app to manage workforce integrations to synchronize data from Microsoft Teams Shifts without a user'
                isEnabled = $true
            }
            @{
                id = '19f4bc3b-8cd0-4d23-9a90-3c97eb1f336d'
                value = 'People.Read.All'
                origin = 'Delegated'
                description = 'Allows access to people analytics'
                isEnabled = $true
            }
        )
    }
}