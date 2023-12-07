---
Module Name: Microsoft.Graph.Education
Module Guid: f4578857-a7a6-4c77-9eed-3389b2b42152
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.education
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Education Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Education Cmdlets
### [Get-MgEducationClass](Get-MgEducationClass.md)
Retrieve a class from the system.
A class is a universal group with a special property that indicates to the system that the group is a class.
Group members represent the students; group admins represent the teachers in the class.
If you're using the delegated token, the user will only see classes in which they are members.

### [Get-MgEducationClassAssignment](Get-MgEducationClassAssignment.md)
Get the properties and relationships of an assignment.
Only teachers, students, and applications with application permissions can perform this operation.
Students can only see assignments assigned to them; teachers and applications with application permissions can see all assignments in a class.

### [Get-MgEducationClassAssignmentCategory](Get-MgEducationClassAssignmentCategory.md)
Retrieve an educationCategory object.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationClassAssignmentCategoryByRef](Get-MgEducationClassAssignmentCategoryByRef.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationClassAssignmentCategoryCount](Get-MgEducationClassAssignmentCategoryCount.md)
Get the number of the resource

### [Get-MgEducationClassAssignmentCategoryDelta](Get-MgEducationClassAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgEducationClassAssignmentCount](Get-MgEducationClassAssignmentCount.md)
Get the number of the resource

### [Get-MgEducationClassAssignmentDefault](Get-MgEducationClassAssignmentDefault.md)
Read the properties and relationships of an educationAssignmentDefaults object.
These are the class-level assignment defaults respected by new assignments created in the class.
Callers can continue to specify custom values on each assignment creation if they don't want the default behaviors.
Only teachers can perform this operation.

### [Get-MgEducationClassAssignmentDelta](Get-MgEducationClassAssignmentDelta.md)
Invoke function delta

### [Get-MgEducationClassAssignmentResource](Get-MgEducationClassAssignmentResource.md)
Get the properties of an education assignment resource associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationClassAssignmentResourceCount](Get-MgEducationClassAssignmentResourceCount.md)
Get the number of the resource

### [Get-MgEducationClassAssignmentRubric](Get-MgEducationClassAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationClassAssignmentRubricByRef](Get-MgEducationClassAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationClassAssignmentSetting](Get-MgEducationClassAssignmentSetting.md)
Specifies class-level assignments settings.

### [Get-MgEducationClassAssignmentSubmission](Get-MgEducationClassAssignmentSubmission.md)
Retrieve a particular submission.
Only teachers, students, and applications with application permissions can perform this operation.
A submission object represents a student's work for an assignment.
Resources associated with the submission represent this work.
Only the assignedTo student can see and modify the submission.
A teacher or application with application permissions has full access to all submissions.
The grade and feedback from a teacher are part of the educationOutcome associated with this object.
Only teachers or applications with application permissions can add or change grades and feedback.
Students will not see the grade or feedback until the assignment has been released.

### [Get-MgEducationClassAssignmentSubmissionCount](Get-MgEducationClassAssignmentSubmissionCount.md)
Get the number of the resource

### [Get-MgEducationClassAssignmentSubmissionOutcome](Get-MgEducationClassAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgEducationClassAssignmentSubmissionOutcomeCount](Get-MgEducationClassAssignmentSubmissionOutcomeCount.md)
Get the number of the resource

### [Get-MgEducationClassAssignmentSubmissionResource](Get-MgEducationClassAssignmentSubmissionResource.md)
Retrieve the properties of a specific resource associated with a submission.
Only teachers, students, and applications with application permissions can perform this operation.
This resource is in the 'working' resource list and should be considered work in process by a student.
This resource is wrapped with a possible pointer back to the assignment resource if it was copied from the assignment.

### [Get-MgEducationClassAssignmentSubmissionResourceCount](Get-MgEducationClassAssignmentSubmissionResourceCount.md)
Get the number of the resource

### [Get-MgEducationClassAssignmentSubmissionSubmittedResource](Get-MgEducationClassAssignmentSubmissionSubmittedResource.md)
Retrieve a submitted resource.
Only teachers, students, and applications with application permissions can perform this operation.
Resources are available to a teacher or an application with application permissions after a student submits it, and are available to the student after the teacher returns the submission.
Teachers can leave notes in some resources.

### [Get-MgEducationClassAssignmentSubmissionSubmittedResourceCount](Get-MgEducationClassAssignmentSubmissionSubmittedResourceCount.md)
Get the number of the resource

### [Get-MgEducationClassCount](Get-MgEducationClassCount.md)
Get the number of the resource

### [Get-MgEducationClassDelta](Get-MgEducationClassDelta.md)
Invoke function delta

### [Get-MgEducationClassGroup](Get-MgEducationClassGroup.md)
The underlying Microsoft 365 group object.

### [Get-MgEducationClassGroupServiceProvisioningError](Get-MgEducationClassGroupServiceProvisioningError.md)
Get serviceProvisioningErrors property value

### [Get-MgEducationClassGroupServiceProvisioningErrorCount](Get-MgEducationClassGroupServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgEducationClassMember](Get-MgEducationClassMember.md)
Retrieves the educationUser members of an educationClass.

### [Get-MgEducationClassMemberByRef](Get-MgEducationClassMemberByRef.md)
Retrieves the educationUser members of an educationClass.

### [Get-MgEducationClassMemberCount](Get-MgEducationClassMemberCount.md)
Get the number of the resource

### [Get-MgEducationClassSchool](Get-MgEducationClassSchool.md)
All schools that this class is associated with.
Nullable.

### [Get-MgEducationClassSchoolCount](Get-MgEducationClassSchoolCount.md)
Get the number of the resource

### [Get-MgEducationClassTeacher](Get-MgEducationClassTeacher.md)
Retrieve a list of teachers for a class.
Delegated tokens must be members of the class to get the teacher list.

### [Get-MgEducationClassTeacherByRef](Get-MgEducationClassTeacherByRef.md)
Retrieve a list of teachers for a class.
Delegated tokens must be members of the class to get the teacher list.

### [Get-MgEducationClassTeacherCount](Get-MgEducationClassTeacherCount.md)
Get the number of the resource

### [Get-MgEducationMe](Get-MgEducationMe.md)
Get me from education

### [Get-MgEducationMeAssignment](Get-MgEducationMeAssignment.md)
Assignments belonging to the user.

### [Get-MgEducationMeAssignmentCategory](Get-MgEducationMeAssignmentCategory.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationMeAssignmentCategoryByRef](Get-MgEducationMeAssignmentCategoryByRef.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationMeAssignmentCategoryCount](Get-MgEducationMeAssignmentCategoryCount.md)
Get the number of the resource

### [Get-MgEducationMeAssignmentCategoryDelta](Get-MgEducationMeAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgEducationMeAssignmentCount](Get-MgEducationMeAssignmentCount.md)
Get the number of the resource

### [Get-MgEducationMeAssignmentDelta](Get-MgEducationMeAssignmentDelta.md)
Invoke function delta

### [Get-MgEducationMeAssignmentResource](Get-MgEducationMeAssignmentResource.md)
Get the properties of an education assignment resource associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationMeAssignmentResourceCount](Get-MgEducationMeAssignmentResourceCount.md)
Get the number of the resource

### [Get-MgEducationMeAssignmentRubric](Get-MgEducationMeAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationMeAssignmentRubricByRef](Get-MgEducationMeAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationMeAssignmentSubmission](Get-MgEducationMeAssignmentSubmission.md)
Retrieve a particular submission.
Only teachers, students, and applications with application permissions can perform this operation.
A submission object represents a student's work for an assignment.
Resources associated with the submission represent this work.
Only the assignedTo student can see and modify the submission.
A teacher or application with application permissions has full access to all submissions.
The grade and feedback from a teacher are part of the educationOutcome associated with this object.
Only teachers or applications with application permissions can add or change grades and feedback.
Students will not see the grade or feedback until the assignment has been released.

### [Get-MgEducationMeAssignmentSubmissionCount](Get-MgEducationMeAssignmentSubmissionCount.md)
Get the number of the resource

### [Get-MgEducationMeAssignmentSubmissionOutcome](Get-MgEducationMeAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgEducationMeAssignmentSubmissionOutcomeCount](Get-MgEducationMeAssignmentSubmissionOutcomeCount.md)
Get the number of the resource

### [Get-MgEducationMeAssignmentSubmissionResource](Get-MgEducationMeAssignmentSubmissionResource.md)
Retrieve the properties of a specific resource associated with a submission.
Only teachers, students, and applications with application permissions can perform this operation.
This resource is in the 'working' resource list and should be considered work in process by a student.
This resource is wrapped with a possible pointer back to the assignment resource if it was copied from the assignment.

### [Get-MgEducationMeAssignmentSubmissionResourceCount](Get-MgEducationMeAssignmentSubmissionResourceCount.md)
Get the number of the resource

### [Get-MgEducationMeAssignmentSubmissionSubmittedResource](Get-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Retrieve a submitted resource.
Only teachers, students, and applications with application permissions can perform this operation.
Resources are available to a teacher or an application with application permissions after a student submits it, and are available to the student after the teacher returns the submission.
Teachers can leave notes in some resources.

### [Get-MgEducationMeAssignmentSubmissionSubmittedResourceCount](Get-MgEducationMeAssignmentSubmissionSubmittedResourceCount.md)
Get the number of the resource

### [Get-MgEducationMeClass](Get-MgEducationMeClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgEducationMeClassCount](Get-MgEducationMeClassCount.md)
Get the number of the resource

### [Get-MgEducationMeRubric](Get-MgEducationMeRubric.md)
Retrieve the properties and relationships of an educationRubric object.
Only teachers and students can perform this operation.

### [Get-MgEducationMeRubricCount](Get-MgEducationMeRubricCount.md)
Get the number of the resource

### [Get-MgEducationMeSchool](Get-MgEducationMeSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgEducationMeSchoolCount](Get-MgEducationMeSchoolCount.md)
Get the number of the resource

### [Get-MgEducationMeTaughtClass](Get-MgEducationMeTaughtClass.md)
Classes for which the user is a teacher.

### [Get-MgEducationMeTaughtClassCount](Get-MgEducationMeTaughtClassCount.md)
Get the number of the resource

### [Get-MgEducationMeUser](Get-MgEducationMeUser.md)
Retrieve the simple directory user that corresponds to this educationUser.

### [Get-MgEducationMeUserMailboxSetting](Get-MgEducationMeUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgEducationMeUserServiceProvisioningError](Get-MgEducationMeUserServiceProvisioningError.md)
Get serviceProvisioningErrors property value

### [Get-MgEducationMeUserServiceProvisioningErrorCount](Get-MgEducationMeUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgEducationRoot](Get-MgEducationRoot.md)
Get education

### [Get-MgEducationSchool](Get-MgEducationSchool.md)
Read the properties and relationships of an educationSchool object.

### [Get-MgEducationSchoolAdministrativeUnit](Get-MgEducationSchoolAdministrativeUnit.md)
Get a list of administrativeUnits associated with an educationSchool object.

### [Get-MgEducationSchoolClass](Get-MgEducationSchoolClass.md)
Get the educationClass resources owned by an educationSchool.

### [Get-MgEducationSchoolClassByRef](Get-MgEducationSchoolClassByRef.md)
Get the educationClass resources owned by an educationSchool.

### [Get-MgEducationSchoolClassCount](Get-MgEducationSchoolClassCount.md)
Get the number of the resource

### [Get-MgEducationSchoolCount](Get-MgEducationSchoolCount.md)
Get the number of the resource

### [Get-MgEducationSchoolDelta](Get-MgEducationSchoolDelta.md)
Invoke function delta

### [Get-MgEducationSchoolUser](Get-MgEducationSchoolUser.md)
Get the educationUser resources associated with an educationSchool.

### [Get-MgEducationSchoolUserByRef](Get-MgEducationSchoolUserByRef.md)
Get the educationUser resources associated with an educationSchool.

### [Get-MgEducationSchoolUserCount](Get-MgEducationSchoolUserCount.md)
Get the number of the resource

### [Get-MgEducationUser](Get-MgEducationUser.md)
Read the properties and relationships of an educationUser object.

### [Get-MgEducationUserAssignment](Get-MgEducationUserAssignment.md)
Assignments belonging to the user.

### [Get-MgEducationUserAssignmentCategory](Get-MgEducationUserAssignmentCategory.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationUserAssignmentCategoryByRef](Get-MgEducationUserAssignmentCategoryByRef.md)
List all the categories associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationUserAssignmentCategoryCount](Get-MgEducationUserAssignmentCategoryCount.md)
Get the number of the resource

### [Get-MgEducationUserAssignmentCategoryDelta](Get-MgEducationUserAssignmentCategoryDelta.md)
Invoke function delta

### [Get-MgEducationUserAssignmentCount](Get-MgEducationUserAssignmentCount.md)
Get the number of the resource

### [Get-MgEducationUserAssignmentDelta](Get-MgEducationUserAssignmentDelta.md)
Invoke function delta

### [Get-MgEducationUserAssignmentResource](Get-MgEducationUserAssignmentResource.md)
Get the properties of an education assignment resource associated with an assignment.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationUserAssignmentResourceCount](Get-MgEducationUserAssignmentResourceCount.md)
Get the number of the resource

### [Get-MgEducationUserAssignmentRubric](Get-MgEducationUserAssignmentRubric.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationUserAssignmentRubricByRef](Get-MgEducationUserAssignmentRubricByRef.md)
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

### [Get-MgEducationUserAssignmentSubmission](Get-MgEducationUserAssignmentSubmission.md)
Retrieve a particular submission.
Only teachers, students, and applications with application permissions can perform this operation.
A submission object represents a student's work for an assignment.
Resources associated with the submission represent this work.
Only the assignedTo student can see and modify the submission.
A teacher or application with application permissions has full access to all submissions.
The grade and feedback from a teacher are part of the educationOutcome associated with this object.
Only teachers or applications with application permissions can add or change grades and feedback.
Students will not see the grade or feedback until the assignment has been released.

### [Get-MgEducationUserAssignmentSubmissionCount](Get-MgEducationUserAssignmentSubmissionCount.md)
Get the number of the resource

### [Get-MgEducationUserAssignmentSubmissionOutcome](Get-MgEducationUserAssignmentSubmissionOutcome.md)
Get outcomes from education

### [Get-MgEducationUserAssignmentSubmissionOutcomeCount](Get-MgEducationUserAssignmentSubmissionOutcomeCount.md)
Get the number of the resource

### [Get-MgEducationUserAssignmentSubmissionResource](Get-MgEducationUserAssignmentSubmissionResource.md)
Retrieve the properties of a specific resource associated with a submission.
Only teachers, students, and applications with application permissions can perform this operation.
This resource is in the 'working' resource list and should be considered work in process by a student.
This resource is wrapped with a possible pointer back to the assignment resource if it was copied from the assignment.

### [Get-MgEducationUserAssignmentSubmissionResourceCount](Get-MgEducationUserAssignmentSubmissionResourceCount.md)
Get the number of the resource

### [Get-MgEducationUserAssignmentSubmissionSubmittedResource](Get-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Retrieve a submitted resource.
Only teachers, students, and applications with application permissions can perform this operation.
Resources are available to a teacher or an application with application permissions after a student submits it, and are available to the student after the teacher returns the submission.
Teachers can leave notes in some resources.

### [Get-MgEducationUserAssignmentSubmissionSubmittedResourceCount](Get-MgEducationUserAssignmentSubmissionSubmittedResourceCount.md)
Get the number of the resource

### [Get-MgEducationUserClass](Get-MgEducationUserClass.md)
Classes to which the user belongs.
Nullable.

### [Get-MgEducationUserClassCount](Get-MgEducationUserClassCount.md)
Get the number of the resource

### [Get-MgEducationUserCount](Get-MgEducationUserCount.md)
Get the number of the resource

### [Get-MgEducationUserDelta](Get-MgEducationUserDelta.md)
Invoke function delta

### [Get-MgEducationUserMailboxSetting](Get-MgEducationUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgEducationUserRubric](Get-MgEducationUserRubric.md)
Retrieve the properties and relationships of an educationRubric object.
Only teachers and students can perform this operation.

### [Get-MgEducationUserRubricCount](Get-MgEducationUserRubricCount.md)
Get the number of the resource

### [Get-MgEducationUserSchool](Get-MgEducationUserSchool.md)
Schools to which the user belongs.
Nullable.

### [Get-MgEducationUserSchoolCount](Get-MgEducationUserSchoolCount.md)
Get the number of the resource

### [Get-MgEducationUserServiceProvisioningError](Get-MgEducationUserServiceProvisioningError.md)
Get serviceProvisioningErrors property value

### [Get-MgEducationUserServiceProvisioningErrorCount](Get-MgEducationUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgEducationUserTaughtClass](Get-MgEducationUserTaughtClass.md)
Classes for which the user is a teacher.

### [Get-MgEducationUserTaughtClassCount](Get-MgEducationUserTaughtClassCount.md)
Get the number of the resource

### [Invoke-MgReassignEducationClassAssignmentSubmission](Invoke-MgReassignEducationClassAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the Prefer: include-unknown-enum-members header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the reassigned status will be mapped to the returned status, and reassignedDateTime and reassignedBy properties will be mapped to returnedDateTime and returnedBy respectively.
If the header Prefer: include-unknown-enum-members is provided, a reassigned submission retains the reassigned status.
For details, see the examples section.

### [Invoke-MgReassignEducationMeAssignmentSubmission](Invoke-MgReassignEducationMeAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the Prefer: include-unknown-enum-members header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the reassigned status will be mapped to the returned status, and reassignedDateTime and reassignedBy properties will be mapped to returnedDateTime and returnedBy respectively.
If the header Prefer: include-unknown-enum-members is provided, a reassigned submission retains the reassigned status.
For details, see the examples section.

### [Invoke-MgReassignEducationUserAssignmentSubmission](Invoke-MgReassignEducationUserAssignmentSubmission.md)
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the Prefer: include-unknown-enum-members header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the reassigned status will be mapped to the returned status, and reassignedDateTime and reassignedBy properties will be mapped to returnedDateTime and returnedBy respectively.
If the header Prefer: include-unknown-enum-members is provided, a reassigned submission retains the reassigned status.
For details, see the examples section.

### [Invoke-MgReturnEducationClassAssignmentSubmission](Invoke-MgReturnEducationClassAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This action changes the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgReturnEducationMeAssignmentSubmission](Invoke-MgReturnEducationMeAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This action changes the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgReturnEducationUserAssignmentSubmission](Invoke-MgReturnEducationUserAssignmentSubmission.md)
Make the grade and feedback associated with this submission available to the student.
This action changes the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

### [Invoke-MgUnsubmitEducationClassAssignmentSubmission](Invoke-MgUnsubmitEducationClassAssignmentSubmission.md)
Indicate that a student wants to work on the submission of the assignment after it was turned in.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from submitted to working.
During the submit process, all the resources are copied from submittedResources to  workingResources.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgUnsubmitEducationMeAssignmentSubmission](Invoke-MgUnsubmitEducationMeAssignmentSubmission.md)
Indicate that a student wants to work on the submission of the assignment after it was turned in.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from submitted to working.
During the submit process, all the resources are copied from submittedResources to  workingResources.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [Invoke-MgUnsubmitEducationUserAssignmentSubmission](Invoke-MgUnsubmitEducationUserAssignmentSubmission.md)
Indicate that a student wants to work on the submission of the assignment after it was turned in.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from submitted to working.
During the submit process, all the resources are copied from submittedResources to  workingResources.
The teacher will be looking at the working resources list for grading.
A teacher can also unsubmit a student's assignment on their behalf.

### [New-MgEducationClass](New-MgEducationClass.md)
Create a new educationClass object.

### [New-MgEducationClassAssignment](New-MgEducationClassAssignment.md)
Create a new assignment.
Only teachers in a class can create an assignment.
Assignments start in the Draft state, which means that students will not see the assignment until publication.

### [New-MgEducationClassAssignmentCategory](New-MgEducationClassAssignmentCategory.md)
Create a new educationCategory on an educationClass.
Only teachers can perform this operation.

### [New-MgEducationClassAssignmentCategoryByRef](New-MgEducationClassAssignmentCategoryByRef.md)
Add one or more existing educationCategory objects to the specified  educationAssignment.
Only teachers can perform this operation.

### [New-MgEducationClassAssignmentResource](New-MgEducationClassAssignmentResource.md)
Create an assignment resource.
Only teachers can perform this operation.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgEducationClassAssignmentSubmission](New-MgEducationClassAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgEducationClassAssignmentSubmissionOutcome](New-MgEducationClassAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or isn't in that folder, the POST request will fail.

### [New-MgEducationClassAssignmentSubmissionResource](New-MgEducationClassAssignmentSubmissionResource.md)
Add an educationSubmissionResource to a submission resource list.
Only teachers and students can perform this operation.
The operation will not succeed if the allowStudentsToAddResources flag is not set to true.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgEducationClassAssignmentSubmissionSubmittedResource](New-MgEducationClassAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgEducationClassMemberByRef](New-MgEducationClassMemberByRef.md)
Add an educationUser member to an educationClass.

### [New-MgEducationClassTeacherByRef](New-MgEducationClassTeacherByRef.md)
Add a teacher to a class.

### [New-MgEducationMeAssignment](New-MgEducationMeAssignment.md)
Create new navigation property to assignments for education

### [New-MgEducationMeAssignmentCategory](New-MgEducationMeAssignmentCategory.md)
Add one or more existing educationCategory objects to the specified  educationAssignment.
Only teachers can perform this operation.

### [New-MgEducationMeAssignmentCategoryByRef](New-MgEducationMeAssignmentCategoryByRef.md)
Add one or more existing educationCategory objects to the specified  educationAssignment.
Only teachers can perform this operation.

### [New-MgEducationMeAssignmentResource](New-MgEducationMeAssignmentResource.md)
Create an assignment resource.
Only teachers can perform this operation.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgEducationMeAssignmentSubmission](New-MgEducationMeAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgEducationMeAssignmentSubmissionOutcome](New-MgEducationMeAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or isn't in that folder, the POST request will fail.

### [New-MgEducationMeAssignmentSubmissionResource](New-MgEducationMeAssignmentSubmissionResource.md)
Add an educationSubmissionResource to a submission resource list.
Only teachers and students can perform this operation.
The operation will not succeed if the allowStudentsToAddResources flag is not set to true.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgEducationMeAssignmentSubmissionSubmittedResource](New-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgEducationMeRubric](New-MgEducationMeRubric.md)
Create a new educationRubric object.

### [New-MgEducationSchool](New-MgEducationSchool.md)
Create a new educationSchool object.

### [New-MgEducationSchoolClassByRef](New-MgEducationSchoolClassByRef.md)
Add a class to a school.

### [New-MgEducationSchoolUserByRef](New-MgEducationSchoolUserByRef.md)
Add a user to a school.

### [New-MgEducationUser](New-MgEducationUser.md)
Create a new educationUser object.

### [New-MgEducationUserAssignment](New-MgEducationUserAssignment.md)
Create new navigation property to assignments for education

### [New-MgEducationUserAssignmentCategory](New-MgEducationUserAssignmentCategory.md)
Add one or more existing educationCategory objects to the specified  educationAssignment.
Only teachers can perform this operation.

### [New-MgEducationUserAssignmentCategoryByRef](New-MgEducationUserAssignmentCategoryByRef.md)
Add one or more existing educationCategory objects to the specified  educationAssignment.
Only teachers can perform this operation.

### [New-MgEducationUserAssignmentResource](New-MgEducationUserAssignmentResource.md)
Create an assignment resource.
Only teachers can perform this operation.
You can create the following types of assignment resources: Every resource has an @odata.type property to indicate which type of resource is being created.

### [New-MgEducationUserAssignmentSubmission](New-MgEducationUserAssignmentSubmission.md)
Create new navigation property to submissions for education

### [New-MgEducationUserAssignmentSubmissionOutcome](New-MgEducationUserAssignmentSubmissionOutcome.md)
Create a new feedback resource for a submission.
Only a teacher can perform this operation.
To create a new file-based resource, upload the file to the feedback resources folder associated with the assignment.
If the file doesn't exist or isn't in that folder, the POST request will fail.

### [New-MgEducationUserAssignmentSubmissionResource](New-MgEducationUserAssignmentSubmissionResource.md)
Add an educationSubmissionResource to a submission resource list.
Only teachers and students can perform this operation.
The operation will not succeed if the allowStudentsToAddResources flag is not set to true.
To create a new file-based resource, upload the file to the resources folder associated with the submission.
If the file doesn't exist or is not in that folder, the POST request will fail.

### [New-MgEducationUserAssignmentSubmissionSubmittedResource](New-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Create new navigation property to submittedResources for education

### [New-MgEducationUserRubric](New-MgEducationUserRubric.md)
Create a new educationRubric object.

### [Publish-MgEducationClassAssignment](Publish-MgEducationClassAssignment.md)
Publish an education assignment.
Change the state of an educationAssignment from its original draft status to the published status.
You can change the state from draft to scheduled if the assignment is scheduled for a future date.
Only a teacher in the class can make this call.
When an assignment is in draft status, students will not see the assignment, nor will there be any submission objects.
Calling this API creates educationSubmission objects and displays the assignment in each student's list.
The state of the assignment goes back to draft if there is any backend failure during publish process.
To update the properties of a published assignment, see update an assignment.

### [Publish-MgEducationMeAssignment](Publish-MgEducationMeAssignment.md)
Publish an education assignment.
Change the state of an educationAssignment from its original draft status to the published status.
You can change the state from draft to scheduled if the assignment is scheduled for a future date.
Only a teacher in the class can make this call.
When an assignment is in draft status, students will not see the assignment, nor will there be any submission objects.
Calling this API creates educationSubmission objects and displays the assignment in each student's list.
The state of the assignment goes back to draft if there is any backend failure during publish process.
To update the properties of a published assignment, see update an assignment.

### [Publish-MgEducationUserAssignment](Publish-MgEducationUserAssignment.md)
Publish an education assignment.
Change the state of an educationAssignment from its original draft status to the published status.
You can change the state from draft to scheduled if the assignment is scheduled for a future date.
Only a teacher in the class can make this call.
When an assignment is in draft status, students will not see the assignment, nor will there be any submission objects.
Calling this API creates educationSubmission objects and displays the assignment in each student's list.
The state of the assignment goes back to draft if there is any backend failure during publish process.
To update the properties of a published assignment, see update an assignment.

### [Remove-MgEducationClass](Remove-MgEducationClass.md)
Delete an educationClass.
Because a class is also a universal group, deleting a class deletes the group.

### [Remove-MgEducationClassAssignment](Remove-MgEducationClassAssignment.md)
Delete an existing assignment.
Only teachers within a class can delete assignments.

### [Remove-MgEducationClassAssignmentCategory](Remove-MgEducationClassAssignmentCategory.md)
Delete an existing category.
Only teachers can perform this operation.

### [Remove-MgEducationClassAssignmentCategoryByRef](Remove-MgEducationClassAssignmentCategoryByRef.md)
Remove an educationCategory from an educationAssignment.
Only teachers can perform this operation.

### [Remove-MgEducationClassAssignmentDefault](Remove-MgEducationClassAssignmentDefault.md)
Delete navigation property assignmentDefaults for education

### [Remove-MgEducationClassAssignmentResource](Remove-MgEducationClassAssignmentResource.md)
Delete a specific educationAssignmentResource attached to an assignment.
In general, only teachers in the class can remove a resource.
However, teachers can't remove resources marked as 'distributeToStudents', after the assignment has been published to students.

### [Remove-MgEducationClassAssignmentRubric](Remove-MgEducationClassAssignmentRubric.md)
Remove an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.

### [Remove-MgEducationClassAssignmentRubricByRef](Remove-MgEducationClassAssignmentRubricByRef.md)
Remove an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.

### [Remove-MgEducationClassAssignmentSetting](Remove-MgEducationClassAssignmentSetting.md)
Delete navigation property assignmentSettings for education

### [Remove-MgEducationClassAssignmentSubmission](Remove-MgEducationClassAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgEducationClassAssignmentSubmissionOutcome](Remove-MgEducationClassAssignmentSubmissionOutcome.md)
Delete a feedback resource from a submission.
This can only be done by a teacher.

### [Remove-MgEducationClassAssignmentSubmissionResource](Remove-MgEducationClassAssignmentSubmissionResource.md)
Delete an educationSubmissionResource from the submission.
Only teachers and students can perform this operation.
If the resource was copied from the assignment, a new copy of the resource will be created after the current copy is deleted.
This allows you to 'reset' the resource to its original state.
If the resource wasn't copied from the assignment but was added from the student, the resource is deleted.

### [Remove-MgEducationClassAssignmentSubmissionSubmittedResource](Remove-MgEducationClassAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgEducationClassMemberByRef](Remove-MgEducationClassMemberByRef.md)
Remove an educationUser from an educationClass.

### [Remove-MgEducationClassTeacherByRef](Remove-MgEducationClassTeacherByRef.md)
Remove a teacher from an educationClass.

### [Remove-MgEducationMe](Remove-MgEducationMe.md)
Delete navigation property me for education

### [Remove-MgEducationMeAssignment](Remove-MgEducationMeAssignment.md)
Delete navigation property assignments for education

### [Remove-MgEducationMeAssignmentCategoryByRef](Remove-MgEducationMeAssignmentCategoryByRef.md)
Remove an educationCategory from an educationAssignment.
Only teachers can perform this operation.

### [Remove-MgEducationMeAssignmentResource](Remove-MgEducationMeAssignmentResource.md)
Delete a specific educationAssignmentResource attached to an assignment.
In general, only teachers in the class can remove a resource.
However, teachers can't remove resources marked as 'distributeToStudents', after the assignment has been published to students.

### [Remove-MgEducationMeAssignmentRubric](Remove-MgEducationMeAssignmentRubric.md)
Remove an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.

### [Remove-MgEducationMeAssignmentRubricByRef](Remove-MgEducationMeAssignmentRubricByRef.md)
Remove an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.

### [Remove-MgEducationMeAssignmentSubmission](Remove-MgEducationMeAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgEducationMeAssignmentSubmissionOutcome](Remove-MgEducationMeAssignmentSubmissionOutcome.md)
Delete a feedback resource from a submission.
This can only be done by a teacher.

### [Remove-MgEducationMeAssignmentSubmissionResource](Remove-MgEducationMeAssignmentSubmissionResource.md)
Delete an educationSubmissionResource from the submission.
Only teachers and students can perform this operation.
If the resource was copied from the assignment, a new copy of the resource will be created after the current copy is deleted.
This allows you to 'reset' the resource to its original state.
If the resource wasn't copied from the assignment but was added from the student, the resource is deleted.

### [Remove-MgEducationMeAssignmentSubmissionSubmittedResource](Remove-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgEducationMeRubric](Remove-MgEducationMeRubric.md)
Delete an educationRubric object.
Only teachers can perform this operation.

### [Remove-MgEducationSchool](Remove-MgEducationSchool.md)
Delete a school.

### [Remove-MgEducationSchoolClassByRef](Remove-MgEducationSchoolClassByRef.md)
Delete a class from a school.

### [Remove-MgEducationSchoolUserByRef](Remove-MgEducationSchoolUserByRef.md)
Delete a user from a school.

### [Remove-MgEducationUser](Remove-MgEducationUser.md)
Delete a user.

### [Remove-MgEducationUserAssignment](Remove-MgEducationUserAssignment.md)
Delete navigation property assignments for education

### [Remove-MgEducationUserAssignmentCategoryByRef](Remove-MgEducationUserAssignmentCategoryByRef.md)
Remove an educationCategory from an educationAssignment.
Only teachers can perform this operation.

### [Remove-MgEducationUserAssignmentResource](Remove-MgEducationUserAssignmentResource.md)
Delete a specific educationAssignmentResource attached to an assignment.
In general, only teachers in the class can remove a resource.
However, teachers can't remove resources marked as 'distributeToStudents', after the assignment has been published to students.

### [Remove-MgEducationUserAssignmentRubric](Remove-MgEducationUserAssignmentRubric.md)
Remove an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.

### [Remove-MgEducationUserAssignmentRubricByRef](Remove-MgEducationUserAssignmentRubricByRef.md)
Remove an educationRubric from an educationAssignment.
This method doesn't delete the rubric itself and can only be performed by teachers.

### [Remove-MgEducationUserAssignmentSubmission](Remove-MgEducationUserAssignmentSubmission.md)
Delete navigation property submissions for education

### [Remove-MgEducationUserAssignmentSubmissionOutcome](Remove-MgEducationUserAssignmentSubmissionOutcome.md)
Delete a feedback resource from a submission.
This can only be done by a teacher.

### [Remove-MgEducationUserAssignmentSubmissionResource](Remove-MgEducationUserAssignmentSubmissionResource.md)
Delete an educationSubmissionResource from the submission.
Only teachers and students can perform this operation.
If the resource was copied from the assignment, a new copy of the resource will be created after the current copy is deleted.
This allows you to 'reset' the resource to its original state.
If the resource wasn't copied from the assignment but was added from the student, the resource is deleted.

### [Remove-MgEducationUserAssignmentSubmissionSubmittedResource](Remove-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Delete navigation property submittedResources for education

### [Remove-MgEducationUserRubric](Remove-MgEducationUserRubric.md)
Delete an educationRubric object.
Only teachers can perform this operation.

### [Set-MgEducationClassAssignmentRubricByRef](Set-MgEducationClassAssignmentRubricByRef.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.

### [Set-MgEducationClassAssignmentSubmissionUpResourceFolder](Set-MgEducationClassAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Only teachers and students can perform this operation.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgEducationClassAssignmentUpFeedbackResourceFolder](Set-MgEducationClassAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
Only teachers can perform this operation.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgEducationClassAssignmentUpResourceFolder](Set-MgEducationClassAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
Only teachers can perform this operation.
The teacher determines the resources to upload in the assignment's folder.

### [Set-MgEducationMeAssignmentRubricByRef](Set-MgEducationMeAssignmentRubricByRef.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.

### [Set-MgEducationMeAssignmentSubmissionUpResourceFolder](Set-MgEducationMeAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Only teachers and students can perform this operation.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgEducationMeAssignmentUpFeedbackResourceFolder](Set-MgEducationMeAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
Only teachers can perform this operation.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgEducationMeAssignmentUpResourceFolder](Set-MgEducationMeAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
Only teachers can perform this operation.
The teacher determines the resources to upload in the assignment's folder.

### [Set-MgEducationUserAssignmentRubricByRef](Set-MgEducationUserAssignmentRubricByRef.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.

### [Set-MgEducationUserAssignmentSubmissionUpResourceFolder](Set-MgEducationUserAssignmentSubmissionUpResourceFolder.md)
Trigger the creation of the SharePoint resource folder where all file-based resources (Word, Excel, and so on) should be uploaded for a given submission.
Only teachers and students can perform this operation.
Note that files must be located in this folder in order to be added as resources.
Only a student in the class can determine what files to upload in a given submission-level resource folder.

### [Set-MgEducationUserAssignmentUpFeedbackResourceFolder](Set-MgEducationUserAssignmentUpFeedbackResourceFolder.md)
Create a SharePoint folder to upload feedback files for a given educationSubmission.
Only teachers can perform this operation.
The teacher determines the resources to upload in the feedback resources folder of a submission.

### [Set-MgEducationUserAssignmentUpResourceFolder](Set-MgEducationUserAssignmentUpResourceFolder.md)
Create a SharePoint folder to upload files for a given educationAssignment.
Only teachers can perform this operation.
The teacher determines the resources to upload in the assignment's folder.

### [Submit-MgEducationClassAssignmentSubmission](Submit-MgEducationClassAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from working to submitted.
During the submit process, all the resources are copied to the submittedResources bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Submit-MgEducationMeAssignmentSubmission](Submit-MgEducationMeAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from working to submitted.
During the submit process, all the resources are copied to the submittedResources bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Submit-MgEducationUserAssignmentSubmission](Submit-MgEducationUserAssignmentSubmission.md)
Indicate that a student is done with the work and is ready to hand in the assignment.
Only teachers, students, and applications with application permissions can perform this operation.
This method changes the status of the submission from working to submitted.
During the submit process, all the resources are copied to the submittedResources bucket.
The teacher will be looking at the submitted resources list for grading.
A teacher can also submit a student's assignment on their behalf.

### [Update-MgEducationClass](Update-MgEducationClass.md)
Update the properties of an educationClass object.

### [Update-MgEducationClassAssignment](Update-MgEducationClassAssignment.md)
Update an educationAssignment object.
Only teachers can perform this action.
Alternatively, request to change the status of an assignment with publish action.
Don't use a PATCH operation for this purpose.

### [Update-MgEducationClassAssignmentCategory](Update-MgEducationClassAssignmentCategory.md)
Update the navigation property assignmentCategories in education

### [Update-MgEducationClassAssignmentDefault](Update-MgEducationClassAssignmentDefault.md)
Update the properties of an educationAssignmentDefaults object.
Only teachers can update these settings.

### [Update-MgEducationClassAssignmentResource](Update-MgEducationClassAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgEducationClassAssignmentRubric](Update-MgEducationClassAssignmentRubric.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.

### [Update-MgEducationClassAssignmentSetting](Update-MgEducationClassAssignmentSetting.md)
Update the properties of an educationAssignmentSettings object.
Only teachers can update these settings.

### [Update-MgEducationClassAssignmentSubmission](Update-MgEducationClassAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgEducationClassAssignmentSubmissionOutcome](Update-MgEducationClassAssignmentSubmissionOutcome.md)
Update the properties of an educationOutcome object.
Only teachers can perform this operation.

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
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.

### [Update-MgEducationMeAssignmentSubmission](Update-MgEducationMeAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgEducationMeAssignmentSubmissionOutcome](Update-MgEducationMeAssignmentSubmissionOutcome.md)
Update the properties of an educationOutcome object.
Only teachers can perform this operation.

### [Update-MgEducationMeAssignmentSubmissionResource](Update-MgEducationMeAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgEducationMeAssignmentSubmissionSubmittedResource](Update-MgEducationMeAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgEducationMeRubric](Update-MgEducationMeRubric.md)
Update the properties of an educationRubric object.
Only teachers can perform this operation.
Updating a rubric attached to an assignment (PATCH /education/classes/{class-id}/assignments/{assignment-id}/rubric) is only possible before the assignment is published, and what is updated is actually the original rubric that exists under /education/users/{id}/rubrics.
After the assignment is published, an immutable copy of the rubric is made that is attached to that specific assignment.
That rubric can be retrieved using GET /education/classes/{class-id}/assignments/{assignment-id}/rubric, but it cannot be updated.

### [Update-MgEducationMeUserMailboxSetting](Update-MgEducationMeUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgEducationRoot](Update-MgEducationRoot.md)
Update education

### [Update-MgEducationSchool](Update-MgEducationSchool.md)
Update the properties of an educationSchool object.

### [Update-MgEducationSchoolAdministrativeUnit](Update-MgEducationSchoolAdministrativeUnit.md)
Update the navigation property administrativeUnit in education

### [Update-MgEducationUser](Update-MgEducationUser.md)
Update the properties of an educationUser object.

### [Update-MgEducationUserAssignment](Update-MgEducationUserAssignment.md)
Update the navigation property assignments in education

### [Update-MgEducationUserAssignmentResource](Update-MgEducationUserAssignmentResource.md)
Update the navigation property resources in education

### [Update-MgEducationUserAssignmentRubric](Update-MgEducationUserAssignmentRubric.md)
Attach an existing educationRubric object to an educationAssignment.
Only teachers can perform this operation.

### [Update-MgEducationUserAssignmentSubmission](Update-MgEducationUserAssignmentSubmission.md)
Update the navigation property submissions in education

### [Update-MgEducationUserAssignmentSubmissionOutcome](Update-MgEducationUserAssignmentSubmissionOutcome.md)
Update the properties of an educationOutcome object.
Only teachers can perform this operation.

### [Update-MgEducationUserAssignmentSubmissionResource](Update-MgEducationUserAssignmentSubmissionResource.md)
Update the navigation property resources in education

### [Update-MgEducationUserAssignmentSubmissionSubmittedResource](Update-MgEducationUserAssignmentSubmissionSubmittedResource.md)
Update the navigation property submittedResources in education

### [Update-MgEducationUserMailboxSetting](Update-MgEducationUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgEducationUserRubric](Update-MgEducationUserRubric.md)
Update the properties of an educationRubric object.
Only teachers can perform this operation.
Updating a rubric attached to an assignment (PATCH /education/classes/{class-id}/assignments/{assignment-id}/rubric) is only possible before the assignment is published, and what is updated is actually the original rubric that exists under /education/users/{id}/rubrics.
After the assignment is published, an immutable copy of the rubric is made that is attached to that specific assignment.
That rubric can be retrieved using GET /education/classes/{class-id}/assignments/{assignment-id}/rubric, but it cannot be updated.

