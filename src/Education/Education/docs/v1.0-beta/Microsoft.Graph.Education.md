---
Module Name: Microsoft.Graph.Beta.Education
Module Guid: 8325acfb-9fef-4a9f-bd1f-d1c3fa85414c
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.education
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Education Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Education Cmdlets
### [Get-MgBetaEducationClass](Get-MgBetaEducationClass.md)
Get classes from education

### [Get-MgBetaEducationClassAssignment](Get-MgBetaEducationClassAssignment.md)
All assignments associated with this class.
Nullable.

### [Get-MgBetaEducationClassAssignmentCategory](Get-MgBetaEducationClassAssignmentCategory.md)
All categories associated with this class.
Nullable.

### [Get-MgBetaEducationClassAssignmentCategoryByRef](Get-MgBetaEducationClassAssignmentCategoryByRef.md)
List all the categories associated with an assignment.

### [Get-MgBetaEducationClassAssignmentCategoryDelta](Get-MgBetaEducationClassAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgBetaEducationClassAssignmentDefault](Get-MgBetaEducationClassAssignmentDefault.md)
Read the properties and relationships of an educationAssignmentDefaults object.
These are the class-level assignment defaults respected by new assignments created in the class.
Callers can continue to specify custom values on each **assignment** creation if they don't want the default behaviors.

### [Get-MgBetaEducationClassAssignmentDelta](Get-MgBetaEducationClassAssignmentDelta.md)
Invoke function delta

### [Get-MgBetaEducationClassAssignmentResource](Get-MgBetaEducationClassAssignmentResource.md)
Learning objects that are associated with this assignment.
Only teachers can modify this list.
Nullable.

### [Get-MgBetaEducationClassAssignmentRubric](Get-MgBetaEducationClassAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgBetaEducationClassAssignmentRubricByRef](Get-MgBetaEducationClassAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgBetaEducationClassAssignmentSetting](Get-MgBetaEducationClassAssignmentSetting.md)
Read the properties and relationships of an educationAssignmentSettings object.

### [Get-MgBetaEducationClassAssignmentSubmission](Get-MgBetaEducationClassAssignmentSubmission.md)
Once published, there is a submission object for each student representing their work and grade.
Read-only.
Nullable.

### [Get-MgBetaEducationClassAssignmentSubmissionOutcome](Get-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgBetaEducationClassAssignmentSubmissionResource](Get-MgBetaEducationClassAssignmentSubmissionResource.md)
Get resources from education

### [Get-MgBetaEducationClassAssignmentSubmissionSubmittedResource](Get-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgBetaEducationClassDelta](Get-MgBetaEducationClassDelta.md)
Invoke function delta

### [Get-MgBetaEducationClassGroup](Get-MgBetaEducationClassGroup.md)
Retrieve the Microsoft 365 **group** that corresponds to this **educationClass**.

### [Get-MgBetaEducationClassMember](Get-MgBetaEducationClassMember.md)
Retrieves the teachers and students for a class.
Note that if the delegated token is used, members can only be seen by other members of the class.

### [Get-MgBetaEducationClassMemberByRef](Get-MgBetaEducationClassMemberByRef.md)
Retrieves the teachers and students for a class.
Note that if the delegated token is used, members can only be seen by other members of the class.

### [Get-MgBetaEducationClassSchool](Get-MgBetaEducationClassSchool.md)
All schools that this class is associated with.
Nullable.

### [Get-MgBetaEducationClassTeacher](Get-MgBetaEducationClassTeacher.md)
Retrieve a list teachers for a class.
Delegated tokens must be members of the class to get the teacher list.

### [Get-MgBetaEducationClassTeacherByRef](Get-MgBetaEducationClassTeacherByRef.md)
Retrieve a list teachers for a class.
Delegated tokens must be members of the class to get the teacher list.

### [Get-MgBetaEducationMe](Get-MgBetaEducationMe.md)
Get me from education

### [Get-MgBetaEducationMeAssignment](Get-MgBetaEducationMeAssignment.md)
List of assignments for the user.
Nullable.

### [Get-MgBetaEducationMeAssignmentCategory](Get-MgBetaEducationMeAssignmentCategory.md)
List all the categories associated with an assignment.

### [Get-MgBetaEducationMeAssignmentCategoryByRef](Get-MgBetaEducationMeAssignmentCategoryByRef.md)
List all the categories associated with an assignment.

### [Get-MgBetaEducationMeAssignmentCategoryDelta](Get-MgBetaEducationMeAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgBetaEducationMeAssignmentDelta](Get-MgBetaEducationMeAssignmentDelta.md)
Invoke function delta

### [Get-MgBetaEducationMeAssignmentResource](Get-MgBetaEducationMeAssignmentResource.md)
Learning objects that are associated with this assignment.
Only teachers can modify this list.
Nullable.

### [Get-MgBetaEducationMeAssignmentRubric](Get-MgBetaEducationMeAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgBetaEducationMeAssignmentRubricByRef](Get-MgBetaEducationMeAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgBetaEducationMeAssignmentSubmission](Get-MgBetaEducationMeAssignmentSubmission.md)
Once published, there is a submission object for each student representing their work and grade.
Read-only.
Nullable.

### [Get-MgBetaEducationMeAssignmentSubmissionOutcome](Get-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgBetaEducationMeAssignmentSubmissionResource](Get-MgBetaEducationMeAssignmentSubmissionResource.md)
Get resources from education

### [Get-MgBetaEducationMeAssignmentSubmissionSubmittedResource](Get-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgBetaEducationMeClass](Get-MgBetaEducationMeClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgBetaEducationMeRubric](Get-MgBetaEducationMeRubric.md)
When set, the grading rubric attached to the assignment.

### [Get-MgBetaEducationMeSchool](Get-MgBetaEducationMeSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgBetaEducationMeTaughtClass](Get-MgBetaEducationMeTaughtClass.md)
Classes for which the user is a teacher.

### [Get-MgBetaEducationMeUser](Get-MgBetaEducationMeUser.md)
Retrieve the simple directory **user** that corresponds to this **educationUser**.

### [Get-MgBetaEducationRoot](Get-MgBetaEducationRoot.md)
Get education

### [Get-MgBetaEducationSchool](Get-MgBetaEducationSchool.md)
Get schools from education

### [Get-MgBetaEducationSchoolAdministrativeUnit](Get-MgBetaEducationSchoolAdministrativeUnit.md)
Retrieve the simple directory **administrativeUnit** that corresponds to this **educationSchool**.

### [Get-MgBetaEducationSchoolClass](Get-MgBetaEducationSchoolClass.md)
Retrieve a list of classes owned by a school.

### [Get-MgBetaEducationSchoolClassByRef](Get-MgBetaEducationSchoolClassByRef.md)
Retrieve a list of classes owned by a school.

### [Get-MgBetaEducationSchoolDelta](Get-MgBetaEducationSchoolDelta.md)
Invoke function delta

### [Get-MgBetaEducationSchoolUser](Get-MgBetaEducationSchoolUser.md)
Retrieve a list of users at a school.

### [Get-MgBetaEducationSchoolUserByRef](Get-MgBetaEducationSchoolUserByRef.md)
Retrieve a list of users at a school.

### [Get-MgBetaEducationSynchronizationProfile](Get-MgBetaEducationSynchronizationProfile.md)
Get synchronizationProfiles from education

### [Get-MgBetaEducationSynchronizationProfileError](Get-MgBetaEducationSynchronizationProfileError.md)
All errors associated with this synchronization profile.

### [Get-MgBetaEducationSynchronizationProfileStatus](Get-MgBetaEducationSynchronizationProfileStatus.md)
Get the status of a specific school data synchronization profile in the tenant.
The response will indicate the status of the sync.

### [Get-MgBetaEducationUser](Get-MgBetaEducationUser.md)
Get users from education

### [Get-MgBetaEducationUserAssignment](Get-MgBetaEducationUserAssignment.md)
List of assignments for the user.
Nullable.

### [Get-MgBetaEducationUserAssignmentCategory](Get-MgBetaEducationUserAssignmentCategory.md)
List all the categories associated with an assignment.

### [Get-MgBetaEducationUserAssignmentCategoryByRef](Get-MgBetaEducationUserAssignmentCategoryByRef.md)
List all the categories associated with an assignment.

### [Get-MgBetaEducationUserAssignmentCategoryDelta](Get-MgBetaEducationUserAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgBetaEducationUserAssignmentDelta](Get-MgBetaEducationUserAssignmentDelta.md)
Invoke function delta

### [Get-MgBetaEducationUserAssignmentResource](Get-MgBetaEducationUserAssignmentResource.md)
Learning objects that are associated with this assignment.
Only teachers can modify this list.
Nullable.

### [Get-MgBetaEducationUserAssignmentRubric](Get-MgBetaEducationUserAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgBetaEducationUserAssignmentRubricByRef](Get-MgBetaEducationUserAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgBetaEducationUserAssignmentSubmission](Get-MgBetaEducationUserAssignmentSubmission.md)
Once published, there is a submission object for each student representing their work and grade.
Read-only.
Nullable.

### [Get-MgBetaEducationUserAssignmentSubmissionOutcome](Get-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgBetaEducationUserAssignmentSubmissionResource](Get-MgBetaEducationUserAssignmentSubmissionResource.md)
Get resources from education

### [Get-MgBetaEducationUserAssignmentSubmissionSubmittedResource](Get-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgBetaEducationUserClass](Get-MgBetaEducationUserClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgBetaEducationUserDelta](Get-MgBetaEducationUserDelta.md)
Invoke function delta

### [Get-MgBetaEducationUserRubric](Get-MgBetaEducationUserRubric.md)
When set, the grading rubric attached to the assignment.

### [Get-MgBetaEducationUserSchool](Get-MgBetaEducationUserSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgBetaEducationUserTaughtClass](Get-MgBetaEducationUserTaughtClass.md)
Classes for which the user is a teacher.

### [Invoke-MgBetaReassignEducationClassAssignmentSubmission](Invoke-MgBetaReassignEducationClassAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

### [Invoke-MgBetaReassignEducationMeAssignmentSubmission](Invoke-MgBetaReassignEducationMeAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

### [Invoke-MgBetaReassignEducationUserAssignmentSubmission](Invoke-MgBetaReassignEducationUserAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

### [Invoke-MgBetaReturnEducationClassAssignmentSubmission](Invoke-MgBetaReturnEducationClassAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgBetaReturnEducationMeAssignmentSubmission](Invoke-MgBetaReturnEducationMeAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgBetaReturnEducationUserAssignmentSubmission](Invoke-MgBetaReturnEducationUserAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgBetaUnsubmitEducationClassAssignmentSubmission](Invoke-MgBetaUnsubmitEducationClassAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
This method changes the status of the submission from `submitted` to `working`.
During the submit process, all the resources are copied from **submittedResources** to  **workingResources**.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgBetaUnsubmitEducationMeAssignmentSubmission](Invoke-MgBetaUnsubmitEducationMeAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
This method changes the status of the submission from `submitted` to `working`.
During the submit process, all the resources are copied from **submittedResources** to  **workingResources**.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgBetaUnsubmitEducationUserAssignmentSubmission](Invoke-MgBetaUnsubmitEducationUserAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
This method changes the status of the submission from `submitted` to `working`.
During the submit process, all the resources are copied from **submittedResources** to  **workingResources**.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgBetaUploadEducationSynchronizationProfileUrl](Invoke-MgBetaUploadEducationSynchronizationProfileUrl.md)
Invoke function uploadUrl

### [New-MgBetaEducationClass](New-MgBetaEducationClass.md)
Create a new class.
This will also create a universal group.
When you use this API to create a class, it will add special properties to the group, which will\nadd features such as assignments and special handling within Microsoft Teams when teams are created using the group.
Please note that this API only creates the universal group and does not create a team.
Microsoft Teams provides a user interface for teachers to create teams for their own classes using the groups created by this API.

### [New-MgBetaEducationClassAssignment](New-MgBetaEducationClassAssignment.md)
Create a new assignment.
Only teachers in a class can create an assignment.
Assignments start in the Draft state, which means that students will not see the assignment until publication.

### [New-MgBetaEducationClassAssignmentCategory](New-MgBetaEducationClassAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgBetaEducationClassAssignmentCategoryByRef](New-MgBetaEducationClassAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgBetaEducationClassAssignmentResource](New-MgBetaEducationClassAssignmentResource.md)
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgBetaEducationClassAssignmentSubmission](New-MgBetaEducationClassAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgBetaEducationClassAssignmentSubmissionOutcome](New-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the `POST` request will fail.

### [New-MgBetaEducationClassAssignmentSubmissionResource](New-MgBetaEducationClassAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgBetaEducationClassAssignmentSubmissionSubmittedResource](New-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgBetaEducationClassMemberByRef](New-MgBetaEducationClassMemberByRef.md)
Create new navigation property ref to members for education

### [New-MgBetaEducationClassTeacherByRef](New-MgBetaEducationClassTeacherByRef.md)
Create new navigation property ref to teachers for education

### [New-MgBetaEducationMeAssignment](New-MgBetaEducationMeAssignment.md)
Create new navigation property to assignments for education

### [New-MgBetaEducationMeAssignmentCategory](New-MgBetaEducationMeAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgBetaEducationMeAssignmentCategoryByRef](New-MgBetaEducationMeAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgBetaEducationMeAssignmentResource](New-MgBetaEducationMeAssignmentResource.md)
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgBetaEducationMeAssignmentSubmission](New-MgBetaEducationMeAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgBetaEducationMeAssignmentSubmissionOutcome](New-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the `POST` request will fail.

### [New-MgBetaEducationMeAssignmentSubmissionResource](New-MgBetaEducationMeAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgBetaEducationMeAssignmentSubmissionSubmittedResource](New-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgBetaEducationMeRubric](New-MgBetaEducationMeRubric.md)
Create a new educationRubric object.

### [New-MgBetaEducationSchool](New-MgBetaEducationSchool.md)
Create a school.

### [New-MgBetaEducationSchoolClassByRef](New-MgBetaEducationSchoolClassByRef.md)
Create new navigation property ref to classes for education

### [New-MgBetaEducationSchoolUserByRef](New-MgBetaEducationSchoolUserByRef.md)
Create new navigation property ref to users for education

### [New-MgBetaEducationSynchronizationProfile](New-MgBetaEducationSynchronizationProfile.md)
Create new navigation property to synchronizationProfiles for education

### [New-MgBetaEducationSynchronizationProfileError](New-MgBetaEducationSynchronizationProfileError.md)
Create new navigation property to errors for education

### [New-MgBetaEducationUser](New-MgBetaEducationUser.md)
Create a new user.

### [New-MgBetaEducationUserAssignment](New-MgBetaEducationUserAssignment.md)
Create new navigation property to assignments for education

### [New-MgBetaEducationUserAssignmentCategory](New-MgBetaEducationUserAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgBetaEducationUserAssignmentCategoryByRef](New-MgBetaEducationUserAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgBetaEducationUserAssignmentResource](New-MgBetaEducationUserAssignmentResource.md)
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgBetaEducationUserAssignmentSubmission](New-MgBetaEducationUserAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgBetaEducationUserAssignmentSubmissionOutcome](New-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the `POST` request will fail.

### [New-MgBetaEducationUserAssignmentSubmissionResource](New-MgBetaEducationUserAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgBetaEducationUserAssignmentSubmissionSubmittedResource](New-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgBetaEducationUserRubric](New-MgBetaEducationUserRubric.md)
Create a new educationRubric object.

### [Publish-MgBetaEducationClassAssignment](Publish-MgBetaEducationClassAssignment.md)
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

### [Publish-MgBetaEducationMeAssignment](Publish-MgBetaEducationMeAssignment.md)
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

### [Publish-MgBetaEducationUserAssignment](Publish-MgBetaEducationUserAssignment.md)
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

### [Remove-MgBetaEducationClass](Remove-MgBetaEducationClass.md)
Delete navigation property classes for education

### [Remove-MgBetaEducationClassAssignment](Remove-MgBetaEducationClassAssignment.md)
Delete navigation property assignments for education

### [Remove-MgBetaEducationClassAssignmentCategory](Remove-MgBetaEducationClassAssignmentCategory.md)
Delete navigation property assignmentCategories for education

### [Remove-MgBetaEducationClassAssignmentCategoryByRef](Remove-MgBetaEducationClassAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgBetaEducationClassAssignmentDefault](Remove-MgBetaEducationClassAssignmentDefault.md)
Delete navigation property assignmentDefaults for education

### [Remove-MgBetaEducationClassAssignmentResource](Remove-MgBetaEducationClassAssignmentResource.md)
Delete navigation property resources for education

### [Remove-MgBetaEducationClassAssignmentRubric](Remove-MgBetaEducationClassAssignmentRubric.md)
Delete navigation property rubric for education

### [Remove-MgBetaEducationClassAssignmentRubricByRef](Remove-MgBetaEducationClassAssignmentRubricByRef.md)
Delete ref of navigation property rubric for education

### [Remove-MgBetaEducationClassAssignmentSetting](Remove-MgBetaEducationClassAssignmentSetting.md)
Delete navigation property assignmentSettings for education

### [Remove-MgBetaEducationClassAssignmentSubmission](Remove-MgBetaEducationClassAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgBetaEducationClassAssignmentSubmissionOutcome](Remove-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Delete navigation property outcomes for education

### [Remove-MgBetaEducationClassAssignmentSubmissionResource](Remove-MgBetaEducationClassAssignmentSubmissionResource.md)
Delete navigation property resources for education

### [Remove-MgBetaEducationClassAssignmentSubmissionSubmittedResource](Remove-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgBetaEducationClassMemberByRef](Remove-MgBetaEducationClassMemberByRef.md)
Delete ref of navigation property members for education

### [Remove-MgBetaEducationClassTeacherByRef](Remove-MgBetaEducationClassTeacherByRef.md)
Delete ref of navigation property teachers for education

### [Remove-MgBetaEducationMe](Remove-MgBetaEducationMe.md)
Delete navigation property me for education

### [Remove-MgBetaEducationMeAssignment](Remove-MgBetaEducationMeAssignment.md)
Delete navigation property assignments for education

### [Remove-MgBetaEducationMeAssignmentCategoryByRef](Remove-MgBetaEducationMeAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgBetaEducationMeAssignmentResource](Remove-MgBetaEducationMeAssignmentResource.md)
Delete navigation property resources for education

### [Remove-MgBetaEducationMeAssignmentRubric](Remove-MgBetaEducationMeAssignmentRubric.md)
Delete navigation property rubric for education

### [Remove-MgBetaEducationMeAssignmentRubricByRef](Remove-MgBetaEducationMeAssignmentRubricByRef.md)
Delete ref of navigation property rubric for education

### [Remove-MgBetaEducationMeAssignmentSubmission](Remove-MgBetaEducationMeAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgBetaEducationMeAssignmentSubmissionOutcome](Remove-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Delete navigation property outcomes for education

### [Remove-MgBetaEducationMeAssignmentSubmissionResource](Remove-MgBetaEducationMeAssignmentSubmissionResource.md)
Delete navigation property resources for education

### [Remove-MgBetaEducationMeAssignmentSubmissionSubmittedResource](Remove-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgBetaEducationMeRubric](Remove-MgBetaEducationMeRubric.md)
Delete navigation property rubrics for education

### [Remove-MgBetaEducationSchool](Remove-MgBetaEducationSchool.md)
Delete navigation property schools for education

### [Remove-MgBetaEducationSchoolClassByRef](Remove-MgBetaEducationSchoolClassByRef.md)
Delete ref of navigation property classes for education

### [Remove-MgBetaEducationSchoolUserByRef](Remove-MgBetaEducationSchoolUserByRef.md)
Delete ref of navigation property users for education

### [Remove-MgBetaEducationSynchronizationProfile](Remove-MgBetaEducationSynchronizationProfile.md)
Delete navigation property synchronizationProfiles for education

### [Remove-MgBetaEducationSynchronizationProfileError](Remove-MgBetaEducationSynchronizationProfileError.md)
Delete navigation property errors for education

### [Remove-MgBetaEducationSynchronizationProfileStatus](Remove-MgBetaEducationSynchronizationProfileStatus.md)
Delete navigation property profileStatus for education

### [Remove-MgBetaEducationUser](Remove-MgBetaEducationUser.md)
Delete navigation property users for education

### [Remove-MgBetaEducationUserAssignment](Remove-MgBetaEducationUserAssignment.md)
Delete navigation property assignments for education

### [Remove-MgBetaEducationUserAssignmentCategoryByRef](Remove-MgBetaEducationUserAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgBetaEducationUserAssignmentResource](Remove-MgBetaEducationUserAssignmentResource.md)
Delete navigation property resources for education

### [Remove-MgBetaEducationUserAssignmentRubric](Remove-MgBetaEducationUserAssignmentRubric.md)
Delete navigation property rubric for education

### [Remove-MgBetaEducationUserAssignmentRubricByRef](Remove-MgBetaEducationUserAssignmentRubricByRef.md)
Delete ref of navigation property rubric for education

### [Remove-MgBetaEducationUserAssignmentSubmission](Remove-MgBetaEducationUserAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgBetaEducationUserAssignmentSubmissionOutcome](Remove-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Delete navigation property outcomes for education

### [Remove-MgBetaEducationUserAssignmentSubmissionResource](Remove-MgBetaEducationUserAssignmentSubmissionResource.md)
Delete navigation property resources for education

### [Remove-MgBetaEducationUserAssignmentSubmissionSubmittedResource](Remove-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgBetaEducationUserRubric](Remove-MgBetaEducationUserRubric.md)
Delete navigation property rubrics for education

### [Reset-MgBetaEducationSynchronizationProfile](Reset-MgBetaEducationSynchronizationProfile.md)
Reset the sync of a specific school data synchronization profile in the tenant.

### [Resume-MgBetaEducationSynchronizationProfile](Resume-MgBetaEducationSynchronizationProfile.md)
Resume the sync of a specific school data synchronization profile in the tenant.

### [Set-MgBetaEducationClassAssignmentRubricByRef](Set-MgBetaEducationClassAssignmentRubricByRef.md)
Update the ref of navigation property rubric in education

### [Set-MgBetaEducationClassAssignmentSubmissionUpResourceFolder](Set-MgBetaEducationClassAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgBetaEducationClassAssignmentUpFeedbackResourceFolder](Set-MgBetaEducationClassAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgBetaEducationClassAssignmentUpResourceFolder](Set-MgBetaEducationClassAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
The teacher determines the resources to upload in the assignment's folder.

### [Set-MgBetaEducationMeAssignmentRubricByRef](Set-MgBetaEducationMeAssignmentRubricByRef.md)
Update the ref of navigation property rubric in education

### [Set-MgBetaEducationMeAssignmentSubmissionUpResourceFolder](Set-MgBetaEducationMeAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgBetaEducationMeAssignmentUpFeedbackResourceFolder](Set-MgBetaEducationMeAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgBetaEducationMeAssignmentUpResourceFolder](Set-MgBetaEducationMeAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
The teacher determines the resources to upload in the assignment's folder.

### [Set-MgBetaEducationUserAssignmentRubricByRef](Set-MgBetaEducationUserAssignmentRubricByRef.md)
Update the ref of navigation property rubric in education

### [Set-MgBetaEducationUserAssignmentSubmissionUpResourceFolder](Set-MgBetaEducationUserAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgBetaEducationUserAssignmentUpFeedbackResourceFolder](Set-MgBetaEducationUserAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgBetaEducationUserAssignmentUpResourceFolder](Set-MgBetaEducationUserAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
The teacher determines the resources to upload in the assignment's folder.

### [Start-MgBetaEducationSynchronizationProfile](Start-MgBetaEducationSynchronizationProfile.md)
Verify the files uploaded to a specific school data synchronization profile in the tenant.
If the verification is successful, synchronization will start on the profile.
Otherwise, the response will contain errors and warnings.
If the response contains errors, the synchronization will not start.
If the response contains only warnings, synchronization will start.

### [Submit-MgBetaEducationClassAssignmentSubmission](Submit-MgBetaEducationClassAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
This method changes the status of the submission from `working` to `submitted`.
During the submit process, all the resources are copied to the **submittedResources** bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Submit-MgBetaEducationMeAssignmentSubmission](Submit-MgBetaEducationMeAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
This method changes the status of the submission from `working` to `submitted`.
During the submit process, all the resources are copied to the **submittedResources** bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Submit-MgBetaEducationUserAssignmentSubmission](Submit-MgBetaEducationUserAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
This method changes the status of the submission from `working` to `submitted`.
During the submit process, all the resources are copied to the **submittedResources** bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Suspend-MgBetaEducationSynchronizationProfile](Suspend-MgBetaEducationSynchronizationProfile.md)
Pause the sync of a specific school data synchronization profile in the tenant.

### [Update-MgBetaEducationClass](Update-MgBetaEducationClass.md)
Update the navigation property classes in education

### [Update-MgBetaEducationClassAssignment](Update-MgBetaEducationClassAssignment.md)
Update the navigation property assignments in education

### [Update-MgBetaEducationClassAssignmentCategory](Update-MgBetaEducationClassAssignmentCategory.md)
Update the navigation property assignmentCategories in education

### [Update-MgBetaEducationClassAssignmentDefault](Update-MgBetaEducationClassAssignmentDefault.md)
Update the properties of an educationAssignmentDefaults object.
Only teachers can update these settings.

### [Update-MgBetaEducationClassAssignmentResource](Update-MgBetaEducationClassAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationClassAssignmentRubric](Update-MgBetaEducationClassAssignmentRubric.md)
Update the navigation property rubric in education

### [Update-MgBetaEducationClassAssignmentSetting](Update-MgBetaEducationClassAssignmentSetting.md)
Update the properties of an educationAssignmentSettings object.
Only Teachers can update these settings.

### [Update-MgBetaEducationClassAssignmentSubmission](Update-MgBetaEducationClassAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgBetaEducationClassAssignmentSubmissionOutcome](Update-MgBetaEducationClassAssignmentSubmissionOutcome.md)
Update the navigation property outcomes in education

### [Update-MgBetaEducationClassAssignmentSubmissionResource](Update-MgBetaEducationClassAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationClassAssignmentSubmissionSubmittedResource](Update-MgBetaEducationClassAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgBetaEducationMe](Update-MgBetaEducationMe.md)
Update the navigation property me in education

### [Update-MgBetaEducationMeAssignment](Update-MgBetaEducationMeAssignment.md)
Update the navigation property assignments in education

### [Update-MgBetaEducationMeAssignmentResource](Update-MgBetaEducationMeAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationMeAssignmentRubric](Update-MgBetaEducationMeAssignmentRubric.md)
Update the navigation property rubric in education

### [Update-MgBetaEducationMeAssignmentSubmission](Update-MgBetaEducationMeAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgBetaEducationMeAssignmentSubmissionOutcome](Update-MgBetaEducationMeAssignmentSubmissionOutcome.md)
Update the navigation property outcomes in education

### [Update-MgBetaEducationMeAssignmentSubmissionResource](Update-MgBetaEducationMeAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationMeAssignmentSubmissionSubmittedResource](Update-MgBetaEducationMeAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgBetaEducationMeRubric](Update-MgBetaEducationMeRubric.md)
Update the navigation property rubrics in education

### [Update-MgBetaEducationRoot](Update-MgBetaEducationRoot.md)
Update education

### [Update-MgBetaEducationSchool](Update-MgBetaEducationSchool.md)
Update the navigation property schools in education

### [Update-MgBetaEducationSchoolAdministrativeUnit](Update-MgBetaEducationSchoolAdministrativeUnit.md)
Update the navigation property administrativeUnit in education

### [Update-MgBetaEducationSynchronizationProfile](Update-MgBetaEducationSynchronizationProfile.md)
Update the navigation property synchronizationProfiles in education

### [Update-MgBetaEducationSynchronizationProfileError](Update-MgBetaEducationSynchronizationProfileError.md)
Update the navigation property errors in education

### [Update-MgBetaEducationSynchronizationProfileStatus](Update-MgBetaEducationSynchronizationProfileStatus.md)
Update the navigation property profileStatus in education

### [Update-MgBetaEducationUser](Update-MgBetaEducationUser.md)
Update the navigation property users in education

### [Update-MgBetaEducationUserAssignment](Update-MgBetaEducationUserAssignment.md)
Update the navigation property assignments in education

### [Update-MgBetaEducationUserAssignmentResource](Update-MgBetaEducationUserAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationUserAssignmentRubric](Update-MgBetaEducationUserAssignmentRubric.md)
Update the navigation property rubric in education

### [Update-MgBetaEducationUserAssignmentSubmission](Update-MgBetaEducationUserAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgBetaEducationUserAssignmentSubmissionOutcome](Update-MgBetaEducationUserAssignmentSubmissionOutcome.md)
Update the navigation property outcomes in education

### [Update-MgBetaEducationUserAssignmentSubmissionResource](Update-MgBetaEducationUserAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgBetaEducationUserAssignmentSubmissionSubmittedResource](Update-MgBetaEducationUserAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgBetaEducationUserRubric](Update-MgBetaEducationUserRubric.md)
Update the navigation property rubrics in education

