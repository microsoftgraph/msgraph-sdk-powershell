---
external help file:
Module Name: Microsoft.Graph.Beta.Financials
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.financials/update-mgbetafinancialcompanycustomerpaymentjournal
schema: 2.0.0
---

# Update-MgBetaFinancialCompanyCustomerPaymentJournal

## SYNOPSIS
Update the navigation property customerPaymentJournals in financials

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaFinancialCompanyCustomerPaymentJournal -CompanyId <String> -CustomerPaymentJournalId <String>
 [-Account <IMicrosoftGraphAccount>] [-AdditionalProperties <Hashtable>] [-BalancingAccountId <String>]
 [-BalancingAccountNumber <String>] [-Code <String>] [-CustomerPayments <IMicrosoftGraphCustomerPayment[]>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaFinancialCompanyCustomerPaymentJournal -CompanyId <String> -CustomerPaymentJournalId <String>
 -BodyParameter <IMicrosoftGraphCustomerPaymentJournal> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaFinancialCompanyCustomerPaymentJournal -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphCustomerPaymentJournal> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaFinancialCompanyCustomerPaymentJournal -InputObject <IFinancialsIdentity>
 [-Account <IMicrosoftGraphAccount>] [-AdditionalProperties <Hashtable>] [-BalancingAccountId <String>]
 [-BalancingAccountNumber <String>] [-Code <String>] [-CustomerPayments <IMicrosoftGraphCustomerPayment[]>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property customerPaymentJournals in financials

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Account
account
To construct, see NOTES section for ACCOUNT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccount
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BalancingAccountId
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

### -BalancingAccountNumber
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
customerPaymentJournal
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomerPaymentJournal
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
The unique identifier of company

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

### -CustomerPaymentJournalId
The unique identifier of customerPaymentJournal

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

### -CustomerPayments
.
To construct, see NOTES section for CUSTOMERPAYMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomerPayment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IFinancialsIdentity
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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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

### Microsoft.Graph.Beta.PowerShell.Models.IFinancialsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomerPaymentJournal

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomerPaymentJournal

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCOUNT <IMicrosoftGraphAccount>`: account
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Blocked <Boolean?>]`: 
  - `[Category <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[SubCategory <String>]`: 

`BODYPARAMETER <IMicrosoftGraphCustomerPaymentJournal>`: customerPaymentJournal
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
  - `[BalancingAccountId <String>]`: 
  - `[BalancingAccountNumber <String>]`: 
  - `[Code <String>]`: 
  - `[CustomerPayments <IMicrosoftGraphCustomerPayment[]>]`: 
    - `[Amount <Decimal?>]`: 
    - `[AppliesToInvoiceId <String>]`: 
    - `[AppliesToInvoiceNumber <String>]`: 
    - `[Comment <String>]`: 
    - `[ContactId <String>]`: 
    - `[Customer <IMicrosoftGraphCustomer>]`: customer
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[City <String>]`: 
        - `[CountryLetterCode <String>]`: 
        - `[PostalCode <String>]`: 
        - `[State <String>]`: 
        - `[Street <String>]`: 
      - `[Blocked <String>]`: 
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AmountDecimalPlaces <String>]`: 
        - `[AmountRoundingPrecision <Decimal?>]`: 
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[Id <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[Symbol <String>]`: 
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Email <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[Id <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
      - `[PaymentMethodId <String>]`: 
      - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
        - `[Code <String>]`: 
        - `[DiscountDateCalculation <String>]`: 
        - `[DiscountPercent <Decimal?>]`: 
        - `[DisplayName <String>]`: 
        - `[DueDateCalculation <String>]`: 
        - `[Id <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
      - `[PaymentTermsId <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[Picture <IMicrosoftGraphPicture[]>]`: 
        - `[Content <Byte[]>]`: 
        - `[ContentType <String>]`: 
        - `[Height <Int32?>]`: 
        - `[Id <String>]`: 
        - `[Width <Int32?>]`: 
      - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[Id <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
      - `[ShipmentMethodId <String>]`: 
      - `[TaxAreaDisplayName <String>]`: 
      - `[TaxAreaId <String>]`: 
      - `[TaxLiable <Boolean?>]`: 
      - `[TaxRegistrationNumber <String>]`: 
      - `[Type <String>]`: 
      - `[Website <String>]`: 
    - `[CustomerId <String>]`: 
    - `[CustomerNumber <String>]`: 
    - `[Description <String>]`: 
    - `[DocumentNumber <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[Id <String>]`: 
    - `[JournalDisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[LineNumber <Int32?>]`: 
    - `[PostingDate <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

`CUSTOMERPAYMENTS <IMicrosoftGraphCustomerPayment[]>`: .
  - `[Amount <Decimal?>]`: 
  - `[AppliesToInvoiceId <String>]`: 
  - `[AppliesToInvoiceNumber <String>]`: 
  - `[Comment <String>]`: 
  - `[ContactId <String>]`: 
  - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: 
      - `[CountryLetterCode <String>]`: 
      - `[PostalCode <String>]`: 
      - `[State <String>]`: 
      - `[Street <String>]`: 
    - `[Blocked <String>]`: 
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AmountDecimalPlaces <String>]`: 
      - `[AmountRoundingPrecision <Decimal?>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Symbol <String>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
      - `[Code <String>]`: 
      - `[DiscountDateCalculation <String>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DisplayName <String>]`: 
      - `[DueDateCalculation <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Id <String>]`: 
      - `[Width <Int32?>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ShipmentMethodId <String>]`: 
    - `[TaxAreaDisplayName <String>]`: 
    - `[TaxAreaId <String>]`: 
    - `[TaxLiable <Boolean?>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Type <String>]`: 
    - `[Website <String>]`: 
  - `[CustomerId <String>]`: 
  - `[CustomerNumber <String>]`: 
  - `[Description <String>]`: 
  - `[DocumentNumber <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
  - `[Id <String>]`: 
  - `[JournalDisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[LineNumber <Int32?>]`: 
  - `[PostingDate <DateTime?>]`: 

`INPUTOBJECT <IFinancialsIdentity>`: Identity Parameter
  - `[AccountId <String>]`: The unique identifier of account
  - `[AgedAccountsPayableId <String>]`: The unique identifier of agedAccountsPayable
  - `[AgedAccountsReceivableId <String>]`: The unique identifier of agedAccountsReceivable
  - `[CompanyId <String>]`: The unique identifier of company
  - `[CompanyInformationId <String>]`: The unique identifier of companyInformation
  - `[CountryRegionId <String>]`: The unique identifier of countryRegion
  - `[CurrencyId <String>]`: The unique identifier of currency
  - `[CustomerId <String>]`: The unique identifier of customer
  - `[CustomerPaymentId <String>]`: The unique identifier of customerPayment
  - `[CustomerPaymentJournalId <String>]`: The unique identifier of customerPaymentJournal
  - `[DimensionId <String>]`: The unique identifier of dimension
  - `[DimensionValueId <String>]`: The unique identifier of dimensionValue
  - `[EmployeeId <String>]`: The unique identifier of employee
  - `[GeneralLedgerEntryId <String>]`: The unique identifier of generalLedgerEntry
  - `[ItemCategoryId <String>]`: The unique identifier of itemCategory
  - `[ItemId <String>]`: The unique identifier of item
  - `[JournalId <String>]`: The unique identifier of journal
  - `[JournalLineId <String>]`: The unique identifier of journalLine
  - `[PaymentMethodId <String>]`: The unique identifier of paymentMethod
  - `[PaymentTermId <String>]`: The unique identifier of paymentTerm
  - `[PictureId <String>]`: The unique identifier of picture
  - `[PurchaseInvoiceId <String>]`: The unique identifier of purchaseInvoice
  - `[PurchaseInvoiceLineId <String>]`: The unique identifier of purchaseInvoiceLine
  - `[SalesCreditMemoId <String>]`: The unique identifier of salesCreditMemo
  - `[SalesCreditMemoLineId <String>]`: The unique identifier of salesCreditMemoLine
  - `[SalesInvoiceId <String>]`: The unique identifier of salesInvoice
  - `[SalesInvoiceLineId <String>]`: The unique identifier of salesInvoiceLine
  - `[SalesOrderId <String>]`: The unique identifier of salesOrder
  - `[SalesOrderLineId <String>]`: The unique identifier of salesOrderLine
  - `[SalesQuoteId <String>]`: The unique identifier of salesQuote
  - `[SalesQuoteLineId <String>]`: The unique identifier of salesQuoteLine
  - `[ShipmentMethodId <String>]`: The unique identifier of shipmentMethod
  - `[TaxAreaId <String>]`: The unique identifier of taxArea
  - `[TaxGroupId <String>]`: The unique identifier of taxGroup
  - `[UnitOfMeasureId <String>]`: The unique identifier of unitOfMeasure
  - `[VendorId <String>]`: The unique identifier of vendor

## RELATED LINKS

