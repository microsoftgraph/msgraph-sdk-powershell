# Education

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Education v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# Directives go here!
directive:
# Wrapper migration: the adjacent wrapper/Education_directiveMigrationMap.json
# bridges all seven actual legacy DELETE matches in each profile to compatible
# collection /$ref operations by exact method/path; converted operation IDs differ.
# Education_cmdletConfigurations.cs suppresses only those DELETE operations in
# v1.0 and beta, including data-off runs. Existing v1.0 collision suppressions agree;
# GET/POST collection references and item-reference DELETE remain available.
# EducationDirectiveMigrationTests pins both profiles and neighboring operations.
# No shared parameter/schema directives are present; profile-local readmes and
# src/readme.graph.md are outside this migration. Keep this AutoRest directive
# active until the service-module pipeline is retired.
#Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0. 
  - remove-path-by-operation: ^education.class.assignment_DeleteCategoryGraphBPreRef$|^education.class_DeleteMemberGraphBPreRef$|^education.class_DeleteTeacherGraphBPreRef$|^education.me.assignment_DeleteCategoryGraphBPreRef$|^education.school_DeleteClassGraphBPreRef$|^education.school_DeleteUserGraphBPreRef$|^education.user.assignment_DeleteCategoryGraphBPreRef$
```
