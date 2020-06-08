---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/update-mgfinancialcompanycustomerpaymentcustomer
schema: 2.0.0
---

# Update-MgFinancialCompanyCustomerPaymentCustomer

## SYNOPSIS
Update the navigation property customer in financials

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgFinancialCompanyCustomerPaymentCustomer -CompanyId <String> -CustomerPaymentId <String>
 [-AddressCity <String>] [-AddressCountryLetterCode <String>] [-AddressPostalCode <String>]
 [-AddressState <String>] [-AddressStreet <String>] [-Blocked <String>] [-Code <String>]
 [-CurrencyAmountDecimalPlaces <String>] [-CurrencyAmountRoundingPrecision <Decimal>] [-CurrencyCode <String>]
 [-CurrencyDisplayName <String>] [-CurrencyId <String>] [-CurrencyLastModifiedDateTime <DateTime>]
 [-CurrencySymbol <String>] [-DisplayName <String>] [-Email <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-MicrosoftGraphEntityId <String>] [-Number <String>]
 [-PaymentMethodCode <String>] [-PaymentMethodDisplayName <String>] [-PaymentMethodId <String>]
 [-PaymentMethodId1 <String>] [-PaymentMethodLastModifiedDateTime <DateTime>]
 [-PaymentTermCalculateDiscountOnCreditMemos] [-PaymentTermCode <String>]
 [-PaymentTermDiscountDateCalculation <String>] [-PaymentTermDiscountPercent <Decimal>]
 [-PaymentTermDisplayName <String>] [-PaymentTermDueDateCalculation <String>] [-PaymentTermId <String>]
 [-PaymentTermLastModifiedDateTime <DateTime>] [-PaymentTermsId <String>] [-PhoneNumber <String>]
 [-Picture <IMicrosoftGraphPicture[]>] [-ShipmentMethodCode <String>] [-ShipmentMethodDisplayName <String>]
 [-ShipmentMethodId <String>] [-ShipmentMethodId1 <String>] [-ShipmentMethodLastModifiedDateTime <DateTime>]
 [-TaxAreaDisplayName <String>] [-TaxAreaId <String>] [-TaxLiable] [-TaxRegistrationNumber <String>]
 [-Type <String>] [-Website <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgFinancialCompanyCustomerPaymentCustomer -CompanyId <String> -CustomerPaymentId <String>
 -BodyParameter <IMicrosoftGraphCustomer> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgFinancialCompanyCustomerPaymentCustomer -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphCustomer> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgFinancialCompanyCustomerPaymentCustomer -InputObject <IFinancialsIdentity> [-AddressCity <String>]
 [-AddressCountryLetterCode <String>] [-AddressPostalCode <String>] [-AddressState <String>]
 [-AddressStreet <String>] [-Blocked <String>] [-Code <String>] [-CurrencyAmountDecimalPlaces <String>]
 [-CurrencyAmountRoundingPrecision <Decimal>] [-CurrencyCode <String>] [-CurrencyDisplayName <String>]
 [-CurrencyId <String>] [-CurrencyLastModifiedDateTime <DateTime>] [-CurrencySymbol <String>]
 [-DisplayName <String>] [-Email <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-MicrosoftGraphEntityId <String>] [-Number <String>] [-PaymentMethodCode <String>]
 [-PaymentMethodDisplayName <String>] [-PaymentMethodId <String>] [-PaymentMethodId1 <String>]
 [-PaymentMethodLastModifiedDateTime <DateTime>] [-PaymentTermCalculateDiscountOnCreditMemos]
 [-PaymentTermCode <String>] [-PaymentTermDiscountDateCalculation <String>]
 [-PaymentTermDiscountPercent <Decimal>] [-PaymentTermDisplayName <String>]
 [-PaymentTermDueDateCalculation <String>] [-PaymentTermId <String>]
 [-PaymentTermLastModifiedDateTime <DateTime>] [-PaymentTermsId <String>] [-PhoneNumber <String>]
 [-Picture <IMicrosoftGraphPicture[]>] [-ShipmentMethodCode <String>] [-ShipmentMethodDisplayName <String>]
 [-ShipmentMethodId <String>] [-ShipmentMethodId1 <String>] [-ShipmentMethodLastModifiedDateTime <DateTime>]
 [-TaxAreaDisplayName <String>] [-TaxAreaId <String>] [-TaxLiable] [-TaxRegistrationNumber <String>]
 [-Type <String>] [-Website <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property customer in financials

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AddressCity
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressCountryLetterCode
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressPostalCode
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressState
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddressStreet
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Blocked
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
customer
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomer
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Code
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompanyId
key: company-id of company

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyAmountDecimalPlaces
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyAmountRoundingPrecision
.

```yaml
Type: System.Decimal
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyCode
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencyLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CurrencySymbol
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerPaymentId
key: customerPayment-id of customerPayment

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Email
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IFinancialsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftGraphEntityId
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Number
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentMethodCode
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentMethodDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentMethodId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentMethodId1
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentMethodLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermCalculateDiscountOnCreditMemos
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermCode
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermDiscountDateCalculation
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermDiscountPercent
.

```yaml
Type: System.Decimal
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermDueDateCalculation
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermId
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTermsId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhoneNumber
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Picture
.
To construct, see NOTES section for PICTURE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPicture[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentMethodCode
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentMethodDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentMethodId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentMethodId1
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentMethodLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxAreaDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxAreaId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxLiable
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxRegistrationNumber
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Website
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IFinancialsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomer

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCustomer>: customer
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: 
  - `[AddressCountryLetterCode <String>]`: 
  - `[AddressPostalCode <String>]`: 
  - `[AddressState <String>]`: 
  - `[AddressStreet <String>]`: 
  - `[Blocked <String>]`: 
  - `[Code <String>]`: 
  - `[CurrencyAmountDecimalPlaces <String>]`: 
  - `[CurrencyAmountRoundingPrecision <Decimal?>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyDisplayName <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[CurrencyLastModifiedDateTime <DateTime?>]`: 
  - `[CurrencySymbol <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Email <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[Number <String>]`: 
  - `[PaymentMethodCode <String>]`: 
  - `[PaymentMethodDisplayName <String>]`: 
  - `[PaymentMethodId <String>]`: 
  - `[PaymentMethodId1 <String>]`: Read-only.
  - `[PaymentMethodLastModifiedDateTime <DateTime?>]`: 
  - `[PaymentTermCalculateDiscountOnCreditMemos <Boolean?>]`: 
  - `[PaymentTermCode <String>]`: 
  - `[PaymentTermDiscountDateCalculation <String>]`: 
  - `[PaymentTermDiscountPercent <Decimal?>]`: 
  - `[PaymentTermDisplayName <String>]`: 
  - `[PaymentTermDueDateCalculation <String>]`: 
  - `[PaymentTermId <String>]`: Read-only.
  - `[PaymentTermLastModifiedDateTime <DateTime?>]`: 
  - `[PaymentTermsId <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[ShipmentMethodCode <String>]`: 
  - `[ShipmentMethodDisplayName <String>]`: 
  - `[ShipmentMethodId <String>]`: 
  - `[ShipmentMethodId1 <String>]`: Read-only.
  - `[ShipmentMethodLastModifiedDateTime <DateTime?>]`: 
  - `[TaxAreaDisplayName <String>]`: 
  - `[TaxAreaId <String>]`: 
  - `[TaxLiable <Boolean?>]`: 
  - `[TaxRegistrationNumber <String>]`: 
  - `[Type <String>]`: 
  - `[Website <String>]`: 

INPUTOBJECT <IFinancialsIdentity>: Identity Parameter
  - `[AccountId <String>]`: key: account-id of account
  - `[AgedAccountsPayableId <String>]`: key: agedAccountsPayable-id of agedAccountsPayable
  - `[AgedAccountsReceivableId <String>]`: key: agedAccountsReceivable-id of agedAccountsReceivable
  - `[CompanyId <String>]`: key: company-id of company
  - `[CompanyInformationId <String>]`: key: companyInformation-id of companyInformation
  - `[CountryRegionId <String>]`: key: countryRegion-id of countryRegion
  - `[CurrencyId <String>]`: key: currency-id of currency
  - `[CustomerId <String>]`: key: customer-id of customer
  - `[CustomerPaymentId <String>]`: key: customerPayment-id of customerPayment
  - `[CustomerPaymentJournalId <String>]`: key: customerPaymentJournal-id of customerPaymentJournal
  - `[DimensionId <String>]`: key: dimension-id of dimension
  - `[DimensionValueId <String>]`: key: dimensionValue-id of dimensionValue
  - `[EmployeeId <String>]`: key: employee-id of employee
  - `[GeneralLedgerEntryId <String>]`: key: generalLedgerEntry-id of generalLedgerEntry
  - `[ItemCategoryId <String>]`: key: itemCategory-id of itemCategory
  - `[ItemId <String>]`: key: item-id of item
  - `[JournalId <String>]`: key: journal-id of journal
  - `[JournalLineId <String>]`: key: journalLine-id of journalLine
  - `[PaymentMethodId <String>]`: key: paymentMethod-id of paymentMethod
  - `[PaymentTermId <String>]`: key: paymentTerm-id of paymentTerm
  - `[PictureId <String>]`: key: picture-id of picture
  - `[PurchaseInvoiceId <String>]`: key: purchaseInvoice-id of purchaseInvoice
  - `[PurchaseInvoiceLineId <String>]`: key: purchaseInvoiceLine-id of purchaseInvoiceLine
  - `[SalesCreditMemoId <String>]`: key: salesCreditMemo-id of salesCreditMemo
  - `[SalesCreditMemoLineId <String>]`: key: salesCreditMemoLine-id of salesCreditMemoLine
  - `[SalesInvoiceId <String>]`: key: salesInvoice-id of salesInvoice
  - `[SalesInvoiceLineId <String>]`: key: salesInvoiceLine-id of salesInvoiceLine
  - `[SalesOrderId <String>]`: key: salesOrder-id of salesOrder
  - `[SalesOrderLineId <String>]`: key: salesOrderLine-id of salesOrderLine
  - `[SalesQuoteId <String>]`: key: salesQuote-id of salesQuote
  - `[SalesQuoteLineId <String>]`: key: salesQuoteLine-id of salesQuoteLine
  - `[ShipmentMethodId <String>]`: key: shipmentMethod-id of shipmentMethod
  - `[TaxAreaId <String>]`: key: taxArea-id of taxArea
  - `[TaxGroupId <String>]`: key: taxGroup-id of taxGroup
  - `[UnitOfMeasureId <String>]`: key: unitOfMeasure-id of unitOfMeasure
  - `[VendorId <String>]`: key: vendor-id of vendor

PICTURE <IMicrosoftGraphPicture[]>: .
  - `[Id <String>]`: Read-only.
  - `[Content <Byte[]>]`: 
  - `[ContentType <String>]`: 
  - `[Height <Int32?>]`: 
  - `[Width <Int32?>]`: 

## RELATED LINKS

