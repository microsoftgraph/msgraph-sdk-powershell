---
external help file:
Module Name: Microsoft.Graph.Beta.Financials
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.financials/update-mgbetafinancial
schema: 2.0.0
---

# Update-MgBetaFinancial

## SYNOPSIS
Update financials

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaFinancial [-AdditionalProperties <Hashtable>] [-Companies <IMicrosoftGraphCompany[]>]
 [-Id <String>] [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaFinancial -BodyParameter <IMicrosoftGraphFinancials> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update financials

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
financials
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFinancials
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Companies
.
To construct, see NOTES section for COMPANIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCompany[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFinancials

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphFinancials

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphFinancials>`: financials
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Companies <IMicrosoftGraphCompany[]>]`: 
    - `[Accounts <IMicrosoftGraphAccount[]>]`: 
      - `[Blocked <Boolean?>]`: 
      - `[Category <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[SubCategory <String>]`: 
    - `[AgedAccountsPayable <IMicrosoftGraphAgedAccountsPayable[]>]`: 
      - `[AgedAsOfDate <DateTime?>]`: 
      - `[BalanceDue <Decimal?>]`: 
      - `[CurrencyCode <String>]`: 
      - `[CurrentAmount <Decimal?>]`: 
      - `[Id <String>]`: 
      - `[Name <String>]`: 
      - `[Period1Amount <Decimal?>]`: 
      - `[Period2Amount <Decimal?>]`: 
      - `[Period3Amount <Decimal?>]`: 
      - `[PeriodLengthFilter <String>]`: 
      - `[VendorId <String>]`: 
      - `[VendorNumber <String>]`: 
    - `[AgedAccountsReceivable <IMicrosoftGraphAgedAccountsReceivable[]>]`: 
      - `[AgedAsOfDate <DateTime?>]`: 
      - `[BalanceDue <Decimal?>]`: 
      - `[CurrencyCode <String>]`: 
      - `[CurrentAmount <Decimal?>]`: 
      - `[CustomerId <String>]`: 
      - `[CustomerNumber <String>]`: 
      - `[Id <String>]`: 
      - `[Name <String>]`: 
      - `[Period1Amount <Decimal?>]`: 
      - `[Period2Amount <Decimal?>]`: 
      - `[Period3Amount <Decimal?>]`: 
      - `[PeriodLengthFilter <String>]`: 
    - `[BusinessProfileId <String>]`: 
    - `[CompanyInformation <IMicrosoftGraphCompanyInformation[]>]`: 
      - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[City <String>]`: 
        - `[CountryLetterCode <String>]`: 
        - `[PostalCode <String>]`: 
        - `[State <String>]`: 
        - `[Street <String>]`: 
      - `[CurrencyCode <String>]`: 
      - `[CurrentFiscalYearStartDate <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[Email <String>]`: 
      - `[FaxNumber <String>]`: 
      - `[Id <String>]`: 
      - `[Industry <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[PhoneNumber <String>]`: 
      - `[Picture <Byte[]>]`: 
      - `[TaxRegistrationNumber <String>]`: 
      - `[Website <String>]`: 
    - `[CountriesRegions <IMicrosoftGraphCountryRegion[]>]`: 
      - `[AddressFormat <String>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Currencies <IMicrosoftGraphCurrency[]>]`: 
      - `[AmountDecimalPlaces <String>]`: 
      - `[AmountRoundingPrecision <Decimal?>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Symbol <String>]`: 
    - `[CustomerPaymentJournals <IMicrosoftGraphCustomerPaymentJournal[]>]`: 
      - `[Account <IMicrosoftGraphAccount>]`: account
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
          - `[Blocked <String>]`: 
          - `[Currency <IMicrosoftGraphCurrency>]`: currency
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
    - `[CustomerPayments <IMicrosoftGraphCustomerPayment[]>]`: 
    - `[Customers <IMicrosoftGraphCustomer[]>]`: 
    - `[DimensionValues <IMicrosoftGraphDimensionValue[]>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Dimensions <IMicrosoftGraphDimension[]>]`: 
      - `[Code <String>]`: 
      - `[DimensionValues <IMicrosoftGraphDimensionValue[]>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[Employees <IMicrosoftGraphEmployee[]>]`: 
      - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[BirthDate <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[Email <String>]`: 
      - `[EmploymentDate <DateTime?>]`: 
      - `[GivenName <String>]`: 
      - `[Id <String>]`: 
      - `[JobTitle <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[MiddleName <String>]`: 
      - `[MobilePhone <String>]`: 
      - `[Number <String>]`: 
      - `[PersonalEmail <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[StatisticsGroupCode <String>]`: 
      - `[Status <String>]`: 
      - `[Surname <String>]`: 
      - `[TerminationDate <DateTime?>]`: 
    - `[GeneralLedgerEntries <IMicrosoftGraphGeneralLedgerEntry[]>]`: 
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[AccountId <String>]`: 
      - `[AccountNumber <String>]`: 
      - `[CreditAmount <Decimal?>]`: 
      - `[DebitAmount <Decimal?>]`: 
      - `[Description <String>]`: 
      - `[DocumentNumber <String>]`: 
      - `[DocumentType <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[PostingDate <DateTime?>]`: 
    - `[Id <String>]`: 
    - `[ItemCategories <IMicrosoftGraphItemCategory[]>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Items <IMicrosoftGraphItem[]>]`: 
      - `[BaseUnitOfMeasureId <String>]`: 
      - `[Blocked <Boolean?>]`: 
      - `[DisplayName <String>]`: 
      - `[Gtin <String>]`: 
      - `[Id <String>]`: 
      - `[Inventory <Decimal?>]`: 
      - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
      - `[ItemCategoryCode <String>]`: 
      - `[ItemCategoryId <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[PriceIncludesTax <Boolean?>]`: 
      - `[TaxGroupCode <String>]`: 
      - `[TaxGroupId <String>]`: 
      - `[Type <String>]`: 
      - `[UnitCost <Decimal?>]`: 
      - `[UnitPrice <Decimal?>]`: 
    - `[JournalLines <IMicrosoftGraphJournalLine[]>]`: 
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[AccountId <String>]`: 
      - `[AccountNumber <String>]`: 
      - `[Amount <Decimal?>]`: 
      - `[Comment <String>]`: 
      - `[Description <String>]`: 
      - `[DocumentNumber <String>]`: 
      - `[ExternalDocumentNumber <String>]`: 
      - `[Id <String>]`: 
      - `[JournalDisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[LineNumber <Int32?>]`: 
      - `[PostingDate <DateTime?>]`: 
    - `[Journals <IMicrosoftGraphJournal[]>]`: 
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[BalancingAccountId <String>]`: 
      - `[BalancingAccountNumber <String>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[JournalLines <IMicrosoftGraphJournalLine[]>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Name <String>]`: 
    - `[PaymentMethods <IMicrosoftGraphPaymentMethod[]>]`: 
    - `[PaymentTerms <IMicrosoftGraphPaymentTerm[]>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[PurchaseInvoiceLines <IMicrosoftGraphPurchaseInvoiceLine[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[AccountId <String>]`: 
      - `[AmountExcludingTax <Decimal?>]`: 
      - `[AmountIncludingTax <Decimal?>]`: 
      - `[Description <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DocumentId <String>]`: 
      - `[ExpectedReceiptDate <DateTime?>]`: 
      - `[InvoiceDiscountAllocation <Decimal?>]`: 
      - `[Item <IMicrosoftGraphItem>]`: item
      - `[ItemId <String>]`: 
      - `[LineType <String>]`: 
      - `[NetAmount <Decimal?>]`: 
      - `[NetAmountIncludingTax <Decimal?>]`: 
      - `[NetTaxAmount <Decimal?>]`: 
      - `[Quantity <Decimal?>]`: 
      - `[Sequence <Int32?>]`: 
      - `[TaxCode <String>]`: 
      - `[TaxPercent <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
      - `[UnitCost <Decimal?>]`: 
    - `[PurchaseInvoices <IMicrosoftGraphPurchaseInvoice[]>]`: 
      - `[BuyFromAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DueDate <DateTime?>]`: 
      - `[Id <String>]`: 
      - `[InvoiceDate <DateTime?>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[PayToAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[PayToContact <String>]`: 
      - `[PayToName <String>]`: 
      - `[PayToVendorId <String>]`: 
      - `[PayToVendorNumber <String>]`: 
      - `[PricesIncludeTax <Boolean?>]`: 
      - `[PurchaseInvoiceLines <IMicrosoftGraphPurchaseInvoiceLine[]>]`: 
      - `[ShipToAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[ShipToContact <String>]`: 
      - `[ShipToName <String>]`: 
      - `[Status <String>]`: 
      - `[TotalAmountExcludingTax <Decimal?>]`: 
      - `[TotalAmountIncludingTax <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
      - `[Vendor <IMicrosoftGraphVendor>]`: vendor
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
        - `[Balance <Decimal?>]`: 
        - `[Blocked <String>]`: 
        - `[Currency <IMicrosoftGraphCurrency>]`: currency
        - `[CurrencyCode <String>]`: 
        - `[CurrencyId <String>]`: 
        - `[DisplayName <String>]`: 
        - `[Email <String>]`: 
        - `[Id <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[Number <String>]`: 
        - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
        - `[PaymentMethodId <String>]`: 
        - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
        - `[PaymentTermsId <String>]`: 
        - `[PhoneNumber <String>]`: 
        - `[Picture <IMicrosoftGraphPicture[]>]`: 
        - `[TaxLiable <Boolean?>]`: 
        - `[TaxRegistrationNumber <String>]`: 
        - `[Website <String>]`: 
      - `[VendorId <String>]`: 
      - `[VendorInvoiceNumber <String>]`: 
      - `[VendorName <String>]`: 
      - `[VendorNumber <String>]`: 
    - `[SalesCreditMemoLines <IMicrosoftGraphSalesCreditMemoLine[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[AccountId <String>]`: 
      - `[AmountExcludingTax <Decimal?>]`: 
      - `[AmountIncludingTax <Decimal?>]`: 
      - `[Description <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DocumentId <String>]`: 
      - `[InvoiceDiscountAllocation <Decimal?>]`: 
      - `[Item <IMicrosoftGraphItem>]`: item
      - `[ItemId <String>]`: 
      - `[LineType <String>]`: 
      - `[NetAmount <Decimal?>]`: 
      - `[NetAmountIncludingTax <Decimal?>]`: 
      - `[NetTaxAmount <Decimal?>]`: 
      - `[Quantity <Decimal?>]`: 
      - `[Sequence <Int32?>]`: 
      - `[ShipmentDate <DateTime?>]`: 
      - `[TaxCode <String>]`: 
      - `[TaxPercent <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
      - `[UnitOfMeasureId <String>]`: 
      - `[UnitPrice <Decimal?>]`: 
    - `[SalesCreditMemos <IMicrosoftGraphSalesCreditMemo[]>]`: 
      - `[BillToCustomerId <String>]`: 
      - `[BillToCustomerNumber <String>]`: 
      - `[BillToName <String>]`: 
      - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[CreditMemoDate <DateTime?>]`: 
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[Customer <IMicrosoftGraphCustomer>]`: customer
      - `[CustomerId <String>]`: 
      - `[CustomerName <String>]`: 
      - `[CustomerNumber <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DueDate <DateTime?>]`: 
      - `[Email <String>]`: 
      - `[ExternalDocumentNumber <String>]`: 
      - `[Id <String>]`: 
      - `[InvoiceId <String>]`: 
      - `[InvoiceNumber <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[PaymentTermsId <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[PricesIncludeTax <Boolean?>]`: 
      - `[SalesCreditMemoLines <IMicrosoftGraphSalesCreditMemoLine[]>]`: 
      - `[Salesperson <String>]`: 
      - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Status <String>]`: 
      - `[TotalAmountExcludingTax <Decimal?>]`: 
      - `[TotalAmountIncludingTax <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
    - `[SalesInvoiceLines <IMicrosoftGraphSalesInvoiceLine[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[AccountId <String>]`: 
      - `[AmountExcludingTax <Decimal?>]`: 
      - `[AmountIncludingTax <Decimal?>]`: 
      - `[Description <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DocumentId <String>]`: 
      - `[InvoiceDiscountAllocation <Decimal?>]`: 
      - `[Item <IMicrosoftGraphItem>]`: item
      - `[ItemId <String>]`: 
      - `[LineType <String>]`: 
      - `[NetAmount <Decimal?>]`: 
      - `[NetAmountIncludingTax <Decimal?>]`: 
      - `[NetTaxAmount <Decimal?>]`: 
      - `[Quantity <Decimal?>]`: 
      - `[Sequence <Int32?>]`: 
      - `[ShipmentDate <DateTime?>]`: 
      - `[TaxCode <String>]`: 
      - `[TaxPercent <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
      - `[UnitOfMeasureId <String>]`: 
      - `[UnitPrice <Decimal?>]`: 
    - `[SalesInvoices <IMicrosoftGraphSalesInvoice[]>]`: 
      - `[BillToCustomerId <String>]`: 
      - `[BillToCustomerNumber <String>]`: 
      - `[BillToName <String>]`: 
      - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[Customer <IMicrosoftGraphCustomer>]`: customer
      - `[CustomerId <String>]`: 
      - `[CustomerName <String>]`: 
      - `[CustomerNumber <String>]`: 
      - `[CustomerPurchaseOrderReference <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DueDate <DateTime?>]`: 
      - `[Email <String>]`: 
      - `[ExternalDocumentNumber <String>]`: 
      - `[Id <String>]`: 
      - `[InvoiceDate <DateTime?>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[OrderId <String>]`: 
      - `[OrderNumber <String>]`: 
      - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[PaymentTermsId <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[PricesIncludeTax <Boolean?>]`: 
      - `[SalesInvoiceLines <IMicrosoftGraphSalesInvoiceLine[]>]`: 
      - `[Salesperson <String>]`: 
      - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[ShipToContact <String>]`: 
      - `[ShipToName <String>]`: 
      - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[ShipmentMethodId <String>]`: 
      - `[ShippingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Status <String>]`: 
      - `[TotalAmountExcludingTax <Decimal?>]`: 
      - `[TotalAmountIncludingTax <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
    - `[SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[AccountId <String>]`: 
      - `[AmountExcludingTax <Decimal?>]`: 
      - `[AmountIncludingTax <Decimal?>]`: 
      - `[Description <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DocumentId <String>]`: 
      - `[InvoiceDiscountAllocation <Decimal?>]`: 
      - `[InvoiceQuantity <Decimal?>]`: 
      - `[InvoicedQuantity <Decimal?>]`: 
      - `[Item <IMicrosoftGraphItem>]`: item
      - `[ItemId <String>]`: 
      - `[LineType <String>]`: 
      - `[NetAmount <Decimal?>]`: 
      - `[NetAmountIncludingTax <Decimal?>]`: 
      - `[NetTaxAmount <Decimal?>]`: 
      - `[Quantity <Decimal?>]`: 
      - `[Sequence <Int32?>]`: 
      - `[ShipQuantity <Decimal?>]`: 
      - `[ShipmentDate <DateTime?>]`: 
      - `[ShippedQuantity <Decimal?>]`: 
      - `[TaxCode <String>]`: 
      - `[TaxPercent <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
      - `[UnitOfMeasureId <String>]`: 
      - `[UnitPrice <Decimal?>]`: 
    - `[SalesOrders <IMicrosoftGraphSalesOrder[]>]`: 
      - `[BillToCustomerId <String>]`: 
      - `[BillToCustomerNumber <String>]`: 
      - `[BillToName <String>]`: 
      - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[Customer <IMicrosoftGraphCustomer>]`: customer
      - `[CustomerId <String>]`: 
      - `[CustomerName <String>]`: 
      - `[CustomerNumber <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[Email <String>]`: 
      - `[ExternalDocumentNumber <String>]`: 
      - `[FullyShipped <Boolean?>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[OrderDate <DateTime?>]`: 
      - `[PartialShipping <Boolean?>]`: 
      - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[PaymentTermsId <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[PricesIncludeTax <Boolean?>]`: 
      - `[RequestedDeliveryDate <DateTime?>]`: 
      - `[SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]`: 
      - `[Salesperson <String>]`: 
      - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[ShipToContact <String>]`: 
      - `[ShipToName <String>]`: 
      - `[ShippingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Status <String>]`: 
      - `[TotalAmountExcludingTax <Decimal?>]`: 
      - `[TotalAmountIncludingTax <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
    - `[SalesQuoteLines <IMicrosoftGraphSalesQuoteLine[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Account <IMicrosoftGraphAccount>]`: account
      - `[AccountId <String>]`: 
      - `[AmountExcludingTax <Decimal?>]`: 
      - `[AmountIncludingTax <Decimal?>]`: 
      - `[Description <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DiscountAppliedBeforeTax <Boolean?>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DocumentId <String>]`: 
      - `[Item <IMicrosoftGraphItem>]`: item
      - `[ItemId <String>]`: 
      - `[LineType <String>]`: 
      - `[NetAmount <Decimal?>]`: 
      - `[NetAmountIncludingTax <Decimal?>]`: 
      - `[NetTaxAmount <Decimal?>]`: 
      - `[Quantity <Decimal?>]`: 
      - `[Sequence <Int32?>]`: 
      - `[TaxCode <String>]`: 
      - `[TaxPercent <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
      - `[UnitOfMeasureId <String>]`: 
      - `[UnitPrice <Decimal?>]`: 
    - `[SalesQuotes <IMicrosoftGraphSalesQuote[]>]`: 
      - `[AcceptedDate <DateTime?>]`: 
      - `[BillToCustomerId <String>]`: 
      - `[BillToCustomerNumber <String>]`: 
      - `[BillToName <String>]`: 
      - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[Customer <IMicrosoftGraphCustomer>]`: customer
      - `[CustomerId <String>]`: 
      - `[CustomerName <String>]`: 
      - `[CustomerNumber <String>]`: 
      - `[DiscountAmount <Decimal?>]`: 
      - `[DocumentDate <DateTime?>]`: 
      - `[DueDate <DateTime?>]`: 
      - `[Email <String>]`: 
      - `[ExternalDocumentNumber <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[PaymentTermsId <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[SalesQuoteLines <IMicrosoftGraphSalesQuoteLine[]>]`: 
      - `[Salesperson <String>]`: 
      - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[SentDate <DateTime?>]`: 
      - `[ShipToContact <String>]`: 
      - `[ShipToName <String>]`: 
      - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[ShipmentMethodId <String>]`: 
      - `[ShippingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Status <String>]`: 
      - `[TotalAmountExcludingTax <Decimal?>]`: 
      - `[TotalAmountIncludingTax <Decimal?>]`: 
      - `[TotalTaxAmount <Decimal?>]`: 
      - `[ValidUntilDate <DateTime?>]`: 
    - `[ShipmentMethods <IMicrosoftGraphShipmentMethod[]>]`: 
    - `[SystemVersion <String>]`: 
    - `[TaxAreas <IMicrosoftGraphTaxArea[]>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[TaxType <String>]`: 
    - `[TaxGroups <IMicrosoftGraphTaxGroup[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[TaxType <String>]`: 
    - `[UnitsOfMeasure <IMicrosoftGraphUnitOfMeasure[]>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Id <String>]`: 
      - `[InternationalStandardCode <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Vendors <IMicrosoftGraphVendor[]>]`: 
  - `[Id <String>]`: 

`COMPANIES <IMicrosoftGraphCompany[]>`: .
  - `[Accounts <IMicrosoftGraphAccount[]>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
  - `[AgedAccountsPayable <IMicrosoftGraphAgedAccountsPayable[]>]`: 
    - `[AgedAsOfDate <DateTime?>]`: 
    - `[BalanceDue <Decimal?>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrentAmount <Decimal?>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
    - `[Period1Amount <Decimal?>]`: 
    - `[Period2Amount <Decimal?>]`: 
    - `[Period3Amount <Decimal?>]`: 
    - `[PeriodLengthFilter <String>]`: 
    - `[VendorId <String>]`: 
    - `[VendorNumber <String>]`: 
  - `[AgedAccountsReceivable <IMicrosoftGraphAgedAccountsReceivable[]>]`: 
    - `[AgedAsOfDate <DateTime?>]`: 
    - `[BalanceDue <Decimal?>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrentAmount <Decimal?>]`: 
    - `[CustomerId <String>]`: 
    - `[CustomerNumber <String>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
    - `[Period1Amount <Decimal?>]`: 
    - `[Period2Amount <Decimal?>]`: 
    - `[Period3Amount <Decimal?>]`: 
    - `[PeriodLengthFilter <String>]`: 
  - `[BusinessProfileId <String>]`: 
  - `[CompanyInformation <IMicrosoftGraphCompanyInformation[]>]`: 
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: 
      - `[CountryLetterCode <String>]`: 
      - `[PostalCode <String>]`: 
      - `[State <String>]`: 
      - `[Street <String>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrentFiscalYearStartDate <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[FaxNumber <String>]`: 
    - `[Id <String>]`: 
    - `[Industry <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <Byte[]>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Website <String>]`: 
  - `[CountriesRegions <IMicrosoftGraphCountryRegion[]>]`: 
    - `[AddressFormat <String>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Currencies <IMicrosoftGraphCurrency[]>]`: 
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CustomerPaymentJournals <IMicrosoftGraphCustomerPaymentJournal[]>]`: 
    - `[Account <IMicrosoftGraphAccount>]`: account
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
        - `[Blocked <String>]`: 
        - `[Currency <IMicrosoftGraphCurrency>]`: currency
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
  - `[CustomerPayments <IMicrosoftGraphCustomerPayment[]>]`: 
  - `[Customers <IMicrosoftGraphCustomer[]>]`: 
  - `[DimensionValues <IMicrosoftGraphDimensionValue[]>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Dimensions <IMicrosoftGraphDimension[]>]`: 
    - `[Code <String>]`: 
    - `[DimensionValues <IMicrosoftGraphDimensionValue[]>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[Employees <IMicrosoftGraphEmployee[]>]`: 
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[BirthDate <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[EmploymentDate <DateTime?>]`: 
    - `[GivenName <String>]`: 
    - `[Id <String>]`: 
    - `[JobTitle <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[MiddleName <String>]`: 
    - `[MobilePhone <String>]`: 
    - `[Number <String>]`: 
    - `[PersonalEmail <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[StatisticsGroupCode <String>]`: 
    - `[Status <String>]`: 
    - `[Surname <String>]`: 
    - `[TerminationDate <DateTime?>]`: 
  - `[GeneralLedgerEntries <IMicrosoftGraphGeneralLedgerEntry[]>]`: 
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AccountNumber <String>]`: 
    - `[CreditAmount <Decimal?>]`: 
    - `[DebitAmount <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DocumentNumber <String>]`: 
    - `[DocumentType <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PostingDate <DateTime?>]`: 
  - `[Id <String>]`: 
  - `[ItemCategories <IMicrosoftGraphItemCategory[]>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Items <IMicrosoftGraphItem[]>]`: 
    - `[BaseUnitOfMeasureId <String>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[Gtin <String>]`: 
    - `[Id <String>]`: 
    - `[Inventory <Decimal?>]`: 
    - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
    - `[ItemCategoryCode <String>]`: 
    - `[ItemCategoryId <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[PriceIncludesTax <Boolean?>]`: 
    - `[TaxGroupCode <String>]`: 
    - `[TaxGroupId <String>]`: 
    - `[Type <String>]`: 
    - `[UnitCost <Decimal?>]`: 
    - `[UnitPrice <Decimal?>]`: 
  - `[JournalLines <IMicrosoftGraphJournalLine[]>]`: 
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AccountNumber <String>]`: 
    - `[Amount <Decimal?>]`: 
    - `[Comment <String>]`: 
    - `[Description <String>]`: 
    - `[DocumentNumber <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[Id <String>]`: 
    - `[JournalDisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[LineNumber <Int32?>]`: 
    - `[PostingDate <DateTime?>]`: 
  - `[Journals <IMicrosoftGraphJournal[]>]`: 
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[BalancingAccountId <String>]`: 
    - `[BalancingAccountNumber <String>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[JournalLines <IMicrosoftGraphJournalLine[]>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Name <String>]`: 
  - `[PaymentMethods <IMicrosoftGraphPaymentMethod[]>]`: 
  - `[PaymentTerms <IMicrosoftGraphPaymentTerm[]>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
  - `[PurchaseInvoiceLines <IMicrosoftGraphPurchaseInvoiceLine[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AmountExcludingTax <Decimal?>]`: 
    - `[AmountIncludingTax <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DocumentId <String>]`: 
    - `[ExpectedReceiptDate <DateTime?>]`: 
    - `[InvoiceDiscountAllocation <Decimal?>]`: 
    - `[Item <IMicrosoftGraphItem>]`: item
    - `[ItemId <String>]`: 
    - `[LineType <String>]`: 
    - `[NetAmount <Decimal?>]`: 
    - `[NetAmountIncludingTax <Decimal?>]`: 
    - `[NetTaxAmount <Decimal?>]`: 
    - `[Quantity <Decimal?>]`: 
    - `[Sequence <Int32?>]`: 
    - `[TaxCode <String>]`: 
    - `[TaxPercent <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[UnitCost <Decimal?>]`: 
  - `[PurchaseInvoices <IMicrosoftGraphPurchaseInvoice[]>]`: 
    - `[BuyFromAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DueDate <DateTime?>]`: 
    - `[Id <String>]`: 
    - `[InvoiceDate <DateTime?>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PayToAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[PayToContact <String>]`: 
    - `[PayToName <String>]`: 
    - `[PayToVendorId <String>]`: 
    - `[PayToVendorNumber <String>]`: 
    - `[PricesIncludeTax <Boolean?>]`: 
    - `[PurchaseInvoiceLines <IMicrosoftGraphPurchaseInvoiceLine[]>]`: 
    - `[ShipToAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[ShipToContact <String>]`: 
    - `[ShipToName <String>]`: 
    - `[Status <String>]`: 
    - `[TotalAmountExcludingTax <Decimal?>]`: 
    - `[TotalAmountIncludingTax <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[Vendor <IMicrosoftGraphVendor>]`: vendor
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Balance <Decimal?>]`: 
      - `[Blocked <String>]`: 
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Email <String>]`: 
      - `[Id <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[PaymentMethodId <String>]`: 
      - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[PaymentTermsId <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[TaxLiable <Boolean?>]`: 
      - `[TaxRegistrationNumber <String>]`: 
      - `[Website <String>]`: 
    - `[VendorId <String>]`: 
    - `[VendorInvoiceNumber <String>]`: 
    - `[VendorName <String>]`: 
    - `[VendorNumber <String>]`: 
  - `[SalesCreditMemoLines <IMicrosoftGraphSalesCreditMemoLine[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AmountExcludingTax <Decimal?>]`: 
    - `[AmountIncludingTax <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DocumentId <String>]`: 
    - `[InvoiceDiscountAllocation <Decimal?>]`: 
    - `[Item <IMicrosoftGraphItem>]`: item
    - `[ItemId <String>]`: 
    - `[LineType <String>]`: 
    - `[NetAmount <Decimal?>]`: 
    - `[NetAmountIncludingTax <Decimal?>]`: 
    - `[NetTaxAmount <Decimal?>]`: 
    - `[Quantity <Decimal?>]`: 
    - `[Sequence <Int32?>]`: 
    - `[ShipmentDate <DateTime?>]`: 
    - `[TaxCode <String>]`: 
    - `[TaxPercent <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[UnitOfMeasureId <String>]`: 
    - `[UnitPrice <Decimal?>]`: 
  - `[SalesCreditMemos <IMicrosoftGraphSalesCreditMemo[]>]`: 
    - `[BillToCustomerId <String>]`: 
    - `[BillToCustomerNumber <String>]`: 
    - `[BillToName <String>]`: 
    - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[CreditMemoDate <DateTime?>]`: 
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[CustomerId <String>]`: 
    - `[CustomerName <String>]`: 
    - `[CustomerNumber <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DueDate <DateTime?>]`: 
    - `[Email <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[Id <String>]`: 
    - `[InvoiceId <String>]`: 
    - `[InvoiceNumber <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[PricesIncludeTax <Boolean?>]`: 
    - `[SalesCreditMemoLines <IMicrosoftGraphSalesCreditMemoLine[]>]`: 
    - `[Salesperson <String>]`: 
    - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Status <String>]`: 
    - `[TotalAmountExcludingTax <Decimal?>]`: 
    - `[TotalAmountIncludingTax <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
  - `[SalesInvoiceLines <IMicrosoftGraphSalesInvoiceLine[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AmountExcludingTax <Decimal?>]`: 
    - `[AmountIncludingTax <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DocumentId <String>]`: 
    - `[InvoiceDiscountAllocation <Decimal?>]`: 
    - `[Item <IMicrosoftGraphItem>]`: item
    - `[ItemId <String>]`: 
    - `[LineType <String>]`: 
    - `[NetAmount <Decimal?>]`: 
    - `[NetAmountIncludingTax <Decimal?>]`: 
    - `[NetTaxAmount <Decimal?>]`: 
    - `[Quantity <Decimal?>]`: 
    - `[Sequence <Int32?>]`: 
    - `[ShipmentDate <DateTime?>]`: 
    - `[TaxCode <String>]`: 
    - `[TaxPercent <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[UnitOfMeasureId <String>]`: 
    - `[UnitPrice <Decimal?>]`: 
  - `[SalesInvoices <IMicrosoftGraphSalesInvoice[]>]`: 
    - `[BillToCustomerId <String>]`: 
    - `[BillToCustomerNumber <String>]`: 
    - `[BillToName <String>]`: 
    - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[CustomerId <String>]`: 
    - `[CustomerName <String>]`: 
    - `[CustomerNumber <String>]`: 
    - `[CustomerPurchaseOrderReference <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DueDate <DateTime?>]`: 
    - `[Email <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[Id <String>]`: 
    - `[InvoiceDate <DateTime?>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[OrderId <String>]`: 
    - `[OrderNumber <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[PricesIncludeTax <Boolean?>]`: 
    - `[SalesInvoiceLines <IMicrosoftGraphSalesInvoiceLine[]>]`: 
    - `[Salesperson <String>]`: 
    - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[ShipToContact <String>]`: 
    - `[ShipToName <String>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
    - `[ShipmentMethodId <String>]`: 
    - `[ShippingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Status <String>]`: 
    - `[TotalAmountExcludingTax <Decimal?>]`: 
    - `[TotalAmountIncludingTax <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
  - `[SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AmountExcludingTax <Decimal?>]`: 
    - `[AmountIncludingTax <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DocumentId <String>]`: 
    - `[InvoiceDiscountAllocation <Decimal?>]`: 
    - `[InvoiceQuantity <Decimal?>]`: 
    - `[InvoicedQuantity <Decimal?>]`: 
    - `[Item <IMicrosoftGraphItem>]`: item
    - `[ItemId <String>]`: 
    - `[LineType <String>]`: 
    - `[NetAmount <Decimal?>]`: 
    - `[NetAmountIncludingTax <Decimal?>]`: 
    - `[NetTaxAmount <Decimal?>]`: 
    - `[Quantity <Decimal?>]`: 
    - `[Sequence <Int32?>]`: 
    - `[ShipQuantity <Decimal?>]`: 
    - `[ShipmentDate <DateTime?>]`: 
    - `[ShippedQuantity <Decimal?>]`: 
    - `[TaxCode <String>]`: 
    - `[TaxPercent <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[UnitOfMeasureId <String>]`: 
    - `[UnitPrice <Decimal?>]`: 
  - `[SalesOrders <IMicrosoftGraphSalesOrder[]>]`: 
    - `[BillToCustomerId <String>]`: 
    - `[BillToCustomerNumber <String>]`: 
    - `[BillToName <String>]`: 
    - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[CustomerId <String>]`: 
    - `[CustomerName <String>]`: 
    - `[CustomerNumber <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[Email <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[FullyShipped <Boolean?>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[OrderDate <DateTime?>]`: 
    - `[PartialShipping <Boolean?>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[PricesIncludeTax <Boolean?>]`: 
    - `[RequestedDeliveryDate <DateTime?>]`: 
    - `[SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]`: 
    - `[Salesperson <String>]`: 
    - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[ShipToContact <String>]`: 
    - `[ShipToName <String>]`: 
    - `[ShippingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Status <String>]`: 
    - `[TotalAmountExcludingTax <Decimal?>]`: 
    - `[TotalAmountIncludingTax <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
  - `[SalesQuoteLines <IMicrosoftGraphSalesQuoteLine[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AmountExcludingTax <Decimal?>]`: 
    - `[AmountIncludingTax <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DocumentId <String>]`: 
    - `[Item <IMicrosoftGraphItem>]`: item
    - `[ItemId <String>]`: 
    - `[LineType <String>]`: 
    - `[NetAmount <Decimal?>]`: 
    - `[NetAmountIncludingTax <Decimal?>]`: 
    - `[NetTaxAmount <Decimal?>]`: 
    - `[Quantity <Decimal?>]`: 
    - `[Sequence <Int32?>]`: 
    - `[TaxCode <String>]`: 
    - `[TaxPercent <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[UnitOfMeasureId <String>]`: 
    - `[UnitPrice <Decimal?>]`: 
  - `[SalesQuotes <IMicrosoftGraphSalesQuote[]>]`: 
    - `[AcceptedDate <DateTime?>]`: 
    - `[BillToCustomerId <String>]`: 
    - `[BillToCustomerNumber <String>]`: 
    - `[BillToName <String>]`: 
    - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[CustomerId <String>]`: 
    - `[CustomerName <String>]`: 
    - `[CustomerNumber <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DocumentDate <DateTime?>]`: 
    - `[DueDate <DateTime?>]`: 
    - `[Email <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[SalesQuoteLines <IMicrosoftGraphSalesQuoteLine[]>]`: 
    - `[Salesperson <String>]`: 
    - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[SentDate <DateTime?>]`: 
    - `[ShipToContact <String>]`: 
    - `[ShipToName <String>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
    - `[ShipmentMethodId <String>]`: 
    - `[ShippingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Status <String>]`: 
    - `[TotalAmountExcludingTax <Decimal?>]`: 
    - `[TotalAmountIncludingTax <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[ValidUntilDate <DateTime?>]`: 
  - `[ShipmentMethods <IMicrosoftGraphShipmentMethod[]>]`: 
  - `[SystemVersion <String>]`: 
  - `[TaxAreas <IMicrosoftGraphTaxArea[]>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[TaxType <String>]`: 
  - `[TaxGroups <IMicrosoftGraphTaxGroup[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[TaxType <String>]`: 
  - `[UnitsOfMeasure <IMicrosoftGraphUnitOfMeasure[]>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Id <String>]`: 
    - `[InternationalStandardCode <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Vendors <IMicrosoftGraphVendor[]>]`: 

## RELATED LINKS

