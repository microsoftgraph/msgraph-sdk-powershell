---
Module Name: Microsoft.Graph.Beta.Education
Module Guid: 40954ac5-1203-43c6-9788-d943608f9c0c
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.education
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Education Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Education Cmdlets
### [Get-MgBetaEducationClass](Get-MgBetaEducationClass.md)
Retrieve a class from the system.
A class is a universal group with a special property that indicates to the system that the group is a class.
Group members represent the students; group admins represent the teachers in the class.
If you're using the delegated token, the user will only see classes in which they are members.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignment](Get-MgBetaEducationClassAssignment.md)
Get the properties and relationships of an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
Students can only see assignments assigned to them; teachers and applications with application permissions can see all assignments in a class.
You can use the Prefer header in your request to get the inactive status in case the assignment is deactivated; otherwise, you will get an unknownFutureValue value in the response.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentCategory](Get-MgBetaEducationClassAssignmentCategory.md)
Retrieve an educationCategory object.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentCategoryByRef](Get-MgBetaEducationClassAssignmentCategoryByRef.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentCategoryCount](Get-MgBetaEducationClassAssignmentCategoryCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentCategoryDelta](Get-MgBetaEducationClassAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgBetaEducationClassAssignmentCount](Get-MgBetaEducationClassAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentDefault](Get-MgBetaEducationClassAssignmentDefault.md)
Read the properties and relationships of an educationAssignmentDefaults object.
These are the class-level assignment defaults respected by new assignments created in the class.
Callers can continue to specify custom values on each assignment creation if they don't want the default behaviors.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentDelta](Get-MgBetaEducationClassAssignmentDelta.md)
Invoke function delta

### [Get-MgBetaEducationClassAssignmentGradingCategory](Get-MgBetaEducationClassAssignmentGradingCategory.md)
Get gradingCategory from education

### [Get-MgBetaEducationClassAssignmentResource](Get-MgBetaEducationClassAssignmentResource.md)
Get the properties of an education assignment resource associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentResourceCount](Get-MgBetaEducationClassAssignmentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentResourceDependentResource](Get-MgBetaEducationClassAssignmentResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationClassAssignmentResourceDependentResourceCount](Get-MgBetaEducationClassAssignmentResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentRubric](Get-MgBetaEducationClassAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentRubricByRef](Get-MgBetaEducationClassAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentSetting](Get-MgBetaEducationClassAssignmentSetting.md)
Read the properties and relationships of an educationAssignmentSettings object.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentSettingGradingCategory](Get-MgBetaEducationClassAssignmentSettingGradingCategory.md)
Get gradingCategories from education

### [Get-MgBetaEducationClassAssignmentSettingGradingCategoryCount](Get-MgBetaEducationClassAssignmentSettingGradingCategoryCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentSubmission](Get-MgBetaEducationClassAssignmentSubmission.md)
Retrieve a particular submission.
Only teachers, students, and applications with application permissions can perform this operation.
A submission object represents a student's work for an assignment.
Resources associated with the submission represent this work.
Only the assignedTo student can see and modify the submission.
A teacher or application with application permissions has full access to all submissions.
The grade and feedback from a teacher are part of the educationOutcome associated with this object.
Only teachers or applications with application permissions can add or change grades and feedback.
Students will not see the grade or feedback until the assignment has been released.
Provide the header Prefer: include-unknown-enum-members to properly list submissions with the reassigned status.
For details, see the examples section.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentSubmissionCount](Get-MgBetaEducationClassAssignmentSubmissionCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentSubmissionOutcome](Get-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgBetaEducationClassAssignmentSubmissionOutcomeCount](Get-MgBetaEducationClassAssignmentSubmissionOutcomeCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentSubmissionResource](Get-MgBetaEducationClassAssignmentSubmissionResource.md)
Retrieve the properties of a specific resource associated with a submission.
Only teachers, students, and applications with application permissions can perform this operation.
This resource is in the 'working' resource list and should be considered work in process by a student.
This resource is wrapped with a possible pointer back to the assignment resource if it was copied from the assignment.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassAssignmentSubmissionResourceCount](Get-MgBetaEducationClassAssignmentSubmissionResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentSubmissionResourceDependentResource](Get-MgBetaEducationClassAssignmentSubmissionResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationClassAssignmentSubmissionResourceDependentResourceCount](Get-MgBetaEducationClassAssignmentSubmissionResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentSubmissionSubmittedResource](Get-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgBetaEducationClassAssignmentSubmissionSubmittedResourceCount](Get-MgBetaEducationClassAssignmentSubmissionSubmittedResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource](Get-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResourceCount](Get-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassCount](Get-MgBetaEducationClassCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassDelta](Get-MgBetaEducationClassDelta.md)
Invoke function delta

### [Get-MgBetaEducationClassGroup](Get-MgBetaEducationClassGroup.md)
Retrieve the Microsoft 365 group that corresponds to this educationClass.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassGroupServiceProvisioningError](Get-MgBetaEducationClassGroupServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a group object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaEducationClassGroupServiceProvisioningErrorCount](Get-MgBetaEducationClassGroupServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassMember](Get-MgBetaEducationClassMember.md)
Retrieve the teachers and students for a class.
Note that if the delegated token is used, members can only be seen by other members of the class.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassMemberByRef](Get-MgBetaEducationClassMemberByRef.md)
Retrieve the teachers and students for a class.
Note that if the delegated token is used, members can only be seen by other members of the class.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassMemberCount](Get-MgBetaEducationClassMemberCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassModule](Get-MgBetaEducationClassModule.md)
Get the properties and relationships of a module.
Only teachers, students, and applications with application permissions can perform this operation.
Students can only see published modules; teachers and applications with application permissions can see all modules in a class.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassModuleCount](Get-MgBetaEducationClassModuleCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassModuleResource](Get-MgBetaEducationClassModuleResource.md)
Get the properties of a resource associated with a module.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassModuleResourceCount](Get-MgBetaEducationClassModuleResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassSchool](Get-MgBetaEducationClassSchool.md)
All schools that this class is associated with.
Nullable.

### [Get-MgBetaEducationClassSchoolCount](Get-MgBetaEducationClassSchoolCount.md)
Get the number of the resource

### [Get-MgBetaEducationClassTeacher](Get-MgBetaEducationClassTeacher.md)
Retrieve a list of teachers for a class.
Delegated tokens must be members of the class to get the teacher list.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassTeacherByRef](Get-MgBetaEducationClassTeacherByRef.md)
Retrieve a list of teachers for a class.
Delegated tokens must be members of the class to get the teacher list.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationClassTeacherCount](Get-MgBetaEducationClassTeacherCount.md)
Get the number of the resource

### [Get-MgBetaEducationMe](Get-MgBetaEducationMe.md)
Get me from education

### [Get-MgBetaEducationMeAssignment](Get-MgBetaEducationMeAssignment.md)
List of assignments for the user.
Nullable.

### [Get-MgBetaEducationMeAssignmentCategory](Get-MgBetaEducationMeAssignmentCategory.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeAssignmentCategoryByRef](Get-MgBetaEducationMeAssignmentCategoryByRef.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeAssignmentCategoryCount](Get-MgBetaEducationMeAssignmentCategoryCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentCategoryDelta](Get-MgBetaEducationMeAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgBetaEducationMeAssignmentCount](Get-MgBetaEducationMeAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentDelta](Get-MgBetaEducationMeAssignmentDelta.md)
Invoke function delta

### [Get-MgBetaEducationMeAssignmentGradingCategory](Get-MgBetaEducationMeAssignmentGradingCategory.md)
Get gradingCategory from education

### [Get-MgBetaEducationMeAssignmentResource](Get-MgBetaEducationMeAssignmentResource.md)
Get the properties of an education assignment resource associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeAssignmentResourceCount](Get-MgBetaEducationMeAssignmentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentResourceDependentResource](Get-MgBetaEducationMeAssignmentResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationMeAssignmentResourceDependentResourceCount](Get-MgBetaEducationMeAssignmentResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentRubric](Get-MgBetaEducationMeAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeAssignmentRubricByRef](Get-MgBetaEducationMeAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeAssignmentSubmission](Get-MgBetaEducationMeAssignmentSubmission.md)
Retrieve a particular submission.
Only teachers, students, and applications with application permissions can perform this operation.
A submission object represents a student's work for an assignment.
Resources associated with the submission represent this work.
Only the assignedTo student can see and modify the submission.
A teacher or application with application permissions has full access to all submissions.
The grade and feedback from a teacher are part of the educationOutcome associated with this object.
Only teachers or applications with application permissions can add or change grades and feedback.
Students will not see the grade or feedback until the assignment has been released.
Provide the header Prefer: include-unknown-enum-members to properly list submissions with the reassigned status.
For details, see the examples section.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeAssignmentSubmissionCount](Get-MgBetaEducationMeAssignmentSubmissionCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentSubmissionOutcome](Get-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgBetaEducationMeAssignmentSubmissionOutcomeCount](Get-MgBetaEducationMeAssignmentSubmissionOutcomeCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentSubmissionResource](Get-MgBetaEducationMeAssignmentSubmissionResource.md)
Retrieve the properties of a specific resource associated with a submission.
Only teachers, students, and applications with application permissions can perform this operation.
This resource is in the 'working' resource list and should be considered work in process by a student.
This resource is wrapped with a possible pointer back to the assignment resource if it was copied from the assignment.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeAssignmentSubmissionResourceCount](Get-MgBetaEducationMeAssignmentSubmissionResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentSubmissionResourceDependentResource](Get-MgBetaEducationMeAssignmentSubmissionResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationMeAssignmentSubmissionResourceDependentResourceCount](Get-MgBetaEducationMeAssignmentSubmissionResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentSubmissionSubmittedResource](Get-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgBetaEducationMeAssignmentSubmissionSubmittedResourceCount](Get-MgBetaEducationMeAssignmentSubmissionSubmittedResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource](Get-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResourceCount](Get-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeClass](Get-MgBetaEducationMeClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgBetaEducationMeClassCount](Get-MgBetaEducationMeClassCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeRubric](Get-MgBetaEducationMeRubric.md)
Retrieve the properties and relationships of an educationRubric object.
Only teachers and students can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeRubricCount](Get-MgBetaEducationMeRubricCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeSchool](Get-MgBetaEducationMeSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgBetaEducationMeSchoolCount](Get-MgBetaEducationMeSchoolCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeTaughtClass](Get-MgBetaEducationMeTaughtClass.md)
Classes for which the user is a teacher.

### [Get-MgBetaEducationMeTaughtClassCount](Get-MgBetaEducationMeTaughtClassCount.md)
Get the number of the resource

### [Get-MgBetaEducationMeUser](Get-MgBetaEducationMeUser.md)
Retrieve the simple directory user that corresponds to this educationUser.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationMeUserMailboxSetting](Get-MgBetaEducationMeUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaEducationMeUserServiceProvisioningError](Get-MgBetaEducationMeUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaEducationMeUserServiceProvisioningErrorCount](Get-MgBetaEducationMeUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaEducationRoot](Get-MgBetaEducationRoot.md)
Get education

### [Get-MgBetaEducationSchool](Get-MgBetaEducationSchool.md)
Retrieve the properties and relationships of the school object.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationSchoolAdministrativeUnit](Get-MgBetaEducationSchoolAdministrativeUnit.md)
Retrieve the directory administrativeUnit that corresponds to this educationSchool.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationSchoolClass](Get-MgBetaEducationSchoolClass.md)
Retrieve a list of classes owned by a school.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationSchoolClassByRef](Get-MgBetaEducationSchoolClassByRef.md)
Retrieve a list of classes owned by a school.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationSchoolClassCount](Get-MgBetaEducationSchoolClassCount.md)
Get the number of the resource

### [Get-MgBetaEducationSchoolCount](Get-MgBetaEducationSchoolCount.md)
Get the number of the resource

### [Get-MgBetaEducationSchoolDelta](Get-MgBetaEducationSchoolDelta.md)
Invoke function delta

### [Get-MgBetaEducationSchoolUser](Get-MgBetaEducationSchoolUser.md)
Retrieve a list of users at a school.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationSchoolUserByRef](Get-MgBetaEducationSchoolUserByRef.md)
Retrieve a list of users at a school.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationSchoolUserCount](Get-MgBetaEducationSchoolUserCount.md)
Get the number of the resource

### [Get-MgBetaEducationSynchronizationProfile](Get-MgBetaEducationSynchronizationProfile.md)
Retrieve a school data synchronization profile in the tenant based on the identifier.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationSynchronizationProfileCount](Get-MgBetaEducationSynchronizationProfileCount.md)
Get the number of the resource

### [Get-MgBetaEducationSynchronizationProfileError](Get-MgBetaEducationSynchronizationProfileError.md)
All errors associated with this synchronization profile.

### [Get-MgBetaEducationSynchronizationProfileErrorCount](Get-MgBetaEducationSynchronizationProfileErrorCount.md)
Get the number of the resource

### [Get-MgBetaEducationSynchronizationProfileStatus](Get-MgBetaEducationSynchronizationProfileStatus.md)
Get the status of a specific school data synchronization profile in the tenant.
The response will indicate the status of the sync.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUser](Get-MgBetaEducationUser.md)
Retrieve the properties and relationships of a user.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignment](Get-MgBetaEducationUserAssignment.md)
List of assignments for the user.
Nullable.

### [Get-MgBetaEducationUserAssignmentCategory](Get-MgBetaEducationUserAssignmentCategory.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignmentCategoryByRef](Get-MgBetaEducationUserAssignmentCategoryByRef.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignmentCategoryCount](Get-MgBetaEducationUserAssignmentCategoryCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentCategoryDelta](Get-MgBetaEducationUserAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgBetaEducationUserAssignmentCount](Get-MgBetaEducationUserAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentDelta](Get-MgBetaEducationUserAssignmentDelta.md)
Invoke function delta

### [Get-MgBetaEducationUserAssignmentGradingCategory](Get-MgBetaEducationUserAssignmentGradingCategory.md)
Get gradingCategory from education

### [Get-MgBetaEducationUserAssignmentResource](Get-MgBetaEducationUserAssignmentResource.md)
Get the properties of an education assignment resource associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignmentResourceCount](Get-MgBetaEducationUserAssignmentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentResourceDependentResource](Get-MgBetaEducationUserAssignmentResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationUserAssignmentResourceDependentResourceCount](Get-MgBetaEducationUserAssignmentResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentRubric](Get-MgBetaEducationUserAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignmentRubricByRef](Get-MgBetaEducationUserAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignmentSubmission](Get-MgBetaEducationUserAssignmentSubmission.md)
Retrieve a particular submission.
Only teachers, students, and applications with application permissions can perform this operation.
A submission object represents a student's work for an assignment.
Resources associated with the submission represent this work.
Only the assignedTo student can see and modify the submission.
A teacher or application with application permissions has full access to all submissions.
The grade and feedback from a teacher are part of the educationOutcome associated with this object.
Only teachers or applications with application permissions can add or change grades and feedback.
Students will not see the grade or feedback until the assignment has been released.
Provide the header Prefer: include-unknown-enum-members to properly list submissions with the reassigned status.
For details, see the examples section.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignmentSubmissionCount](Get-MgBetaEducationUserAssignmentSubmissionCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentSubmissionOutcome](Get-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgBetaEducationUserAssignmentSubmissionOutcomeCount](Get-MgBetaEducationUserAssignmentSubmissionOutcomeCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentSubmissionResource](Get-MgBetaEducationUserAssignmentSubmissionResource.md)
Retrieve the properties of a specific resource associated with a submission.
Only teachers, students, and applications with application permissions can perform this operation.
This resource is in the 'working' resource list and should be considered work in process by a student.
This resource is wrapped with a possible pointer back to the assignment resource if it was copied from the assignment.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserAssignmentSubmissionResourceCount](Get-MgBetaEducationUserAssignmentSubmissionResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentSubmissionResourceDependentResource](Get-MgBetaEducationUserAssignmentSubmissionResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationUserAssignmentSubmissionResourceDependentResourceCount](Get-MgBetaEducationUserAssignmentSubmissionResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentSubmissionSubmittedResource](Get-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgBetaEducationUserAssignmentSubmissionSubmittedResourceCount](Get-MgBetaEducationUserAssignmentSubmissionSubmittedResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource](Get-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource.md)
Get dependentResources from education

### [Get-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResourceCount](Get-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResourceCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserClass](Get-MgBetaEducationUserClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgBetaEducationUserClassCount](Get-MgBetaEducationUserClassCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserCount](Get-MgBetaEducationUserCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserDelta](Get-MgBetaEducationUserDelta.md)
Invoke function delta

### [Get-MgBetaEducationUserMailboxSetting](Get-MgBetaEducationUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaEducationUserRubric](Get-MgBetaEducationUserRubric.md)
Retrieve the properties and relationships of an educationRubric object.
Only teachers and students can perform this operation.
This API is available in the following national cloud deployments.

### [Get-MgBetaEducationUserRubricCount](Get-MgBetaEducationUserRubricCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserSchool](Get-MgBetaEducationUserSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgBetaEducationUserSchoolCount](Get-MgBetaEducationUserSchoolCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserServiceProvisioningError](Get-MgBetaEducationUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaEducationUserServiceProvisioningErrorCount](Get-MgBetaEducationUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaEducationUserTaughtClass](Get-MgBetaEducationUserTaughtClass.md)
Classes for which the user is a teacher.

### [Get-MgBetaEducationUserTaughtClassCount](Get-MgBetaEducationUserTaughtClassCount.md)
Get the number of the resource

### [Initialize-MgBetaEducationClassAssignment](Initialize-MgBetaEducationClassAssignment.md)
Activate an inactive educationAssignment to signal that the assignment has further action items for teachers and students.
This action can only be performed by a teacher on currently inactive assignments.
This API is available in the following national cloud deployments.

### [Initialize-MgBetaEducationMeAssignment](Initialize-MgBetaEducationMeAssignment.md)
Activate an inactive educationAssignment to signal that the assignment has further action items for teachers and students.
This action can only be performed by a teacher on currently inactive assignments.
This API is available in the following national cloud deployments.

### [Initialize-MgBetaEducationUserAssignment](Initialize-MgBetaEducationUserAssignment.md)
Activate an inactive educationAssignment to signal that the assignment has further action items for teachers and students.
This action can only be performed by a teacher on currently inactive assignments.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaDeactivateEducationClassAssignment](Invoke-MgBetaDeactivateEducationClassAssignment.md)
Mark an assigned educationAssignment as inactive to signal that the assignment has no further action items for teachers and students.
This action can only be performed by a teacher on assigned assignments.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaDeactivateEducationMeAssignment](Invoke-MgBetaDeactivateEducationMeAssignment.md)
Mark an assigned educationAssignment as inactive to signal that the assignment has no further action items for teachers and students.
This action can only be performed by a teacher on assigned assignments.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaDeactivateEducationUserAssignment](Invoke-MgBetaDeactivateEducationUserAssignment.md)
Mark an assigned educationAssignment as inactive to signal that the assignment has no further action items for teachers and students.
This action can only be performed by a teacher on assigned assignments.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaPinEducationClassModule](Invoke-MgBetaPinEducationClassModule.md)
Pin an educationModule in the class work list.
This action sets the isPinned property to true for an educationModule.
Only teachers can perform this action and only one module at a time can be pinned in the class work list.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReassignEducationClassAssignmentSubmission](Invoke-MgBetaReassignEducationClassAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the Prefer: include-unknown-enum-members header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the reassigned status will be mapped to the returned status, and reassignedDateTime and reassignedBy properties will be mapped to returnedDateTime and returnedBy respectively.
If the header Prefer: include-unknown-enum-members is provided, a reassigned submission retains the reassigned status.
For details, see the examples section.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReassignEducationMeAssignmentSubmission](Invoke-MgBetaReassignEducationMeAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the Prefer: include-unknown-enum-members header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the reassigned status will be mapped to the returned status, and reassignedDateTime and reassignedBy properties will be mapped to returnedDateTime and returnedBy respectively.
If the header Prefer: include-unknown-enum-members is provided, a reassigned submission retains the reassigned status.
For details, see the examples section.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReassignEducationUserAssignmentSubmission](Invoke-MgBetaReassignEducationUserAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the Prefer: include-unknown-enum-members header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the reassigned status will be mapped to the returned status, and reassignedDateTime and reassignedBy properties will be mapped to returnedDateTime and returnedBy respectively.
If the header Prefer: include-unknown-enum-members is provided, a reassigned submission retains the reassigned status.
For details, see the examples section.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReturnEducationClassAssignmentSubmission](Invoke-MgBetaReturnEducationClassAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReturnEducationMeAssignmentSubmission](Invoke-MgBetaReturnEducationMeAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReturnEducationUserAssignmentSubmission](Invoke-MgBetaReturnEducationUserAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUnpinEducationClassModule](Invoke-MgBetaUnpinEducationClassModule.md)
Unpin an educationModule in the classwork list.
This action sets the isPinned property to false for an educationModule.
Only teachers in the class can perform this operation.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUnsubmitEducationClassAssignmentSubmission](Invoke-MgBetaUnsubmitEducationClassAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from submitted to working.
During the submit process, all the resources are copied from submittedResources to  workingResources.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUnsubmitEducationMeAssignmentSubmission](Invoke-MgBetaUnsubmitEducationMeAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from submitted to working.
During the submit process, all the resources are copied from submittedResources to  workingResources.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUnsubmitEducationUserAssignmentSubmission](Invoke-MgBetaUnsubmitEducationUserAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from submitted to working.
During the submit process, all the resources are copied from submittedResources to  workingResources.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUploadEducationSynchronizationProfileUrl](Invoke-MgBetaUploadEducationSynchronizationProfileUrl.md)
Invoke function uploadUrl

### [New-MgBetaEducationClass](New-MgBetaEducationClass.md)
Create a new class.
This will also create a universal group.
When you use this API to create a class, it will add special properties to the group, which will\nadd features such as assignments and special handling within Microsoft Teams when teams are created using the group.
Please note that this API only creates the universal group and does not create a team.
Microsoft Teams provides a user interface for teachers to create teams for their own classes using the groups created by this API.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassAssignment](New-MgBetaEducationClassAssignment.md)
Create a new assignment.
Only teachers in a class can create an assignment.
Assignments start in the Draft state, which means that students will not see the assignment until publication.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassAssignmentCategory](New-MgBetaEducationClassAssignmentCategory.md)
Create a new educationCategory on an educationClass.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassAssignmentCategoryByRef](New-MgBetaEducationClassAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgBetaEducationClassAssignmentResource](New-MgBetaEducationClassAssignmentResource.md)
Create an assignment resource.
Only teachers can perform this operation.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassAssignmentResourceDependentResource](New-MgBetaEducationClassAssignmentResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationClassAssignmentSettingGradingCategory](New-MgBetaEducationClassAssignmentSettingGradingCategory.md)
Create new navigation property to gradingCategories for education

### [New-MgBetaEducationClassAssignmentSubmission](New-MgBetaEducationClassAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgBetaEducationClassAssignmentSubmissionOutcome](New-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the POST request will fail.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassAssignmentSubmissionResource](New-MgBetaEducationClassAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only teachers and students can perform this operation.
The operation will not succeed if the allowStudentsToAddResources flag is not set to true.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassAssignmentSubmissionResourceDependentResource](New-MgBetaEducationClassAssignmentSubmissionResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationClassAssignmentSubmissionSubmittedResource](New-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource](New-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationClassMemberByRef](New-MgBetaEducationClassMemberByRef.md)
Add an educationUser member to an educationClass.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassModule](New-MgBetaEducationClassModule.md)
Create a new module in a class.
Only teachers in a class can create a module.
Modules start in the draft state, which means that students won't see the modules until publication.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassModuleResource](New-MgBetaEducationClassModuleResource.md)
Create a resource in a module.
Only teachers can perform this operation.
You can create the following types of module resources: Every resource has an @odata.type property to indicate which type of resource is being created.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationClassTeacherByRef](New-MgBetaEducationClassTeacherByRef.md)
Add a teacher to a class.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationMeAssignment](New-MgBetaEducationMeAssignment.md)
Create new navigation property to assignments for education

### [New-MgBetaEducationMeAssignmentCategory](New-MgBetaEducationMeAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgBetaEducationMeAssignmentCategoryByRef](New-MgBetaEducationMeAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgBetaEducationMeAssignmentResource](New-MgBetaEducationMeAssignmentResource.md)
Create an assignment resource.
Only teachers can perform this operation.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationMeAssignmentResourceDependentResource](New-MgBetaEducationMeAssignmentResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationMeAssignmentSubmission](New-MgBetaEducationMeAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgBetaEducationMeAssignmentSubmissionOutcome](New-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the POST request will fail.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationMeAssignmentSubmissionResource](New-MgBetaEducationMeAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only teachers and students can perform this operation.
The operation will not succeed if the allowStudentsToAddResources flag is not set to true.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationMeAssignmentSubmissionResourceDependentResource](New-MgBetaEducationMeAssignmentSubmissionResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationMeAssignmentSubmissionSubmittedResource](New-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource](New-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationMeRubric](New-MgBetaEducationMeRubric.md)
Create a new educationRubric object.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationSchool](New-MgBetaEducationSchool.md)
Create a school.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationSchoolClassByRef](New-MgBetaEducationSchoolClassByRef.md)
Add a class to a school.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationSchoolUserByRef](New-MgBetaEducationSchoolUserByRef.md)
Add a user to a school.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationSynchronizationProfile](New-MgBetaEducationSynchronizationProfile.md)
Create new navigation property to synchronizationProfiles for education

### [New-MgBetaEducationSynchronizationProfileError](New-MgBetaEducationSynchronizationProfileError.md)
Create new navigation property to errors for education

### [New-MgBetaEducationUser](New-MgBetaEducationUser.md)
Create a new user.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationUserAssignment](New-MgBetaEducationUserAssignment.md)
Create new navigation property to assignments for education

### [New-MgBetaEducationUserAssignmentCategory](New-MgBetaEducationUserAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgBetaEducationUserAssignmentCategoryByRef](New-MgBetaEducationUserAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgBetaEducationUserAssignmentResource](New-MgBetaEducationUserAssignmentResource.md)
Create an assignment resource.
Only teachers can perform this operation.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationUserAssignmentResourceDependentResource](New-MgBetaEducationUserAssignmentResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationUserAssignmentSubmission](New-MgBetaEducationUserAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgBetaEducationUserAssignmentSubmissionOutcome](New-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the POST request will fail.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationUserAssignmentSubmissionResource](New-MgBetaEducationUserAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only teachers and students can perform this operation.
The operation will not succeed if the allowStudentsToAddResources flag is not set to true.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.
This API is available in the following national cloud deployments.

### [New-MgBetaEducationUserAssignmentSubmissionResourceDependentResource](New-MgBetaEducationUserAssignmentSubmissionResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationUserAssignmentSubmissionSubmittedResource](New-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource](New-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource.md)
Create new navigation property to dependentResources for education

### [New-MgBetaEducationUserRubric](New-MgBetaEducationUserRubric.md)
Create a new educationRubric object.
This API is available in the following national cloud deployments.

### [Publish-MgBetaEducationClassAssignment](Publish-MgBetaEducationClassAssignment.md)
Change the state of an educationAssignment from its original draft status to the published status.
You can change the state from draft to scheduled if the assignment is scheduled for a future date.
Only a teacher in the class can make this call.
When an assignment is in draft status, students will not see the assignment, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the assignment goes back to draft if there is any backend failure during publish process.
To update the properties of a published assignment, see update an assignment.
To update the properties of a published assignment, see update an assignment.
This API is available in the following national cloud deployments.

### [Publish-MgBetaEducationClassModule](Publish-MgBetaEducationClassModule.md)
Change the state of an educationModule from its original draft status to the published status.
Only teachers in the class can perform this operation.
When a module is in draft status, students won't see the module.
When you call this API, the module appears in the student's class work list.
This API is available in the following national cloud deployments.

### [Publish-MgBetaEducationMeAssignment](Publish-MgBetaEducationMeAssignment.md)
Change the state of an educationAssignment from its original draft status to the published status.
You can change the state from draft to scheduled if the assignment is scheduled for a future date.
Only a teacher in the class can make this call.
When an assignment is in draft status, students will not see the assignment, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the assignment goes back to draft if there is any backend failure during publish process.
To update the properties of a published assignment, see update an assignment.
To update the properties of a published assignment, see update an assignment.
This API is available in the following national cloud deployments.

### [Publish-MgBetaEducationUserAssignment](Publish-MgBetaEducationUserAssignment.md)
Change the state of an educationAssignment from its original draft status to the published status.
You can change the state from draft to scheduled if the assignment is scheduled for a future date.
Only a teacher in the class can make this call.
When an assignment is in draft status, students will not see the assignment, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the assignment goes back to draft if there is any backend failure during publish process.
To update the properties of a published assignment, see update an assignment.
To update the properties of a published assignment, see update an assignment.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClass](Remove-MgBetaEducationClass.md)
Delete an educationClass.
Because a class is also a universal group, deleting a class deletes the group.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignment](Remove-MgBetaEducationClassAssignment.md)
Delete an existing assignment.
Only teachers within a class can delete assignments.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignmentCategory](Remove-MgBetaEducationClassAssignmentCategory.md)
Delete an existing category.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignmentCategoryByRef](Remove-MgBetaEducationClassAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgBetaEducationClassAssignmentDefault](Remove-MgBetaEducationClassAssignmentDefault.md)
Delete navigation property assignmentDefaults for education

### [Remove-MgBetaEducationClassAssignmentGradingCategory](Remove-MgBetaEducationClassAssignmentGradingCategory.md)
Remove a gradingCategory from an educationAssignment.
Only teachers can perform this operation.

### [Remove-MgBetaEducationClassAssignmentResource](Remove-MgBetaEducationClassAssignmentResource.md)
Delete a specific educationAssignmentResource attached to an assignment.
Only teachers in the class can remove a resource.
After an assignment has been published to students, teachers can't remove resources that are marked as 'distributeToStudents'.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignmentResourceDependentResource](Remove-MgBetaEducationClassAssignmentResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationClassAssignmentRubric](Remove-MgBetaEducationClassAssignmentRubric.md)
Delete an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignmentRubricByRef](Remove-MgBetaEducationClassAssignmentRubricByRef.md)
Delete an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignmentSetting](Remove-MgBetaEducationClassAssignmentSetting.md)
Delete navigation property assignmentSettings for education

### [Remove-MgBetaEducationClassAssignmentSettingGradingCategory](Remove-MgBetaEducationClassAssignmentSettingGradingCategory.md)
Delete navigation property gradingCategories for education

### [Remove-MgBetaEducationClassAssignmentSubmission](Remove-MgBetaEducationClassAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgBetaEducationClassAssignmentSubmissionOutcome](Remove-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Delete a feedback resource from a submission.
This can only be done by a teacher.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignmentSubmissionResource](Remove-MgBetaEducationClassAssignmentSubmissionResource.md)
Delete an educationSubmissionResource from the submission.
Only teachers and students can perform this operation.
If the resource was copied from the assignment, a new copy of the resource will be created after the current copy is deleted.
This allows you to 'reset' the resource to its original state.
If the resource wasn't copied from the assignment but was added from the student, the resource is deleted.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassAssignmentSubmissionResourceDependentResource](Remove-MgBetaEducationClassAssignmentSubmissionResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationClassAssignmentSubmissionSubmittedResource](Remove-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource](Remove-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationClassMemberByRef](Remove-MgBetaEducationClassMemberByRef.md)
Remove an educationUser from an educationClass.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassModule](Remove-MgBetaEducationClassModule.md)
Delete an existing module in a class.
Only teachers within a class can delete modules.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassModuleResource](Remove-MgBetaEducationClassModuleResource.md)
Delete a specific educationModuleResource attached to a module.
Only teachers in the class can remove a resource.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationClassTeacherByRef](Remove-MgBetaEducationClassTeacherByRef.md)
Remove a teacher from an educationClass.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationMe](Remove-MgBetaEducationMe.md)
Delete navigation property me for education

### [Remove-MgBetaEducationMeAssignment](Remove-MgBetaEducationMeAssignment.md)
Delete navigation property assignments for education

### [Remove-MgBetaEducationMeAssignmentCategoryByRef](Remove-MgBetaEducationMeAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgBetaEducationMeAssignmentGradingCategory](Remove-MgBetaEducationMeAssignmentGradingCategory.md)
Remove a gradingCategory from an educationAssignment.
Only teachers can perform this operation.

### [Remove-MgBetaEducationMeAssignmentResource](Remove-MgBetaEducationMeAssignmentResource.md)
Delete a specific educationAssignmentResource attached to an assignment.
Only teachers in the class can remove a resource.
After an assignment has been published to students, teachers can't remove resources that are marked as 'distributeToStudents'.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationMeAssignmentResourceDependentResource](Remove-MgBetaEducationMeAssignmentResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationMeAssignmentRubric](Remove-MgBetaEducationMeAssignmentRubric.md)
Delete an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationMeAssignmentRubricByRef](Remove-MgBetaEducationMeAssignmentRubricByRef.md)
Delete an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationMeAssignmentSubmission](Remove-MgBetaEducationMeAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgBetaEducationMeAssignmentSubmissionOutcome](Remove-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Delete a feedback resource from a submission.
This can only be done by a teacher.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationMeAssignmentSubmissionResource](Remove-MgBetaEducationMeAssignmentSubmissionResource.md)
Delete an educationSubmissionResource from the submission.
Only teachers and students can perform this operation.
If the resource was copied from the assignment, a new copy of the resource will be created after the current copy is deleted.
This allows you to 'reset' the resource to its original state.
If the resource wasn't copied from the assignment but was added from the student, the resource is deleted.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationMeAssignmentSubmissionResourceDependentResource](Remove-MgBetaEducationMeAssignmentSubmissionResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationMeAssignmentSubmissionSubmittedResource](Remove-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource](Remove-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationMeRubric](Remove-MgBetaEducationMeRubric.md)
Delete an educationRubric object.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationSchool](Remove-MgBetaEducationSchool.md)
Delete a school.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationSchoolClassByRef](Remove-MgBetaEducationSchoolClassByRef.md)
Delete a class from a school.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationSchoolUserByRef](Remove-MgBetaEducationSchoolUserByRef.md)
Delete a user from a school.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationSynchronizationProfile](Remove-MgBetaEducationSynchronizationProfile.md)
Delete a school data synchronization profile in the tenant based on the identifier.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationSynchronizationProfileError](Remove-MgBetaEducationSynchronizationProfileError.md)
Delete navigation property errors for education

### [Remove-MgBetaEducationSynchronizationProfileStatus](Remove-MgBetaEducationSynchronizationProfileStatus.md)
Delete navigation property profileStatus for education

### [Remove-MgBetaEducationUser](Remove-MgBetaEducationUser.md)
Delete a user.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationUserAssignment](Remove-MgBetaEducationUserAssignment.md)
Delete navigation property assignments for education

### [Remove-MgBetaEducationUserAssignmentCategoryByRef](Remove-MgBetaEducationUserAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgBetaEducationUserAssignmentGradingCategory](Remove-MgBetaEducationUserAssignmentGradingCategory.md)
Remove a gradingCategory from an educationAssignment.
Only teachers can perform this operation.

### [Remove-MgBetaEducationUserAssignmentResource](Remove-MgBetaEducationUserAssignmentResource.md)
Delete a specific educationAssignmentResource attached to an assignment.
Only teachers in the class can remove a resource.
After an assignment has been published to students, teachers can't remove resources that are marked as 'distributeToStudents'.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationUserAssignmentResourceDependentResource](Remove-MgBetaEducationUserAssignmentResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationUserAssignmentRubric](Remove-MgBetaEducationUserAssignmentRubric.md)
Delete an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationUserAssignmentRubricByRef](Remove-MgBetaEducationUserAssignmentRubricByRef.md)
Delete an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationUserAssignmentSubmission](Remove-MgBetaEducationUserAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgBetaEducationUserAssignmentSubmissionOutcome](Remove-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Delete a feedback resource from a submission.
This can only be done by a teacher.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationUserAssignmentSubmissionResource](Remove-MgBetaEducationUserAssignmentSubmissionResource.md)
Delete an educationSubmissionResource from the submission.
Only teachers and students can perform this operation.
If the resource was copied from the assignment, a new copy of the resource will be created after the current copy is deleted.
This allows you to 'reset' the resource to its original state.
If the resource wasn't copied from the assignment but was added from the student, the resource is deleted.
This API is available in the following national cloud deployments.

### [Remove-MgBetaEducationUserAssignmentSubmissionResourceDependentResource](Remove-MgBetaEducationUserAssignmentSubmissionResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationUserAssignmentSubmissionSubmittedResource](Remove-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource](Remove-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource.md)
Delete navigation property dependentResources for education

### [Remove-MgBetaEducationUserRubric](Remove-MgBetaEducationUserRubric.md)
Delete an educationRubric object.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Reset-MgBetaEducationSynchronizationProfile](Reset-MgBetaEducationSynchronizationProfile.md)
Reset the sync of a specific school data synchronization profile in the tenant.
This API is available in the following national cloud deployments.

### [Resume-MgBetaEducationSynchronizationProfile](Resume-MgBetaEducationSynchronizationProfile.md)
Resume the sync of a specific school data synchronization profile in the tenant.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationClassAssignmentRubricByRef](Set-MgBetaEducationClassAssignmentRubricByRef.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationClassAssignmentSubmissionUpResourceFolder](Set-MgBetaEducationClassAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Only teachers and students can perform this operation.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationClassAssignmentUpFeedbackResourceFolder](Set-MgBetaEducationClassAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
Only teachers can perform this operation.
The teacher determines the resources to upload in the feedback resources folder of a submission.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationClassAssignmentUpResourceFolder](Set-MgBetaEducationClassAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
Only teachers can perform this operation.
The teacher determines the resources to upload in the assignment's folder.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationClassModuleUpResourceFolder](Set-MgBetaEducationClassModuleUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationModule.
Only teachers can perform this operation.
The teacher determines what resources to upload to the SharePoint folder for the module.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationMeAssignmentRubricByRef](Set-MgBetaEducationMeAssignmentRubricByRef.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationMeAssignmentSubmissionUpResourceFolder](Set-MgBetaEducationMeAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Only teachers and students can perform this operation.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationMeAssignmentUpFeedbackResourceFolder](Set-MgBetaEducationMeAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
Only teachers can perform this operation.
The teacher determines the resources to upload in the feedback resources folder of a submission.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationMeAssignmentUpResourceFolder](Set-MgBetaEducationMeAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
Only teachers can perform this operation.
The teacher determines the resources to upload in the assignment's folder.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationUserAssignmentRubricByRef](Set-MgBetaEducationUserAssignmentRubricByRef.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationUserAssignmentSubmissionUpResourceFolder](Set-MgBetaEducationUserAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Only teachers and students can perform this operation.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationUserAssignmentUpFeedbackResourceFolder](Set-MgBetaEducationUserAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
Only teachers can perform this operation.
The teacher determines the resources to upload in the feedback resources folder of a submission.
This API is available in the following national cloud deployments.

### [Set-MgBetaEducationUserAssignmentUpResourceFolder](Set-MgBetaEducationUserAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
Only teachers can perform this operation.
The teacher determines the resources to upload in the assignment's folder.
This API is available in the following national cloud deployments.

### [Start-MgBetaEducationSynchronizationProfile](Start-MgBetaEducationSynchronizationProfile.md)
Verify the files uploaded to a specific school data synchronization profile in the tenant.
If the verification is successful, synchronization starts on the profile.
Otherwise, the response contains errors and warnings.
If the response contains errors, the synchronization won't start.
If the response contains only warnings, synchronization starts.
This API is available in the following national cloud deployments.

### [Submit-MgBetaEducationClassAssignmentSubmission](Submit-MgBetaEducationClassAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from working to submitted.
During the submit process, all the resources are copied to the submittedResources bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.
This API is available in the following national cloud deployments.

### [Submit-MgBetaEducationMeAssignmentSubmission](Submit-MgBetaEducationMeAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from working to submitted.
During the submit process, all the resources are copied to the submittedResources bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.
This API is available in the following national cloud deployments.

### [Submit-MgBetaEducationUserAssignmentSubmission](Submit-MgBetaEducationUserAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from working to submitted.
During the submit process, all the resources are copied to the submittedResources bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.
This API is available in the following national cloud deployments.

### [Suspend-MgBetaEducationSynchronizationProfile](Suspend-MgBetaEducationSynchronizationProfile.md)
Pause the sync of a specific school data synchronization profile in the tenant.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClass](Update-MgBetaEducationClass.md)
Update the properties of a class.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClassAssignment](Update-MgBetaEducationClassAssignment.md)
Update an educationAssignment object.
Only teachers in the class can do this.
You can't use a PATCH request to change the status of an assignment.
Use the publish action to change the assignment status.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClassAssignmentCategory](Update-MgBetaEducationClassAssignmentCategory.md)
Update the navigation property assignmentCategories in education

### [Update-MgBetaEducationClassAssignmentDefault](Update-MgBetaEducationClassAssignmentDefault.md)
Update the properties of an educationAssignmentDefaults object.
Only teachers can update these settings.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClassAssignmentResource](Update-MgBetaEducationClassAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationClassAssignmentResourceDependentResource](Update-MgBetaEducationClassAssignmentResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationClassAssignmentRubric](Update-MgBetaEducationClassAssignmentRubric.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClassAssignmentSetting](Update-MgBetaEducationClassAssignmentSetting.md)
Update the properties of an educationAssignmentSettings object.
Only teachers can update these settings.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClassAssignmentSettingGradingCategory](Update-MgBetaEducationClassAssignmentSettingGradingCategory.md)
Update the navigation property gradingCategories in education

### [Update-MgBetaEducationClassAssignmentSubmission](Update-MgBetaEducationClassAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgBetaEducationClassAssignmentSubmissionOutcome](Update-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Update the properties of an educationOutcome object.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClassAssignmentSubmissionResource](Update-MgBetaEducationClassAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationClassAssignmentSubmissionResourceDependentResource](Update-MgBetaEducationClassAssignmentSubmissionResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationClassAssignmentSubmissionSubmittedResource](Update-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource](Update-MgBetaEducationClassAssignmentSubmissionSubmittedResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationClassModule](Update-MgBetaEducationClassModule.md)
Update an educationModule object in a class.
Only teachers in the class can perform this operation.
Note that you can't use a PATCH request to change the status of a module.
Use the publish action to change the module status.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationClassModuleResource](Update-MgBetaEducationClassModuleResource.md)
Update a resource in a module.
Only teachers can perform this operation.
The only one property that can be updated is displayName, for all resource types.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationMe](Update-MgBetaEducationMe.md)
Update the navigation property me in education

### [Update-MgBetaEducationMeAssignment](Update-MgBetaEducationMeAssignment.md)
Update the navigation property assignments in education

### [Update-MgBetaEducationMeAssignmentResource](Update-MgBetaEducationMeAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationMeAssignmentResourceDependentResource](Update-MgBetaEducationMeAssignmentResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationMeAssignmentRubric](Update-MgBetaEducationMeAssignmentRubric.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationMeAssignmentSubmission](Update-MgBetaEducationMeAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgBetaEducationMeAssignmentSubmissionOutcome](Update-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Update the properties of an educationOutcome object.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationMeAssignmentSubmissionResource](Update-MgBetaEducationMeAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationMeAssignmentSubmissionResourceDependentResource](Update-MgBetaEducationMeAssignmentSubmissionResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationMeAssignmentSubmissionSubmittedResource](Update-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource](Update-MgBetaEducationMeAssignmentSubmissionSubmittedResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationMeRubric](Update-MgBetaEducationMeRubric.md)
Update the properties of an educationRubric object.
Only teachers can perform this operation.
Updating a rubric attached to an assignment (PATCH /education/classes/{id}/assignments/{id}/rubric) is only possible before the assignment is published, and what is updated is actually the original rubric that exists under /education/users/{id}/rubrics.
After the assignment is published, an immutable copy of the rubric is made that is attached to that specific assignment.
That rubric can be retrieved using GET /education/classes/{id}/assignments/{id}/rubric, but it cannot be updated.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationMeUserMailboxSetting](Update-MgBetaEducationMeUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaEducationRoot](Update-MgBetaEducationRoot.md)
Update education

### [Update-MgBetaEducationSchool](Update-MgBetaEducationSchool.md)
Update the properties of a school object.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationSchoolAdministrativeUnit](Update-MgBetaEducationSchoolAdministrativeUnit.md)
Update the navigation property administrativeUnit in education

### [Update-MgBetaEducationSynchronizationProfile](Update-MgBetaEducationSynchronizationProfile.md)
Update the navigation property synchronizationProfiles in education

### [Update-MgBetaEducationSynchronizationProfileError](Update-MgBetaEducationSynchronizationProfileError.md)
Update the navigation property errors in education

### [Update-MgBetaEducationSynchronizationProfileStatus](Update-MgBetaEducationSynchronizationProfileStatus.md)
Update the navigation property profileStatus in education

### [Update-MgBetaEducationUser](Update-MgBetaEducationUser.md)
Update the relatedContact collection of an educationUser object.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationUserAssignment](Update-MgBetaEducationUserAssignment.md)
Update the navigation property assignments in education

### [Update-MgBetaEducationUserAssignmentResource](Update-MgBetaEducationUserAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationUserAssignmentResourceDependentResource](Update-MgBetaEducationUserAssignmentResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationUserAssignmentRubric](Update-MgBetaEducationUserAssignmentRubric.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationUserAssignmentSubmission](Update-MgBetaEducationUserAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgBetaEducationUserAssignmentSubmissionOutcome](Update-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Update the properties of an educationOutcome object.
Only teachers can perform this operation.
This API is available in the following national cloud deployments.

### [Update-MgBetaEducationUserAssignmentSubmissionResource](Update-MgBetaEducationUserAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationUserAssignmentSubmissionResourceDependentResource](Update-MgBetaEducationUserAssignmentSubmissionResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationUserAssignmentSubmissionSubmittedResource](Update-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource](Update-MgBetaEducationUserAssignmentSubmissionSubmittedResourceDependentResource.md)
Update the navigation property dependentResources in education

### [Update-MgBetaEducationUserMailboxSetting](Update-MgBetaEducationUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaEducationUserRubric](Update-MgBetaEducationUserRubric.md)
Update the properties of an educationRubric object.
Only teachers can perform this operation.
Updating a rubric attached to an assignment (PATCH /education/classes/{id}/assignments/{id}/rubric) is only possible before the assignment is published, and what is updated is actually the original rubric that exists under /education/users/{id}/rubrics.
After the assignment is published, an immutable copy of the rubric is made that is attached to that specific assignment.
That rubric can be retrieved using GET /education/classes/{id}/assignments/{id}/rubric, but it cannot be updated.
This API is available in the following national cloud deployments.

