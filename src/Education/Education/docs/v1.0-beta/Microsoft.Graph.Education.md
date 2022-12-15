---
Module Name: Microsoft.Graph.Education
Module Guid: e17af9af-900e-44ad-a303-3c09e415a74e
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Education Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Education Cmdlets
### [Get-MgEducationClass](Get-MgEducationClass.md)
Get classes from education

### [Get-MgEducationClassAssignment](Get-MgEducationClassAssignment.md)
All assignments associated with this class.
Nullable.

### [Get-MgEducationClassAssignmentCategory](Get-MgEducationClassAssignmentCategory.md)
All categories associated with this class.
Nullable.

### [Get-MgEducationClassAssignmentCategoryByRef](Get-MgEducationClassAssignmentCategoryByRef.md)
List all the categories associated with an assignment.

### [Get-MgEducationClassAssignmentCategoryDelta](Get-MgEducationClassAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgEducationClassAssignmentDefault](Get-MgEducationClassAssignmentDefault.md)
Read the properties and relationships of an educationAssignmentDefaults object.
These are the class-level assignment defaults respected by new assignments created in the class.
Callers can continue to specify custom values on each **assignment** creation if they don't want the default behaviors.

### [Get-MgEducationClassAssignmentDelta](Get-MgEducationClassAssignmentDelta.md)
Invoke function delta

### [Get-MgEducationClassAssignmentResource](Get-MgEducationClassAssignmentResource.md)
Learning objects that are associated with this assignment.
Only teachers can modify this list.
Nullable.

### [Get-MgEducationClassAssignmentRubric](Get-MgEducationClassAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgEducationClassAssignmentRubricByRef](Get-MgEducationClassAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgEducationClassAssignmentSetting](Get-MgEducationClassAssignmentSetting.md)
Read the properties and relationships of an educationAssignmentSettings object.

### [Get-MgEducationClassAssignmentSubmission](Get-MgEducationClassAssignmentSubmission.md)
Once published, there is a submission object for each student representing their work and grade.
Read-only.
Nullable.

### [Get-MgEducationClassAssignmentSubmissionOutcome](Get-MgEducationClassAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgEducationClassAssignmentSubmissionResource](Get-MgEducationClassAssignmentSubmissionResource.md)
Get resources from education

### [Get-MgEducationClassAssignmentSubmissionSubmittedResource](Get-MgEducationClassAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgEducationClassDelta](Get-MgEducationClassDelta.md)
Invoke function delta

### [Get-MgEducationClassGroup](Get-MgEducationClassGroup.md)
Retrieve the Microsoft 365 **group** that corresponds to this **educationClass**.

### [Get-MgEducationClassMember](Get-MgEducationClassMember.md)
Retrieves the teachers and students for a class.
Note that if the delegated token is used, members can only be seen by other members of the class.

### [Get-MgEducationClassMemberByRef](Get-MgEducationClassMemberByRef.md)
Retrieves the teachers and students for a class.
Note that if the delegated token is used, members can only be seen by other members of the class.

### [Get-MgEducationClassSchool](Get-MgEducationClassSchool.md)
All schools that this class is associated with.
Nullable.

### [Get-MgEducationClassTeacher](Get-MgEducationClassTeacher.md)
Retrieve a list teachers for a class.
Delegated tokens must be members of the class to get the teacher list.

### [Get-MgEducationClassTeacherByRef](Get-MgEducationClassTeacherByRef.md)
Retrieve a list teachers for a class.
Delegated tokens must be members of the class to get the teacher list.

### [Get-MgEducationMe](Get-MgEducationMe.md)
Get me from education

### [Get-MgEducationMeAssignment](Get-MgEducationMeAssignment.md)
List of assignments for the user.
Nullable.

### [Get-MgEducationMeAssignmentCategory](Get-MgEducationMeAssignmentCategory.md)
List all the categories associated with an assignment.

### [Get-MgEducationMeAssignmentCategoryByRef](Get-MgEducationMeAssignmentCategoryByRef.md)
List all the categories associated with an assignment.

### [Get-MgEducationMeAssignmentCategoryDelta](Get-MgEducationMeAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgEducationMeAssignmentDelta](Get-MgEducationMeAssignmentDelta.md)
Invoke function delta

### [Get-MgEducationMeAssignmentResource](Get-MgEducationMeAssignmentResource.md)
Learning objects that are associated with this assignment.
Only teachers can modify this list.
Nullable.

### [Get-MgEducationMeAssignmentRubric](Get-MgEducationMeAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgEducationMeAssignmentRubricByRef](Get-MgEducationMeAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgEducationMeAssignmentSubmission](Get-MgEducationMeAssignmentSubmission.md)
Once published, there is a submission object for each student representing their work and grade.
Read-only.
Nullable.

### [Get-MgEducationMeAssignmentSubmissionOutcome](Get-MgEducationMeAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgEducationMeAssignmentSubmissionResource](Get-MgEducationMeAssignmentSubmissionResource.md)
Get resources from education

### [Get-MgEducationMeAssignmentSubmissionSubmittedResource](Get-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgEducationMeClass](Get-MgEducationMeClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgEducationMeRubric](Get-MgEducationMeRubric.md)
When set, the grading rubric attached to the assignment.

### [Get-MgEducationMeSchool](Get-MgEducationMeSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgEducationMeTaughtClass](Get-MgEducationMeTaughtClass.md)
Classes for which the user is a teacher.

### [Get-MgEducationMeUser](Get-MgEducationMeUser.md)
Retrieve the simple directory **user** that corresponds to this **educationUser**.

### [Get-MgEducationRoot](Get-MgEducationRoot.md)
Get education

### [Get-MgEducationSchool](Get-MgEducationSchool.md)
Get schools from education

### [Get-MgEducationSchoolAdministrativeUnit](Get-MgEducationSchoolAdministrativeUnit.md)
Retrieve the simple directory **administrativeUnit** that corresponds to this **educationSchool**.

### [Get-MgEducationSchoolClass](Get-MgEducationSchoolClass.md)
Retrieve a list of classes owned by a school.

### [Get-MgEducationSchoolClassByRef](Get-MgEducationSchoolClassByRef.md)
Retrieve a list of classes owned by a school.

### [Get-MgEducationSchoolDelta](Get-MgEducationSchoolDelta.md)
Invoke function delta

### [Get-MgEducationSchoolUser](Get-MgEducationSchoolUser.md)
Retrieve a list of users at a school.

### [Get-MgEducationSchoolUserByRef](Get-MgEducationSchoolUserByRef.md)
Retrieve a list of users at a school.

### [Get-MgEducationSynchronizationProfile](Get-MgEducationSynchronizationProfile.md)
Get synchronizationProfiles from education

### [Get-MgEducationSynchronizationProfileError](Get-MgEducationSynchronizationProfileError.md)
All errors associated with this synchronization profile.

### [Get-MgEducationSynchronizationProfileStatus](Get-MgEducationSynchronizationProfileStatus.md)
Get the status of a specific school data synchronization profile in the tenant.
The response will indicate the status of the sync.

### [Get-MgEducationUser](Get-MgEducationUser.md)
Get users from education

### [Get-MgEducationUserAssignment](Get-MgEducationUserAssignment.md)
List of assignments for the user.
Nullable.

### [Get-MgEducationUserAssignmentCategory](Get-MgEducationUserAssignmentCategory.md)
List all the categories associated with an assignment.

### [Get-MgEducationUserAssignmentCategoryByRef](Get-MgEducationUserAssignmentCategoryByRef.md)
List all the categories associated with an assignment.

### [Get-MgEducationUserAssignmentCategoryDelta](Get-MgEducationUserAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgEducationUserAssignmentDelta](Get-MgEducationUserAssignmentDelta.md)
Invoke function delta

### [Get-MgEducationUserAssignmentResource](Get-MgEducationUserAssignmentResource.md)
Learning objects that are associated with this assignment.
Only teachers can modify this list.
Nullable.

### [Get-MgEducationUserAssignmentRubric](Get-MgEducationUserAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgEducationUserAssignmentRubricByRef](Get-MgEducationUserAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.

### [Get-MgEducationUserAssignmentSubmission](Get-MgEducationUserAssignmentSubmission.md)
Once published, there is a submission object for each student representing their work and grade.
Read-only.
Nullable.

### [Get-MgEducationUserAssignmentSubmissionOutcome](Get-MgEducationUserAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgEducationUserAssignmentSubmissionResource](Get-MgEducationUserAssignmentSubmissionResource.md)
Get resources from education

### [Get-MgEducationUserAssignmentSubmissionSubmittedResource](Get-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Get submittedResources from education

### [Get-MgEducationUserClass](Get-MgEducationUserClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgEducationUserDelta](Get-MgEducationUserDelta.md)
Invoke function delta

### [Get-MgEducationUserRubric](Get-MgEducationUserRubric.md)
When set, the grading rubric attached to the assignment.

### [Get-MgEducationUserSchool](Get-MgEducationUserSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgEducationUserTaughtClass](Get-MgEducationUserTaughtClass.md)
Classes for which the user is a teacher.

### [Invoke-MgReassignEducationClassAssignmentSubmission](Invoke-MgReassignEducationClassAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

### [Invoke-MgReassignEducationMeAssignmentSubmission](Invoke-MgReassignEducationMeAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

### [Invoke-MgReassignEducationUserAssignmentSubmission](Invoke-MgReassignEducationUserAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

### [Invoke-MgReturnEducationClassAssignmentSubmission](Invoke-MgReturnEducationClassAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgReturnEducationMeAssignmentSubmission](Invoke-MgReturnEducationMeAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgReturnEducationUserAssignmentSubmission](Invoke-MgReturnEducationUserAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgUnsubmitEducationClassAssignmentSubmission](Invoke-MgUnsubmitEducationClassAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
This method changes the status of the submission from `submitted` to `working`.
During the submit process, all the resources are copied from **submittedResources** to  **workingResources**.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgUnsubmitEducationMeAssignmentSubmission](Invoke-MgUnsubmitEducationMeAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
This method changes the status of the submission from `submitted` to `working`.
During the submit process, all the resources are copied from **submittedResources** to  **workingResources**.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgUnsubmitEducationUserAssignmentSubmission](Invoke-MgUnsubmitEducationUserAssignmentSubmission.md)
Indicate that a student wants to work on the submitted assignment after it was turned in.
This method changes the status of the submission from `submitted` to `working`.
During the submit process, all the resources are copied from **submittedResources** to  **workingResources**.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgUploadEducationSynchronizationProfileUrl](Invoke-MgUploadEducationSynchronizationProfileUrl.md)
Invoke function uploadUrl

### [New-MgEducationClass](New-MgEducationClass.md)
Create a new class.
This will also create a universal group.
When you use this API to create a class, it will add special properties to the group, which will\nadd features such as assignments and special handling within Microsoft Teams when teams are created using the group.
Please note that this API only creates the universal group and does not create a team.
Microsoft Teams provides a user interface for teachers to create teams for their own classes using the groups created by this API.

### [New-MgEducationClassAssignment](New-MgEducationClassAssignment.md)
Create a new assignment.
Only teachers in a class can create an assignment.
Assignments start in the Draft state, which means that students will not see the assignment until publication.

### [New-MgEducationClassAssignmentCategory](New-MgEducationClassAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgEducationClassAssignmentCategoryByRef](New-MgEducationClassAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgEducationClassAssignmentResource](New-MgEducationClassAssignmentResource.md)
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgEducationClassAssignmentSubmission](New-MgEducationClassAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgEducationClassAssignmentSubmissionOutcome](New-MgEducationClassAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the `POST` request will fail.

### [New-MgEducationClassAssignmentSubmissionResource](New-MgEducationClassAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgEducationClassAssignmentSubmissionSubmittedResource](New-MgEducationClassAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgEducationClassMemberByRef](New-MgEducationClassMemberByRef.md)
Create new navigation property ref to members for education

### [New-MgEducationClassTeacherByRef](New-MgEducationClassTeacherByRef.md)
Create new navigation property ref to teachers for education

### [New-MgEducationMeAssignment](New-MgEducationMeAssignment.md)
Create new navigation property to assignments for education

### [New-MgEducationMeAssignmentCategory](New-MgEducationMeAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgEducationMeAssignmentCategoryByRef](New-MgEducationMeAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgEducationMeAssignmentResource](New-MgEducationMeAssignmentResource.md)
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgEducationMeAssignmentSubmission](New-MgEducationMeAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgEducationMeAssignmentSubmissionOutcome](New-MgEducationMeAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the `POST` request will fail.

### [New-MgEducationMeAssignmentSubmissionResource](New-MgEducationMeAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgEducationMeAssignmentSubmissionSubmittedResource](New-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgEducationMeRubric](New-MgEducationMeRubric.md)
Create a new educationRubric object.

### [New-MgEducationSchool](New-MgEducationSchool.md)
Create a school.

### [New-MgEducationSchoolClassByRef](New-MgEducationSchoolClassByRef.md)
Create new navigation property ref to classes for education

### [New-MgEducationSchoolUserByRef](New-MgEducationSchoolUserByRef.md)
Create new navigation property ref to users for education

### [New-MgEducationSynchronizationProfile](New-MgEducationSynchronizationProfile.md)
Create new navigation property to synchronizationProfiles for education

### [New-MgEducationSynchronizationProfileError](New-MgEducationSynchronizationProfileError.md)
Create new navigation property to errors for education

### [New-MgEducationUser](New-MgEducationUser.md)
Create a new user.

### [New-MgEducationUserAssignment](New-MgEducationUserAssignment.md)
Create new navigation property to assignments for education

### [New-MgEducationUserAssignmentCategory](New-MgEducationUserAssignmentCategory.md)
Create new navigation property to categories for education

### [New-MgEducationUserAssignmentCategoryByRef](New-MgEducationUserAssignmentCategoryByRef.md)
Create new navigation property ref to categories for education

### [New-MgEducationUserAssignmentResource](New-MgEducationUserAssignmentResource.md)
Create an assignment resource.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgEducationUserAssignmentSubmission](New-MgEducationUserAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgEducationUserAssignmentSubmissionOutcome](New-MgEducationUserAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or is not in that folder, the `POST` request will fail.

### [New-MgEducationUserAssignmentSubmissionResource](New-MgEducationUserAssignmentSubmissionResource.md)
Add a educationSubmissionResource to a submission resource list.
Only the student assigned to the submission can perform this operation.
The operation will not succeed if the **allowStudentsToAddResources** flag is not set to `true`.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgEducationUserAssignmentSubmissionSubmittedResource](New-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgEducationUserRubric](New-MgEducationUserRubric.md)
Create a new educationRubric object.

### [Publish-MgEducationClassAssignment](Publish-MgEducationClassAssignment.md)
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

### [Publish-MgEducationMeAssignment](Publish-MgEducationMeAssignment.md)
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

### [Publish-MgEducationUserAssignment](Publish-MgEducationUserAssignment.md)
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

### [Remove-MgEducationClass](Remove-MgEducationClass.md)
Delete navigation property classes for education

### [Remove-MgEducationClassAssignment](Remove-MgEducationClassAssignment.md)
Delete navigation property assignments for education

### [Remove-MgEducationClassAssignmentCategory](Remove-MgEducationClassAssignmentCategory.md)
Delete navigation property assignmentCategories for education

### [Remove-MgEducationClassAssignmentCategoryByRef](Remove-MgEducationClassAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgEducationClassAssignmentDefault](Remove-MgEducationClassAssignmentDefault.md)
Delete navigation property assignmentDefaults for education

### [Remove-MgEducationClassAssignmentResource](Remove-MgEducationClassAssignmentResource.md)
Delete navigation property resources for education

### [Remove-MgEducationClassAssignmentRubric](Remove-MgEducationClassAssignmentRubric.md)
Delete navigation property rubric for education

### [Remove-MgEducationClassAssignmentRubricByRef](Remove-MgEducationClassAssignmentRubricByRef.md)
Delete ref of navigation property rubric for education

### [Remove-MgEducationClassAssignmentSetting](Remove-MgEducationClassAssignmentSetting.md)
Delete navigation property assignmentSettings for education

### [Remove-MgEducationClassAssignmentSubmission](Remove-MgEducationClassAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgEducationClassAssignmentSubmissionOutcome](Remove-MgEducationClassAssignmentSubmissionOutcome.md)
Delete navigation property outcomes for education

### [Remove-MgEducationClassAssignmentSubmissionResource](Remove-MgEducationClassAssignmentSubmissionResource.md)
Delete navigation property resources for education

### [Remove-MgEducationClassAssignmentSubmissionSubmittedResource](Remove-MgEducationClassAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgEducationClassMemberByRef](Remove-MgEducationClassMemberByRef.md)
Delete ref of navigation property members for education

### [Remove-MgEducationClassTeacherByRef](Remove-MgEducationClassTeacherByRef.md)
Delete ref of navigation property teachers for education

### [Remove-MgEducationMe](Remove-MgEducationMe.md)
Delete navigation property me for education

### [Remove-MgEducationMeAssignment](Remove-MgEducationMeAssignment.md)
Delete navigation property assignments for education

### [Remove-MgEducationMeAssignmentCategoryByRef](Remove-MgEducationMeAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgEducationMeAssignmentResource](Remove-MgEducationMeAssignmentResource.md)
Delete navigation property resources for education

### [Remove-MgEducationMeAssignmentRubric](Remove-MgEducationMeAssignmentRubric.md)
Delete navigation property rubric for education

### [Remove-MgEducationMeAssignmentRubricByRef](Remove-MgEducationMeAssignmentRubricByRef.md)
Delete ref of navigation property rubric for education

### [Remove-MgEducationMeAssignmentSubmission](Remove-MgEducationMeAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgEducationMeAssignmentSubmissionOutcome](Remove-MgEducationMeAssignmentSubmissionOutcome.md)
Delete navigation property outcomes for education

### [Remove-MgEducationMeAssignmentSubmissionResource](Remove-MgEducationMeAssignmentSubmissionResource.md)
Delete navigation property resources for education

### [Remove-MgEducationMeAssignmentSubmissionSubmittedResource](Remove-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgEducationMeRubric](Remove-MgEducationMeRubric.md)
Delete navigation property rubrics for education

### [Remove-MgEducationSchool](Remove-MgEducationSchool.md)
Delete navigation property schools for education

### [Remove-MgEducationSchoolClassByRef](Remove-MgEducationSchoolClassByRef.md)
Delete ref of navigation property classes for education

### [Remove-MgEducationSchoolUserByRef](Remove-MgEducationSchoolUserByRef.md)
Delete ref of navigation property users for education

### [Remove-MgEducationSynchronizationProfile](Remove-MgEducationSynchronizationProfile.md)
Delete navigation property synchronizationProfiles for education

### [Remove-MgEducationSynchronizationProfileError](Remove-MgEducationSynchronizationProfileError.md)
Delete navigation property errors for education

### [Remove-MgEducationSynchronizationProfileStatus](Remove-MgEducationSynchronizationProfileStatus.md)
Delete navigation property profileStatus for education

### [Remove-MgEducationUser](Remove-MgEducationUser.md)
Delete navigation property users for education

### [Remove-MgEducationUserAssignment](Remove-MgEducationUserAssignment.md)
Delete navigation property assignments for education

### [Remove-MgEducationUserAssignmentCategoryByRef](Remove-MgEducationUserAssignmentCategoryByRef.md)
Delete ref of navigation property categories for education

### [Remove-MgEducationUserAssignmentResource](Remove-MgEducationUserAssignmentResource.md)
Delete navigation property resources for education

### [Remove-MgEducationUserAssignmentRubric](Remove-MgEducationUserAssignmentRubric.md)
Delete navigation property rubric for education

### [Remove-MgEducationUserAssignmentRubricByRef](Remove-MgEducationUserAssignmentRubricByRef.md)
Delete ref of navigation property rubric for education

### [Remove-MgEducationUserAssignmentSubmission](Remove-MgEducationUserAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgEducationUserAssignmentSubmissionOutcome](Remove-MgEducationUserAssignmentSubmissionOutcome.md)
Delete navigation property outcomes for education

### [Remove-MgEducationUserAssignmentSubmissionResource](Remove-MgEducationUserAssignmentSubmissionResource.md)
Delete navigation property resources for education

### [Remove-MgEducationUserAssignmentSubmissionSubmittedResource](Remove-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgEducationUserRubric](Remove-MgEducationUserRubric.md)
Delete navigation property rubrics for education

### [Reset-MgEducationSynchronizationProfile](Reset-MgEducationSynchronizationProfile.md)
Reset the sync of a specific school data synchronization profile in the tenant.

### [Resume-MgEducationSynchronizationProfile](Resume-MgEducationSynchronizationProfile.md)
Resume the sync of a specific school data synchronization profile in the tenant.

### [Set-MgEducationClassAssignmentRubricByRef](Set-MgEducationClassAssignmentRubricByRef.md)
Update the ref of navigation property rubric in education

### [Set-MgEducationClassAssignmentSubmissionUpResourceFolder](Set-MgEducationClassAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgEducationClassAssignmentUpFeedbackResourceFolder](Set-MgEducationClassAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgEducationClassAssignmentUpResourceFolder](Set-MgEducationClassAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
The teacher determines the resources to upload in the assignment's folder.

### [Set-MgEducationMeAssignmentRubricByRef](Set-MgEducationMeAssignmentRubricByRef.md)
Update the ref of navigation property rubric in education

### [Set-MgEducationMeAssignmentSubmissionUpResourceFolder](Set-MgEducationMeAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgEducationMeAssignmentUpFeedbackResourceFolder](Set-MgEducationMeAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgEducationMeAssignmentUpResourceFolder](Set-MgEducationMeAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
The teacher determines the resources to upload in the assignment's folder.

### [Set-MgEducationUserAssignmentRubricByRef](Set-MgEducationUserAssignmentRubricByRef.md)
Update the ref of navigation property rubric in education

### [Set-MgEducationUserAssignmentSubmissionUpResourceFolder](Set-MgEducationUserAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgEducationUserAssignmentUpFeedbackResourceFolder](Set-MgEducationUserAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgEducationUserAssignmentUpResourceFolder](Set-MgEducationUserAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
The teacher determines the resources to upload in the assignment's folder.

### [Start-MgEducationSynchronizationProfile](Start-MgEducationSynchronizationProfile.md)
Verify the files uploaded to a specific school data synchronization profile in the tenant.
If the verification is successful, synchronization will start on the profile.
Otherwise, the response will contain errors and warnings.
If the response contains errors, the synchronization will not start.
If the response contains only warnings, synchronization will start.

### [Submit-MgEducationClassAssignmentSubmission](Submit-MgEducationClassAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
This method changes the status of the submission from `working` to `submitted`.
During the submit process, all the resources are copied to the **submittedResources** bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Submit-MgEducationMeAssignmentSubmission](Submit-MgEducationMeAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
This method changes the status of the submission from `working` to `submitted`.
During the submit process, all the resources are copied to the **submittedResources** bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Submit-MgEducationUserAssignmentSubmission](Submit-MgEducationUserAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
This method changes the status of the submission from `working` to `submitted`.
During the submit process, all the resources are copied to the **submittedResources** bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Suspend-MgEducationSynchronizationProfile](Suspend-MgEducationSynchronizationProfile.md)
Pause the sync of a specific school data synchronization profile in the tenant.

### [Update-MgEducationClass](Update-MgEducationClass.md)
Update the navigation property classes in education

### [Update-MgEducationClassAssignment](Update-MgEducationClassAssignment.md)
Update the navigation property assignments in education

### [Update-MgEducationClassAssignmentCategory](Update-MgEducationClassAssignmentCategory.md)
Update the navigation property assignmentCategories in education

### [Update-MgEducationClassAssignmentDefault](Update-MgEducationClassAssignmentDefault.md)
Update the properties of an educationAssignmentDefaults object.
Only teachers can update these settings.

### [Update-MgEducationClassAssignmentResource](Update-MgEducationClassAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgEducationClassAssignmentRubric](Update-MgEducationClassAssignmentRubric.md)
Update the navigation property rubric in education

### [Update-MgEducationClassAssignmentSetting](Update-MgEducationClassAssignmentSetting.md)
Update the properties of an educationAssignmentSettings object.
Only Teachers can update these settings.

### [Update-MgEducationClassAssignmentSubmission](Update-MgEducationClassAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgEducationClassAssignmentSubmissionOutcome](Update-MgEducationClassAssignmentSubmissionOutcome.md)
Update the navigation property outcomes in education

### [Update-MgEducationClassAssignmentSubmissionResource](Update-MgEducationClassAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgEducationClassAssignmentSubmissionSubmittedResource](Update-MgEducationClassAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgEducationMe](Update-MgEducationMe.md)
Update the navigation property me in education

### [Update-MgEducationMeAssignment](Update-MgEducationMeAssignment.md)
Update the navigation property assignments in education

### [Update-MgEducationMeAssignmentResource](Update-MgEducationMeAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgEducationMeAssignmentRubric](Update-MgEducationMeAssignmentRubric.md)
Update the navigation property rubric in education

### [Update-MgEducationMeAssignmentSubmission](Update-MgEducationMeAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgEducationMeAssignmentSubmissionOutcome](Update-MgEducationMeAssignmentSubmissionOutcome.md)
Update the navigation property outcomes in education

### [Update-MgEducationMeAssignmentSubmissionResource](Update-MgEducationMeAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgEducationMeAssignmentSubmissionSubmittedResource](Update-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgEducationMeRubric](Update-MgEducationMeRubric.md)
Update the navigation property rubrics in education

### [Update-MgEducationRoot](Update-MgEducationRoot.md)
Update education

### [Update-MgEducationSchool](Update-MgEducationSchool.md)
Update the navigation property schools in education

### [Update-MgEducationSchoolAdministrativeUnit](Update-MgEducationSchoolAdministrativeUnit.md)
Update the navigation property administrativeUnit in education

### [Update-MgEducationSynchronizationProfile](Update-MgEducationSynchronizationProfile.md)
Update the navigation property synchronizationProfiles in education

### [Update-MgEducationSynchronizationProfileError](Update-MgEducationSynchronizationProfileError.md)
Update the navigation property errors in education

### [Update-MgEducationSynchronizationProfileStatus](Update-MgEducationSynchronizationProfileStatus.md)
Update the navigation property profileStatus in education

### [Update-MgEducationUser](Update-MgEducationUser.md)
Update the navigation property users in education

### [Update-MgEducationUserAssignment](Update-MgEducationUserAssignment.md)
Update the navigation property assignments in education

### [Update-MgEducationUserAssignmentResource](Update-MgEducationUserAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgEducationUserAssignmentRubric](Update-MgEducationUserAssignmentRubric.md)
Update the navigation property rubric in education

### [Update-MgEducationUserAssignmentSubmission](Update-MgEducationUserAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgEducationUserAssignmentSubmissionOutcome](Update-MgEducationUserAssignmentSubmissionOutcome.md)
Update the navigation property outcomes in education

### [Update-MgEducationUserAssignmentSubmissionResource](Update-MgEducationUserAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgEducationUserAssignmentSubmissionSubmittedResource](Update-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgEducationUserRubric](Update-MgEducationUserRubric.md)
Update the navigation property rubrics in education

