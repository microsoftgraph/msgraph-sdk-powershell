### Example 1: Remove the application role assignment for a service principal

```powershell
Remove-MgBetaServicePrincipalAppRoleAssignment -AppRoleAssignmentId  'PRLbC6e4yUyMwr0XutBvYZsr7FiAW3pIqP4F9944yBc' -ServicePrincipalId '0bdb123d-b8a7-4cc9-8cc2-bd17bad06f61'
```

This example removed the assignment of the specified service principal to the specified application role id.
