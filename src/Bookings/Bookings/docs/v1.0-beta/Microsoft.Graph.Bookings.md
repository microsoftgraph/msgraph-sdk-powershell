---
Module Name: Microsoft.Graph.Bookings
Module Guid: ccf0e24e-17c4-4bdc-ad65-e05b030adf51
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
Get the availability information of staff members of a Microsoft Bookings calendar.

### [Get-MgBookingBusinessStaffMember](Get-MgBookingBusinessStaffMember.md)
All the staff members that provide services in this business.
Read-only.
Nullable.

### [Get-MgBookingCurrency](Get-MgBookingCurrency.md)
Get the properties of a bookingCurrency object that is available to a Microsoft Bookings business.
Use the **id** property, which is the currency code, to specify the currency.

### [New-MgBookingBusiness](New-MgBookingBusiness.md)
Create a new Microsoft Bookings business in a tenant.
This is the first step in setting up a Bookings business where you must specify the business display name.
You can include other information such as business address, web site address, and scheduling policy, or set that information later by updating the **bookingBusiness**.

### [New-MgBookingBusinessAppointment](New-MgBookingBusinessAppointment.md)
Create a new bookingAppointment for the specified bookingBusiness.

### [New-MgBookingBusinessCalendarView](New-MgBookingBusinessCalendarView.md)
Create new navigation property to calendarView for bookingBusinesses

### [New-MgBookingBusinessCustomer](New-MgBookingBusinessCustomer.md)
Create a new bookingCustomer object.

### [New-MgBookingBusinessCustomQuestion](New-MgBookingBusinessCustomQuestion.md)
Create new navigation property to customQuestions for bookingBusinesses

### [New-MgBookingBusinessService](New-MgBookingBusinessService.md)
Create a new bookingService for the specified bookingBusiness.

### [New-MgBookingBusinessStaffMember](New-MgBookingBusinessStaffMember.md)
Create a new staff member in the specified bookingBusiness.

### [New-MgBookingCurrency](New-MgBookingCurrency.md)
Add new entity to bookingCurrencies

### [Publish-MgBookingBusiness](Publish-MgBookingBusiness.md)
Make the scheduling page of this business available to external customers.
Set the **isPublished** property to true, and **publicUrl** property to the URL of the scheduling page.

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

### [Stop-MgBookingBusinessAppointment](Stop-MgBookingBusinessAppointment.md)
Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.

### [Stop-MgBookingBusinessCalendarView](Stop-MgBookingBusinessCalendarView.md)
Cancel the specified bookingAppointment in the specified bookingBusiness, and send a message to the involved customer and staff members.

### [Unpublish-MgBookingBusiness](Unpublish-MgBookingBusiness.md)
Make the scheduling page of this business not available to external customers.
Set the **isPublished** property to false, and **publicUrl** property to null.

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

