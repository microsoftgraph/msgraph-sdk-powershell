---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/new-mgfinancialcompanycustomerpaymentjournal
schema: 2.0.0
---

# New-MgFinancialCompanyCustomerPaymentJournal

## SYNOPSIS
Create new navigation property to customerPaymentJournals for financials

## SYNTAX

### CreateExpanded (Default)
```
New-MgFinancialCompanyCustomerPaymentJournal -CompanyId <String> [-AccountBlocked] [-AccountCategory <String>]
 [-AccountDisplayName <String>] [-AccountId <String>] [-AccountLastModifiedDateTime <DateTime>]
 [-AccountNumber <String>] [-AccountSubCategory <String>] [-BalancingAccountId <String>]
 [-BalancingAccountNumber <String>] [-Code <String>] [-CustomerPayments <IMicrosoftGraphCustomerPayment[]>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgFinancialCompanyCustomerPaymentJournal -CompanyId <String>
 -BodyParameter <IMicrosoftGraphCustomerPaymentJournal> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgFinancialCompanyCustomerPaymentJournal -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphCustomerPaymentJournal> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgFinancialCompanyCustomerPaymentJournal -InputObject <IFinancialsIdentity> [-AccountBlocked]
 [-AccountCategory <String>] [-AccountDisplayName <String>] [-AccountId <String>]
 [-AccountLastModifiedDateTime <DateTime>] [-AccountNumber <String>] [-AccountSubCategory <String>]
 [-BalancingAccountId <String>] [-BalancingAccountNumber <String>] [-Code <String>]
 [-CustomerPayments <IMicrosoftGraphCustomerPayment[]>] [-DisplayName <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to customerPaymentJournals for financials

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

### -AccountBlocked
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountCategory
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountDisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountId
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountNumber
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountSubCategory
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomerPaymentJournal
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomerPayment[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomerPaymentJournal

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomerPaymentJournal

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCustomerPaymentJournal>: customerPaymentJournal
  - `[Id <String>]`: Read-only.
  - `[AccountBlocked <Boolean?>]`: 
  - `[AccountCategory <String>]`: 
  - `[AccountDisplayName <String>]`: 
  - `[AccountId <String>]`: Read-only.
  - `[AccountLastModifiedDateTime <DateTime?>]`: 
  - `[AccountNumber <String>]`: 
  - `[AccountSubCategory <String>]`: 
  - `[BalancingAccountId <String>]`: 
  - `[BalancingAccountNumber <String>]`: 
  - `[Code <String>]`: 
  - `[CustomerPayments <IMicrosoftGraphCustomerPayment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Amount <Decimal?>]`: 
    - `[AppliesToInvoiceId <String>]`: 
    - `[AppliesToInvoiceNumber <String>]`: 
    - `[Comment <String>]`: 
    - `[ContactId <String>]`: 
    - `[Customer <IMicrosoftGraphCustomer>]`: customer
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
    - `[CustomerId <String>]`: 
    - `[CustomerNumber <String>]`: 
    - `[Description <String>]`: 
    - `[DocumentNumber <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[JournalDisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[LineNumber <Int32?>]`: 
    - `[PostingDate <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

CUSTOMERPAYMENTS <IMicrosoftGraphCustomerPayment[]>: .
  - `[Id <String>]`: Read-only.
  - `[Amount <Decimal?>]`: 
  - `[AppliesToInvoiceId <String>]`: 
  - `[AppliesToInvoiceNumber <String>]`: 
  - `[Comment <String>]`: 
  - `[ContactId <String>]`: 
  - `[Customer <IMicrosoftGraphCustomer>]`: customer
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
  - `[CustomerId <String>]`: 
  - `[CustomerNumber <String>]`: 
  - `[Description <String>]`: 
  - `[DocumentNumber <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
  - `[JournalDisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[LineNumber <Int32?>]`: 
  - `[PostingDate <DateTime?>]`: 

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

## RELATED LINKS

