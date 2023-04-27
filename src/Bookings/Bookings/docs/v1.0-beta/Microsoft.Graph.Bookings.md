---
Module Name: Microsoft.Graph.Bookings
Module Guid: 26172121-28dd-48fe-b31a-7a171585aa19
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Bookings Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Bookings Cmdlets
### [Get-MgBookingBusiness](Get-MgBookingBusiness.md)
Get the properties and relationships of a bookingBusiness object.

### [Get-MgBookingBusinessAppointment](Get-MgBookingBusinessAppointment.md)
All the appointments of this business.
Read-only.
Nullable.

### [Get-MgBookingBusinessCalendarView](Get-MgBookingBusinessCalendarView.md)
The set of appointments of this business in a specified date range.
Read-only.
Nullable.

### [Get-MgBookingBusinessCustomer](Get-MgBookingBusinessCustomer.md)
All the customers of this business.
Read-only.
Nullable.

### [Get-MgBookingBusinessCustomQuestion](Get-MgBookingBusinessCustomQuestion.md)
All the custom questions of this business.
Read-only.
Nullable.

### [Get-MgBookingBusinessService](Get-MgBookingBusinessService.md)
All the services offered by this business.
Read-only.
Nullable.

### [Get-MgBookingBusinessStaffAvailability](Get-MgBookingBusinessStaffAvailability.md)
Invoke action getStaffAvailability

### [Get-MgBookingBusinessStaffMember](Get-MgBookingBusinessStaffMember.md)
All the staff members that provide services in this business.
Read-only.
Nullable.

### [Get-MgBookingCurrency](Get-MgBookingCurrency.md)
Get the properties of a bookingCurrency object that is available to a Microsoft Bookings business.
Use the **id** property, which is the currency code, to specify the currency.

### [Get-MgBusinessScenario](Get-MgBusinessScenario.md)
Get businessScenarios from solutions

### [Get-MgBusinessScenarioPlanner](Get-MgBusinessScenarioPlanner.md)
Planner content related to the scenario.

### [Get-MgBusinessScenarioPlannerPlan](Get-MgBusinessScenarioPlannerPlan.md)
Invoke action getPlan

### [Get-MgBusinessScenarioPlannerPlanConfiguration](Get-MgBusinessScenarioPlannerPlanConfiguration.md)
The configuration of Planner plans that will be created for the scenario.

### [Get-MgBusinessScenarioPlannerPlanConfigurationLocalization](Get-MgBusinessScenarioPlannerPlanConfigurationLocalization.md)
Localized names for the plan configuration.

### [Get-MgBusinessScenarioPlannerTask](Get-MgBusinessScenarioPlannerTask.md)
The Planner tasks for the scenario.

### [Get-MgBusinessScenarioPlannerTaskConfiguration](Get-MgBusinessScenarioPlannerTaskConfiguration.md)
The configuration of Planner tasks that will be created for the scenario.

### [New-MgBookingBusiness](New-MgBookingBusiness.md)
Create a new Microsoft Bookings business in a tenant.
This is the first step in setting up a Bookings business where you must specify the business display name.
You can include other information such as business address, web site address, and scheduling policy, or set that information later by updating the **bookingBusiness**.

### [New-MgBookingBusinessAppointment](New-MgBookingBusinessAppointment.md)
Create new navigation property to appointments for bookingBusinesses

### [New-MgBookingBusinessCalendarView](New-MgBookingBusinessCalendarView.md)
Create new navigation property to calendarView for bookingBusinesses

### [New-MgBookingBusinessCustomer](New-MgBookingBusinessCustomer.md)
Create new navigation property to customers for bookingBusinesses

### [New-MgBookingBusinessCustomQuestion](New-MgBookingBusinessCustomQuestion.md)
Create new navigation property to customQuestions for bookingBusinesses

### [New-MgBookingBusinessService](New-MgBookingBusinessService.md)
Create new navigation property to services for bookingBusinesses

### [New-MgBookingBusinessStaffMember](New-MgBookingBusinessStaffMember.md)
Create new navigation property to staffMembers for bookingBusinesses

### [New-MgBookingCurrency](New-MgBookingCurrency.md)
Add new entity to bookingCurrencies

### [New-MgBusinessScenario](New-MgBusinessScenario.md)
Create new navigation property to businessScenarios for solutions

### [New-MgBusinessScenarioPlannerPlanConfigurationLocalization](New-MgBusinessScenarioPlannerPlanConfigurationLocalization.md)
Create new navigation property to localizations for solutions

### [New-MgBusinessScenarioPlannerTask](New-MgBusinessScenarioPlannerTask.md)
Create new navigation property to tasks for solutions

### [Publish-MgBookingBusiness](Publish-MgBookingBusiness.md)
Makes the scheduling page of this business available to the general public.

### [Remove-MgBookingBusiness](Remove-MgBookingBusiness.md)
Delete a bookingBusiness object.

### [Remove-MgBookingBusinessAppointment](Remove-MgBookingBusinessAppointment.md)
Delete navigation property appointments for bookingBusinesses

### [Remove-MgBookingBusinessCalendarView](Remove-MgBookingBusinessCalendarView.md)
Delete navigation property calendarView for bookingBusinesses

### [Remove-MgBookingBusinessCustomer](Remove-MgBookingBusinessCustomer.md)
Delete navigation property customers for bookingBusinesses

### [Remove-MgBookingBusinessCustomQuestion](Remove-MgBookingBusinessCustomQuestion.md)
Delete navigation property customQuestions for bookingBusinesses

### [Remove-MgBookingBusinessService](Remove-MgBookingBusinessService.md)
Delete navigation property services for bookingBusinesses

### [Remove-MgBookingBusinessStaffMember](Remove-MgBookingBusinessStaffMember.md)
Delete navigation property staffMembers for bookingBusinesses

### [Remove-MgBookingCurrency](Remove-MgBookingCurrency.md)
Delete entity from bookingCurrencies

### [Remove-MgBusinessScenario](Remove-MgBusinessScenario.md)
Delete navigation property businessScenarios for solutions

### [Remove-MgBusinessScenarioPlanner](Remove-MgBusinessScenarioPlanner.md)
Delete navigation property planner for solutions

### [Remove-MgBusinessScenarioPlannerPlanConfiguration](Remove-MgBusinessScenarioPlannerPlanConfiguration.md)
Delete navigation property planConfiguration for solutions

### [Remove-MgBusinessScenarioPlannerPlanConfigurationLocalization](Remove-MgBusinessScenarioPlannerPlanConfigurationLocalization.md)
Delete navigation property localizations for solutions

### [Remove-MgBusinessScenarioPlannerTask](Remove-MgBusinessScenarioPlannerTask.md)
Delete navigation property tasks for solutions

### [Remove-MgBusinessScenarioPlannerTaskConfiguration](Remove-MgBusinessScenarioPlannerTaskConfiguration.md)
Delete navigation property taskConfiguration for solutions

### [Stop-MgBookingBusinessAppointment](Stop-MgBookingBusinessAppointment.md)
Cancels the giving booking appointment, sending a message to the involved parties.

### [Stop-MgBookingBusinessCalendarView](Stop-MgBookingBusinessCalendarView.md)
Cancels the giving booking appointment, sending a message to the involved parties.

### [Unpublish-MgBookingBusiness](Unpublish-MgBookingBusiness.md)
Prevents the general public from seeing the scheduling page of this business.

### [Update-MgBookingBusiness](Update-MgBookingBusiness.md)
Update the properties of a bookingBusiness object.

### [Update-MgBookingBusinessAppointment](Update-MgBookingBusinessAppointment.md)
Update the navigation property appointments in bookingBusinesses

### [Update-MgBookingBusinessCalendarView](Update-MgBookingBusinessCalendarView.md)
Update the navigation property calendarView in bookingBusinesses

### [Update-MgBookingBusinessCustomer](Update-MgBookingBusinessCustomer.md)
Update the navigation property customers in bookingBusinesses

### [Update-MgBookingBusinessCustomQuestion](Update-MgBookingBusinessCustomQuestion.md)
Update the navigation property customQuestions in bookingBusinesses

### [Update-MgBookingBusinessService](Update-MgBookingBusinessService.md)
Update the navigation property services in bookingBusinesses

### [Update-MgBookingBusinessStaffMember](Update-MgBookingBusinessStaffMember.md)
Update the navigation property staffMembers in bookingBusinesses

### [Update-MgBookingCurrency](Update-MgBookingCurrency.md)
Update entity in bookingCurrencies

### [Update-MgBusinessScenario](Update-MgBusinessScenario.md)
Update the navigation property businessScenarios in solutions

### [Update-MgBusinessScenarioPlanner](Update-MgBusinessScenarioPlanner.md)
Update the navigation property planner in solutions

### [Update-MgBusinessScenarioPlannerPlanConfiguration](Update-MgBusinessScenarioPlannerPlanConfiguration.md)
Update the navigation property planConfiguration in solutions

### [Update-MgBusinessScenarioPlannerPlanConfigurationLocalization](Update-MgBusinessScenarioPlannerPlanConfigurationLocalization.md)
Update the navigation property localizations in solutions

### [Update-MgBusinessScenarioPlannerTask](Update-MgBusinessScenarioPlannerTask.md)
Update the navigation property tasks in solutions

### [Update-MgBusinessScenarioPlannerTaskConfiguration](Update-MgBusinessScenarioPlannerTaskConfiguration.md)
Update the navigation property taskConfiguration in solutions

