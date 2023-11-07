---
Module Name: Microsoft.Graph.Bookings
Module Guid: 1b7badbd-481f-4c53-bed8-4c4c42d0b297
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.bookings
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Bookings Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Bookings Cmdlets
### [Get-MgBookingBusiness](Get-MgBookingBusiness.md)
Get the properties and relationships of a bookingBusiness object.
This API is available in the following national cloud deployments.

### [Get-MgBookingBusinessAppointment](Get-MgBookingBusinessAppointment.md)
Get the properties and relationships of a bookingAppointment object in the specified bookingBusiness.
The startDateTime and endDateTime properties are always returned in UTC.
This API is available in the following national cloud deployments.

### [Get-MgBookingBusinessAppointmentCount](Get-MgBookingBusinessAppointmentCount.md)
Get the number of the resource

### [Get-MgBookingBusinessCalendarView](Get-MgBookingBusinessCalendarView.md)
The set of appointments of this business in a specified date range.
Read-only.
Nullable.

### [Get-MgBookingBusinessCalendarViewCount](Get-MgBookingBusinessCalendarViewCount.md)
Get the number of the resource

### [Get-MgBookingBusinessCount](Get-MgBookingBusinessCount.md)
Get the number of the resource

### [Get-MgBookingBusinessCustomer](Get-MgBookingBusinessCustomer.md)
Get the properties and relationships of a bookingCustomer object.
This API is available in the following national cloud deployments.

### [Get-MgBookingBusinessCustomerCount](Get-MgBookingBusinessCustomerCount.md)
Get the number of the resource

### [Get-MgBookingBusinessCustomQuestion](Get-MgBookingBusinessCustomQuestion.md)
Read the properties and relationships of a bookingCustomQuestion object.
This API is available in the following national cloud deployments.

### [Get-MgBookingBusinessCustomQuestionCount](Get-MgBookingBusinessCustomQuestionCount.md)
Get the number of the resource

### [Get-MgBookingBusinessService](Get-MgBookingBusinessService.md)
Get the properties and relationships of a bookingService object in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [Get-MgBookingBusinessServiceCount](Get-MgBookingBusinessServiceCount.md)
Get the number of the resource

### [Get-MgBookingBusinessStaffAvailability](Get-MgBookingBusinessStaffAvailability.md)
Get the availability information of staff members of a Microsoft Bookings calendar.
This API is available in the following national cloud deployments.

### [Get-MgBookingBusinessStaffMember](Get-MgBookingBusinessStaffMember.md)
Get the properties and relationships of a bookingStaffMember in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [Get-MgBookingBusinessStaffMemberCount](Get-MgBookingBusinessStaffMemberCount.md)
Get the number of the resource

### [Get-MgBookingCurrency](Get-MgBookingCurrency.md)
Get the properties of a bookingCurrency object that is available to a Microsoft Bookings business.
Use the id property, which is the currency code, to specify the currency.
This API is available in the following national cloud deployments.

### [Get-MgBookingCurrencyCount](Get-MgBookingCurrencyCount.md)
Get the number of the resource

### [New-MgBookingBusiness](New-MgBookingBusiness.md)
Create a new Microsoft Bookings business in a tenant.
This is the first step in setting up a Bookings business where you must specify the business display name.
You can include other information such as business address, web site address, and scheduling policy, or set that information later by updating the bookingBusiness.
This API is available in the following national cloud deployments.

### [New-MgBookingBusinessAppointment](New-MgBookingBusinessAppointment.md)
Create a new bookingAppointment for the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [New-MgBookingBusinessCalendarView](New-MgBookingBusinessCalendarView.md)
Create new navigation property to calendarView for solutions

### [New-MgBookingBusinessCustomer](New-MgBookingBusinessCustomer.md)
Create a new bookingCustomer object.
This API is available in the following national cloud deployments.

### [New-MgBookingBusinessCustomQuestion](New-MgBookingBusinessCustomQuestion.md)
Create a new bookingCustomQuestion object.
This API is available in the following national cloud deployments.

### [New-MgBookingBusinessService](New-MgBookingBusinessService.md)
Create a new bookingService for the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [New-MgBookingBusinessStaffMember](New-MgBookingBusinessStaffMember.md)
Create a new bookingStaffMember in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [New-MgBookingCurrency](New-MgBookingCurrency.md)
Create new navigation property to bookingCurrencies for solutions

### [Publish-MgBookingBusiness](Publish-MgBookingBusiness.md)
Make the scheduling page of a business available to external customers.
Set the isPublished property to true, and the publicUrl property to the URL of the scheduling page.
This API is available in the following national cloud deployments.

### [Remove-MgBookingBusiness](Remove-MgBookingBusiness.md)
Delete a bookingBusiness object.
This API is available in the following national cloud deployments.

### [Remove-MgBookingBusinessAppointment](Remove-MgBookingBusinessAppointment.md)
Delete a bookingAppointment in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [Remove-MgBookingBusinessCalendarView](Remove-MgBookingBusinessCalendarView.md)
Delete navigation property calendarView for solutions

### [Remove-MgBookingBusinessCustomer](Remove-MgBookingBusinessCustomer.md)
Delete the specified bookingCustomer object.
This API is available in the following national cloud deployments.

### [Remove-MgBookingBusinessCustomQuestion](Remove-MgBookingBusinessCustomQuestion.md)
Delete a bookingCustomQuestion object.
This API is available in the following national cloud deployments.

### [Remove-MgBookingBusinessService](Remove-MgBookingBusinessService.md)
Delete a bookingService object in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [Remove-MgBookingBusinessStaffMember](Remove-MgBookingBusinessStaffMember.md)
Delete a bookingStaffMember in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [Remove-MgBookingCurrency](Remove-MgBookingCurrency.md)
Delete navigation property bookingCurrencies for solutions

### [Stop-MgBookingBusinessAppointment](Stop-MgBookingBusinessAppointment.md)
Cancel the specified bookingAppointment in the specified bookingBusiness and send a message to the involved customer and staff members.
This API is available in the following national cloud deployments.

### [Stop-MgBookingBusinessCalendarView](Stop-MgBookingBusinessCalendarView.md)
Cancel the specified bookingAppointment in the specified bookingBusiness and send a message to the involved customer and staff members.
This API is available in the following national cloud deployments.

### [Unpublish-MgBookingBusiness](Unpublish-MgBookingBusiness.md)
Make the scheduling page of this business not available to external customers.
Set the isPublished property to false, and the publicUrl property to null.
This API is available in the following national cloud deployments.

### [Update-MgBookingBusiness](Update-MgBookingBusiness.md)
Update the properties of a bookingBusiness object.
This API is available in the following national cloud deployments.

### [Update-MgBookingBusinessAppointment](Update-MgBookingBusinessAppointment.md)
Update the properties of a bookingAppointment object in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [Update-MgBookingBusinessCalendarView](Update-MgBookingBusinessCalendarView.md)
Update the navigation property calendarView in solutions

### [Update-MgBookingBusinessCustomer](Update-MgBookingBusinessCustomer.md)
Update the properties of a bookingCustomer object.
This API is available in the following national cloud deployments.

### [Update-MgBookingBusinessCustomQuestion](Update-MgBookingBusinessCustomQuestion.md)
Update the properties of a bookingCustomQuestion object.
This API is available in the following national cloud deployments.

### [Update-MgBookingBusinessService](Update-MgBookingBusinessService.md)
Update the properties of a bookingService object in the specified bookingBusiness.
The following are some examples you can customize for a service:\n- Price\n- Typical length of an appointment\n- Reminders\n- Any time buffer to set up before or finish up after the service\n- Scheduling policy parameters, such as minimum notice to book or cancel, and whether customers can select specific staff members for an appointment.
This API is available in the following national cloud deployments.

### [Update-MgBookingBusinessStaffMember](Update-MgBookingBusinessStaffMember.md)
Update the properties of a bookingStaffMember in the specified bookingBusiness.
This API is available in the following national cloud deployments.

### [Update-MgBookingCurrency](Update-MgBookingCurrency.md)
Update the navigation property bookingCurrencies in solutions

