---
Module Name: Microsoft.Graph.Beta.Bookings
Module Guid: d170c3a2-06d3-4127-bfd7-34bb17711c2a
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.bookings
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Bookings Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Bookings Cmdlets
### [Get-MgBetaBookingBusiness](Get-MgBetaBookingBusiness.md)
Get the properties and relationships of a bookingBusiness object.

### [Get-MgBetaBookingBusinessAppointment](Get-MgBetaBookingBusinessAppointment.md)
All the appointments of this business.
Read-only.
Nullable.

### [Get-MgBetaBookingBusinessCalendarView](Get-MgBetaBookingBusinessCalendarView.md)
The set of appointments of this business in a specified date range.
Read-only.
Nullable.

### [Get-MgBetaBookingBusinessCustomer](Get-MgBetaBookingBusinessCustomer.md)
All the customers of this business.
Read-only.
Nullable.

### [Get-MgBetaBookingBusinessCustomQuestion](Get-MgBetaBookingBusinessCustomQuestion.md)
All the custom questions of this business.
Read-only.
Nullable.

### [Get-MgBetaBookingBusinessService](Get-MgBetaBookingBusinessService.md)
All the services offered by this business.
Read-only.
Nullable.

### [Get-MgBetaBookingBusinessStaffAvailability](Get-MgBetaBookingBusinessStaffAvailability.md)
Get the availability information of staff members of a Microsoft Bookings calendar.

### [Get-MgBetaBookingBusinessStaffMember](Get-MgBetaBookingBusinessStaffMember.md)
All the staff members that provide services in this business.
Read-only.
Nullable.

### [Get-MgBetaBookingCurrency](Get-MgBetaBookingCurrency.md)
Get the properties of a bookingCurrency object that is available to a Microsoft Bookings business.
Use the **id** property, which is the currency code, to specify the currency.

### [Get-MgBetaBusinessScenario](Get-MgBetaBusinessScenario.md)
Get businessScenarios from solutions

### [Get-MgBetaBusinessScenarioPlanner](Get-MgBetaBusinessScenarioPlanner.md)
Get planner from solutions

### [Get-MgBetaBusinessScenarioPlannerPlan](Get-MgBetaBusinessScenarioPlannerPlan.md)
Invoke action getPlan

### [Get-MgBetaBusinessScenarioPlannerPlanConfiguration](Get-MgBetaBusinessScenarioPlannerPlanConfiguration.md)
Get planConfiguration from solutions

### [Get-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization](Get-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization.md)
Get localizations from solutions

### [Get-MgBetaBusinessScenarioPlannerTask](Get-MgBetaBusinessScenarioPlannerTask.md)
Get tasks from solutions

### [Get-MgBetaBusinessScenarioPlannerTaskConfiguration](Get-MgBetaBusinessScenarioPlannerTaskConfiguration.md)
Get taskConfiguration from solutions

### [New-MgBetaBookingBusiness](New-MgBetaBookingBusiness.md)
Create a new Microsoft Bookings business in a tenant.
This is the first step in setting up a Bookings business where you must specify the business display name.
You can include other information such as business address, web site address, and scheduling policy, or set that information later by updating the **bookingBusiness**.

### [New-MgBetaBookingBusinessAppointment](New-MgBetaBookingBusinessAppointment.md)
Create a new bookingAppointment for the specified bookingBusiness.

### [New-MgBetaBookingBusinessCalendarView](New-MgBetaBookingBusinessCalendarView.md)
Create new navigation property to calendarView for bookingBusinesses

### [New-MgBetaBookingBusinessCustomer](New-MgBetaBookingBusinessCustomer.md)
Create a new bookingCustomer object.

### [New-MgBetaBookingBusinessCustomQuestion](New-MgBetaBookingBusinessCustomQuestion.md)
Create new navigation property to customQuestions for bookingBusinesses

### [New-MgBetaBookingBusinessService](New-MgBetaBookingBusinessService.md)
Create a new bookingService for the specified bookingBusiness.

### [New-MgBetaBookingBusinessStaffMember](New-MgBetaBookingBusinessStaffMember.md)
Create a new staff member in the specified bookingBusiness.

### [New-MgBetaBookingCurrency](New-MgBetaBookingCurrency.md)
Add new entity to bookingCurrencies

### [New-MgBetaBusinessScenario](New-MgBetaBusinessScenario.md)
Create new navigation property to businessScenarios for solutions

### [New-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization](New-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization.md)
Create new navigation property to localizations for solutions

### [New-MgBetaBusinessScenarioPlannerTask](New-MgBetaBusinessScenarioPlannerTask.md)
Create new navigation property to tasks for solutions

### [Publish-MgBetaBookingBusiness](Publish-MgBetaBookingBusiness.md)
Make the scheduling page of this business available to external customers.
Set the **isPublished** property to true, and **publicUrl** property to the URL of the scheduling page.

### [Remove-MgBetaBookingBusiness](Remove-MgBetaBookingBusiness.md)
Delete a bookingBusiness object.

### [Remove-MgBetaBookingBusinessAppointment](Remove-MgBetaBookingBusinessAppointment.md)
Delete navigation property appointments for bookingBusinesses

### [Remove-MgBetaBookingBusinessCalendarView](Remove-MgBetaBookingBusinessCalendarView.md)
Delete navigation property calendarView for bookingBusinesses

### [Remove-MgBetaBookingBusinessCustomer](Remove-MgBetaBookingBusinessCustomer.md)
Delete navigation property customers for bookingBusinesses

### [Remove-MgBetaBookingBusinessCustomQuestion](Remove-MgBetaBookingBusinessCustomQuestion.md)
Delete navigation property customQuestions for bookingBusinesses

### [Remove-MgBetaBookingBusinessService](Remove-MgBetaBookingBusinessService.md)
Delete navigation property services for bookingBusinesses

### [Remove-MgBetaBookingBusinessStaffMember](Remove-MgBetaBookingBusinessStaffMember.md)
Delete navigation property staffMembers for bookingBusinesses

### [Remove-MgBetaBookingCurrency](Remove-MgBetaBookingCurrency.md)
Delete entity from bookingCurrencies

### [Remove-MgBetaBusinessScenario](Remove-MgBetaBusinessScenario.md)
Delete navigation property businessScenarios for solutions

### [Remove-MgBetaBusinessScenarioPlanner](Remove-MgBetaBusinessScenarioPlanner.md)
Delete navigation property planner for solutions

### [Remove-MgBetaBusinessScenarioPlannerPlanConfiguration](Remove-MgBetaBusinessScenarioPlannerPlanConfiguration.md)
Delete navigation property planConfiguration for solutions

### [Remove-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization](Remove-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization.md)
Delete navigation property localizations for solutions

### [Remove-MgBetaBusinessScenarioPlannerTask](Remove-MgBetaBusinessScenarioPlannerTask.md)
Delete navigation property tasks for solutions

### [Remove-MgBetaBusinessScenarioPlannerTaskConfiguration](Remove-MgBetaBusinessScenarioPlannerTaskConfiguration.md)
Delete navigation property taskConfiguration for solutions

### [Stop-MgBetaBookingBusinessAppointment](Stop-MgBetaBookingBusinessAppointment.md)
Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.

### [Stop-MgBetaBookingBusinessCalendarView](Stop-MgBetaBookingBusinessCalendarView.md)
Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.

### [Unpublish-MgBetaBookingBusiness](Unpublish-MgBetaBookingBusiness.md)
Make the scheduling page of this business not available to external customers.
Set the **isPublished** property to false, and **publicUrl** property to null.

### [Update-MgBetaBookingBusiness](Update-MgBetaBookingBusiness.md)
Update the properties of a bookingBusiness object.

### [Update-MgBetaBookingBusinessAppointment](Update-MgBetaBookingBusinessAppointment.md)
Update the navigation property appointments in bookingBusinesses

### [Update-MgBetaBookingBusinessCalendarView](Update-MgBetaBookingBusinessCalendarView.md)
Update the navigation property calendarView in bookingBusinesses

### [Update-MgBetaBookingBusinessCustomer](Update-MgBetaBookingBusinessCustomer.md)
Update the navigation property customers in bookingBusinesses

### [Update-MgBetaBookingBusinessCustomQuestion](Update-MgBetaBookingBusinessCustomQuestion.md)
Update the navigation property customQuestions in bookingBusinesses

### [Update-MgBetaBookingBusinessService](Update-MgBetaBookingBusinessService.md)
Update the navigation property services in bookingBusinesses

### [Update-MgBetaBookingBusinessStaffMember](Update-MgBetaBookingBusinessStaffMember.md)
Update the navigation property staffMembers in bookingBusinesses

### [Update-MgBetaBookingCurrency](Update-MgBetaBookingCurrency.md)
Update entity in bookingCurrencies

### [Update-MgBetaBusinessScenario](Update-MgBetaBusinessScenario.md)
Update the navigation property businessScenarios in solutions

### [Update-MgBetaBusinessScenarioPlanner](Update-MgBetaBusinessScenarioPlanner.md)
Update the navigation property planner in solutions

### [Update-MgBetaBusinessScenarioPlannerPlanConfiguration](Update-MgBetaBusinessScenarioPlannerPlanConfiguration.md)
Update the navigation property planConfiguration in solutions

### [Update-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization](Update-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization.md)
Update the navigation property localizations in solutions

### [Update-MgBetaBusinessScenarioPlannerTask](Update-MgBetaBusinessScenarioPlannerTask.md)
Update the navigation property tasks in solutions

### [Update-MgBetaBusinessScenarioPlannerTaskConfiguration](Update-MgBetaBusinessScenarioPlannerTaskConfiguration.md)
Update the navigation property taskConfiguration in solutions

