---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/new-mgfinancialcompany
schema: 2.0.0
---

# New-MgFinancialCompany

## SYNOPSIS
Create new navigation property to companies for financials

## SYNTAX

### CreateExpanded (Default)
```
New-MgFinancialCompany [-Accounts <IMicrosoftGraphAccount[]>] [-AdditionalProperties <Hashtable>]
 [-AgedAccountsPayable <IMicrosoftGraphAgedAccountsPayable[]>]
 [-AgedAccountsReceivable <IMicrosoftGraphAgedAccountsReceivable[]>] [-BusinessProfileId <String>]
 [-CompanyInformation <IMicrosoftGraphCompanyInformation1[]>]
 [-CountriesRegions <IMicrosoftGraphCountryRegion[]>] [-Currencies <IMicrosoftGraphCurrency[]>]
 [-CustomerPaymentJournals <IMicrosoftGraphCustomerPaymentJournal[]>]
 [-CustomerPayments <IMicrosoftGraphCustomerPayment[]>] [-Customers <IMicrosoftGraphCustomer[]>]
 [-Dimensions <IMicrosoftGraphDimension[]>] [-DimensionValues <IMicrosoftGraphDimensionValue[]>]
 [-DisplayName <String>] [-Employees <IMicrosoftGraphEmployee[]>]
 [-GeneralLedgerEntries <IMicrosoftGraphGeneralLedgerEntry[]>] [-Id <String>]
 [-ItemCategories <IMicrosoftGraphItemCategory[]>] [-Items <IMicrosoftGraphItem[]>]
 [-JournalLines <IMicrosoftGraphJournalLine[]>] [-Journals <IMicrosoftGraphJournal[]>] [-Name <String>]
 [-PaymentMethods <IMicrosoftGraphPaymentMethod[]>] [-PaymentTerms <IMicrosoftGraphPaymentTerm[]>]
 [-Picture <IMicrosoftGraphPicture[]>] [-PurchaseInvoiceLines <IMicrosoftGraphPurchaseInvoiceLine[]>]
 [-PurchaseInvoices <IMicrosoftGraphPurchaseInvoice[]>]
 [-SalesCreditMemoLines <IMicrosoftGraphSalesCreditMemoLine[]>]
 [-SalesCreditMemos <IMicrosoftGraphSalesCreditMemo[]>]
 [-SalesInvoiceLines <IMicrosoftGraphSalesInvoiceLine[]>] [-SalesInvoices <IMicrosoftGraphSalesInvoice[]>]
 [-SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>] [-SalesOrders <IMicrosoftGraphSalesOrder[]>]
 [-SalesQuoteLines <IMicrosoftGraphSalesQuoteLine[]>] [-SalesQuotes <IMicrosoftGraphSalesQuote[]>]
 [-ShipmentMethods <IMicrosoftGraphShipmentMethod[]>] [-SystemVersion <String>]
 [-TaxAreas <IMicrosoftGraphTaxArea[]>] [-TaxGroups <IMicrosoftGraphTaxGroup[]>]
 [-UnitsOfMeasure <IMicrosoftGraphUnitOfMeasure[]>] [-Vendors <IMicrosoftGraphVendor[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgFinancialCompany -BodyParameter <IMicrosoftGraphCompany> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to companies for financials

## EXAMPLES

## PARAMETERS

### -Accounts
.
To construct, please use Get-Help -Online and see NOTES section for ACCOUNTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccount[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AgedAccountsPayable
.
To construct, please use Get-Help -Online and see NOTES section for AGEDACCOUNTSPAYABLE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgedAccountsPayable[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AgedAccountsReceivable
.
To construct, please use Get-Help -Online and see NOTES section for AGEDACCOUNTSRECEIVABLE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgedAccountsReceivable[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
company
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCompany
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BusinessProfileId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompanyInformation
.
To construct, please use Get-Help -Online and see NOTES section for COMPANYINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCompanyInformation1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountriesRegions
.
To construct, please use Get-Help -Online and see NOTES section for COUNTRIESREGIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCountryRegion[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Currencies
.
To construct, please use Get-Help -Online and see NOTES section for CURRENCIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCurrency[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerPaymentJournals
.
To construct, please use Get-Help -Online and see NOTES section for CUSTOMERPAYMENTJOURNALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomerPaymentJournal[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerPayments
.
To construct, please use Get-Help -Online and see NOTES section for CUSTOMERPAYMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomerPayment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Customers
.
To construct, please use Get-Help -Online and see NOTES section for CUSTOMERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomer[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Dimensions
.
To construct, please use Get-Help -Online and see NOTES section for DIMENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDimension[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DimensionValues
.
To construct, please use Get-Help -Online and see NOTES section for DIMENSIONVALUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDimensionValue[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Employees
.
To construct, please use Get-Help -Online and see NOTES section for EMPLOYEES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmployee[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GeneralLedgerEntries
.
To construct, please use Get-Help -Online and see NOTES section for GENERALLEDGERENTRIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGeneralLedgerEntry[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ItemCategories
.
To construct, please use Get-Help -Online and see NOTES section for ITEMCATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemCategory[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Items
.
To construct, please use Get-Help -Online and see NOTES section for ITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItem[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JournalLines
.
To construct, please use Get-Help -Online and see NOTES section for JOURNALLINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphJournalLine[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Journals
.
To construct, please use Get-Help -Online and see NOTES section for JOURNALS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphJournal[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentMethods
.
To construct, please use Get-Help -Online and see NOTES section for PAYMENTMETHODS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPaymentMethod[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PaymentTerms
.
To construct, please use Get-Help -Online and see NOTES section for PAYMENTTERMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPaymentTerm[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Picture
.
To construct, please use Get-Help -Online and see NOTES section for PICTURE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPicture[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PurchaseInvoiceLines
.
To construct, please use Get-Help -Online and see NOTES section for PURCHASEINVOICELINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPurchaseInvoiceLine[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PurchaseInvoices
.
To construct, please use Get-Help -Online and see NOTES section for PURCHASEINVOICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPurchaseInvoice[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesCreditMemoLines
.
To construct, please use Get-Help -Online and see NOTES section for SALESCREDITMEMOLINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesCreditMemoLine[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesCreditMemos
.
To construct, please use Get-Help -Online and see NOTES section for SALESCREDITMEMOS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesCreditMemo[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesInvoiceLines
.
To construct, please use Get-Help -Online and see NOTES section for SALESINVOICELINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesInvoiceLine[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesInvoices
.
To construct, please use Get-Help -Online and see NOTES section for SALESINVOICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesInvoice[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesOrderLines
.
To construct, please use Get-Help -Online and see NOTES section for SALESORDERLINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrderLine[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesOrders
.
To construct, please use Get-Help -Online and see NOTES section for SALESORDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrder[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesQuoteLines
.
To construct, please use Get-Help -Online and see NOTES section for SALESQUOTELINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesQuoteLine[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesQuotes
.
To construct, please use Get-Help -Online and see NOTES section for SALESQUOTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesQuote[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentMethods
.
To construct, please use Get-Help -Online and see NOTES section for SHIPMENTMETHODS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShipmentMethod[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemVersion
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxAreas
.
To construct, please use Get-Help -Online and see NOTES section for TAXAREAS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTaxArea[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxGroups
.
To construct, please use Get-Help -Online and see NOTES section for TAXGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTaxGroup[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnitsOfMeasure
.
To construct, please use Get-Help -Online and see NOTES section for UNITSOFMEASURE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnitOfMeasure[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Vendors
.
To construct, please use Get-Help -Online and see NOTES section for VENDORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVendor[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCompany

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCompany

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCOUNTS <IMicrosoftGraphAccount[]>: .
  - `[Id <String>]`: Read-only.
  - `[Blocked <Boolean?>]`: 
  - `[Category <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[SubCategory <String>]`: 

AGEDACCOUNTSPAYABLE <IMicrosoftGraphAgedAccountsPayable[]>: .
  - `[Id <String>]`: Read-only.
  - `[AgedAsOfDate <DateTime?>]`: 
  - `[BalanceDue <Decimal?>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrentAmount <Decimal?>]`: 
  - `[Name <String>]`: 
  - `[Period1Amount <Decimal?>]`: 
  - `[Period2Amount <Decimal?>]`: 
  - `[Period3Amount <Decimal?>]`: 
  - `[PeriodLengthFilter <String>]`: 
  - `[VendorNumber <String>]`: 

AGEDACCOUNTSRECEIVABLE <IMicrosoftGraphAgedAccountsReceivable[]>: .
  - `[Id <String>]`: Read-only.
  - `[AgedAsOfDate <DateTime?>]`: 
  - `[BalanceDue <Decimal?>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrentAmount <Decimal?>]`: 
  - `[CustomerNumber <String>]`: 
  - `[Name <String>]`: 
  - `[Period1Amount <Decimal?>]`: 
  - `[Period2Amount <Decimal?>]`: 
  - `[Period3Amount <Decimal?>]`: 
  - `[PeriodLengthFilter <String>]`: 

BODYPARAMETER <IMicrosoftGraphCompany>: company
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Accounts <IMicrosoftGraphAccount[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
  - `[AgedAccountsPayable <IMicrosoftGraphAgedAccountsPayable[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AgedAsOfDate <DateTime?>]`: 
    - `[BalanceDue <Decimal?>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrentAmount <Decimal?>]`: 
    - `[Name <String>]`: 
    - `[Period1Amount <Decimal?>]`: 
    - `[Period2Amount <Decimal?>]`: 
    - `[Period3Amount <Decimal?>]`: 
    - `[PeriodLengthFilter <String>]`: 
    - `[VendorNumber <String>]`: 
  - `[AgedAccountsReceivable <IMicrosoftGraphAgedAccountsReceivable[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AgedAsOfDate <DateTime?>]`: 
    - `[BalanceDue <Decimal?>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrentAmount <Decimal?>]`: 
    - `[CustomerNumber <String>]`: 
    - `[Name <String>]`: 
    - `[Period1Amount <Decimal?>]`: 
    - `[Period2Amount <Decimal?>]`: 
    - `[Period3Amount <Decimal?>]`: 
    - `[PeriodLengthFilter <String>]`: 
  - `[BusinessProfileId <String>]`: 
  - `[CompanyInformation <IMicrosoftGraphCompanyInformation1[]>]`: 
    - `[Id <String>]`: Read-only.
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
    - `[Industry <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <Byte[]>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Website <String>]`: 
  - `[CountriesRegions <IMicrosoftGraphCountryRegion[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AddressFormat <String>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Currencies <IMicrosoftGraphCurrency[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CustomerPaymentJournals <IMicrosoftGraphCustomerPaymentJournal[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
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
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
        - `[Blocked <String>]`: 
        - `[Currency <IMicrosoftGraphCurrency>]`: currency
        - `[CurrencyCode <String>]`: 
        - `[CurrencyId <String>]`: 
        - `[DisplayName <String>]`: 
        - `[Email <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[Number <String>]`: 
        - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[Code <String>]`: 
          - `[DisplayName <String>]`: 
          - `[LastModifiedDateTime <DateTime?>]`: 
        - `[PaymentMethodId <String>]`: 
        - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
          - `[Code <String>]`: 
          - `[DiscountDateCalculation <String>]`: 
          - `[DiscountPercent <Decimal?>]`: 
          - `[DisplayName <String>]`: 
          - `[DueDateCalculation <String>]`: 
          - `[LastModifiedDateTime <DateTime?>]`: 
        - `[PaymentTermsId <String>]`: 
        - `[PhoneNumber <String>]`: 
        - `[Picture <IMicrosoftGraphPicture[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[Content <Byte[]>]`: 
          - `[ContentType <String>]`: 
          - `[Height <Int32?>]`: 
          - `[Width <Int32?>]`: 
        - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[Code <String>]`: 
          - `[DisplayName <String>]`: 
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
      - `[JournalDisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[LineNumber <Int32?>]`: 
      - `[PostingDate <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[CustomerPayments <IMicrosoftGraphCustomerPayment[]>]`: 
  - `[Customers <IMicrosoftGraphCustomer[]>]`: 
  - `[DimensionValues <IMicrosoftGraphDimensionValue[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Dimensions <IMicrosoftGraphDimension[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DimensionValues <IMicrosoftGraphDimensionValue[]>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[Employees <IMicrosoftGraphEmployee[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[BirthDate <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[EmploymentDate <DateTime?>]`: 
    - `[GivenName <String>]`: 
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
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AccountNumber <String>]`: 
    - `[CreditAmount <Decimal?>]`: 
    - `[DebitAmount <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DocumentNumber <String>]`: 
    - `[DocumentType <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PostingDate <DateTime?>]`: 
  - `[ItemCategories <IMicrosoftGraphItemCategory[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Items <IMicrosoftGraphItem[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[BaseUnitOfMeasureId <String>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[Gtin <String>]`: 
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
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AccountNumber <String>]`: 
    - `[Amount <Decimal?>]`: 
    - `[Comment <String>]`: 
    - `[Description <String>]`: 
    - `[DocumentNumber <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[JournalDisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[LineNumber <Int32?>]`: 
    - `[PostingDate <DateTime?>]`: 
  - `[Journals <IMicrosoftGraphJournal[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[BalancingAccountId <String>]`: 
    - `[BalancingAccountNumber <String>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[JournalLines <IMicrosoftGraphJournalLine[]>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Name <String>]`: 
  - `[PaymentMethods <IMicrosoftGraphPaymentMethod[]>]`: 
  - `[PaymentTerms <IMicrosoftGraphPaymentTerm[]>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
  - `[PurchaseInvoiceLines <IMicrosoftGraphPurchaseInvoiceLine[]>]`: 
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
    - `[BuyFromAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DueDate <DateTime?>]`: 
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
      - `[Id <String>]`: Read-only.
      - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
      - `[Balance <Decimal?>]`: 
      - `[Blocked <String>]`: 
      - `[Currency <IMicrosoftGraphCurrency>]`: currency
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Email <String>]`: 
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[TaxType <String>]`: 
  - `[TaxGroups <IMicrosoftGraphTaxGroup[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[TaxType <String>]`: 
  - `[UnitsOfMeasure <IMicrosoftGraphUnitOfMeasure[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[InternationalStandardCode <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Vendors <IMicrosoftGraphVendor[]>]`: 

COMPANYINFORMATION <IMicrosoftGraphCompanyInformation1[]>: .
  - `[Id <String>]`: Read-only.
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
  - `[Industry <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PhoneNumber <String>]`: 
  - `[Picture <Byte[]>]`: 
  - `[TaxRegistrationNumber <String>]`: 
  - `[Website <String>]`: 

COUNTRIESREGIONS <IMicrosoftGraphCountryRegion[]>: .
  - `[Id <String>]`: Read-only.
  - `[AddressFormat <String>]`: 
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

CURRENCIES <IMicrosoftGraphCurrency[]>: .
  - `[Id <String>]`: Read-only.
  - `[AmountDecimalPlaces <String>]`: 
  - `[AmountRoundingPrecision <Decimal?>]`: 
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Symbol <String>]`: 

CUSTOMERPAYMENTJOURNALS <IMicrosoftGraphCustomerPaymentJournal[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
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
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
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
        - `[Id <String>]`: Read-only.
        - `[AmountDecimalPlaces <String>]`: 
        - `[AmountRoundingPrecision <Decimal?>]`: 
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[Symbol <String>]`: 
      - `[CurrencyCode <String>]`: 
      - `[CurrencyId <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Email <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
      - `[PaymentMethodId <String>]`: 
      - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
        - `[Code <String>]`: 
        - `[DiscountDateCalculation <String>]`: 
        - `[DiscountPercent <Decimal?>]`: 
        - `[DisplayName <String>]`: 
        - `[DueDateCalculation <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
      - `[PaymentTermsId <String>]`: 
      - `[PhoneNumber <String>]`: 
      - `[Picture <IMicrosoftGraphPicture[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[Content <Byte[]>]`: 
        - `[ContentType <String>]`: 
        - `[Height <Int32?>]`: 
        - `[Width <Int32?>]`: 
      - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
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
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
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
      - `[Id <String>]`: Read-only.
      - `[AmountDecimalPlaces <String>]`: 
      - `[AmountRoundingPrecision <Decimal?>]`: 
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Symbol <String>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
      - `[Code <String>]`: 
      - `[DiscountDateCalculation <String>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DisplayName <String>]`: 
      - `[DueDateCalculation <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
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
  - `[JournalDisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[LineNumber <Int32?>]`: 
  - `[PostingDate <DateTime?>]`: 

CUSTOMERS <IMicrosoftGraphCustomer[]>: .
  - `[Id <String>]`: Read-only.
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
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Email <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PaymentMethodId <String>]`: 
  - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
    - `[Code <String>]`: 
    - `[DiscountDateCalculation <String>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DisplayName <String>]`: 
    - `[DueDateCalculation <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PaymentTermsId <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[ShipmentMethodId <String>]`: 
  - `[TaxAreaDisplayName <String>]`: 
  - `[TaxAreaId <String>]`: 
  - `[TaxLiable <Boolean?>]`: 
  - `[TaxRegistrationNumber <String>]`: 
  - `[Type <String>]`: 
  - `[Website <String>]`: 

DIMENSIONS <IMicrosoftGraphDimension[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DimensionValues <IMicrosoftGraphDimensionValue[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

DIMENSIONVALUES <IMicrosoftGraphDimensionValue[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

EMPLOYEES <IMicrosoftGraphEmployee[]>: .
  - `[Id <String>]`: Read-only.
  - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: 
    - `[CountryLetterCode <String>]`: 
    - `[PostalCode <String>]`: 
    - `[State <String>]`: 
    - `[Street <String>]`: 
  - `[BirthDate <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[Email <String>]`: 
  - `[EmploymentDate <DateTime?>]`: 
  - `[GivenName <String>]`: 
  - `[JobTitle <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[MiddleName <String>]`: 
  - `[MobilePhone <String>]`: 
  - `[Number <String>]`: 
  - `[PersonalEmail <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[StatisticsGroupCode <String>]`: 
  - `[Status <String>]`: 
  - `[Surname <String>]`: 
  - `[TerminationDate <DateTime?>]`: 

GENERALLEDGERENTRIES <IMicrosoftGraphGeneralLedgerEntry[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
  - `[AccountId <String>]`: 
  - `[AccountNumber <String>]`: 
  - `[CreditAmount <Decimal?>]`: 
  - `[DebitAmount <Decimal?>]`: 
  - `[Description <String>]`: 
  - `[DocumentNumber <String>]`: 
  - `[DocumentType <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PostingDate <DateTime?>]`: 

ITEMCATEGORIES <IMicrosoftGraphItemCategory[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

ITEMS <IMicrosoftGraphItem[]>: .
  - `[Id <String>]`: Read-only.
  - `[BaseUnitOfMeasureId <String>]`: 
  - `[Blocked <Boolean?>]`: 
  - `[DisplayName <String>]`: 
  - `[Gtin <String>]`: 
  - `[Inventory <Decimal?>]`: 
  - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[ItemCategoryCode <String>]`: 
  - `[ItemCategoryId <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[PriceIncludesTax <Boolean?>]`: 
  - `[TaxGroupCode <String>]`: 
  - `[TaxGroupId <String>]`: 
  - `[Type <String>]`: 
  - `[UnitCost <Decimal?>]`: 
  - `[UnitPrice <Decimal?>]`: 

JOURNALLINES <IMicrosoftGraphJournalLine[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
  - `[AccountId <String>]`: 
  - `[AccountNumber <String>]`: 
  - `[Amount <Decimal?>]`: 
  - `[Comment <String>]`: 
  - `[Description <String>]`: 
  - `[DocumentNumber <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
  - `[JournalDisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[LineNumber <Int32?>]`: 
  - `[PostingDate <DateTime?>]`: 

JOURNALS <IMicrosoftGraphJournal[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
  - `[BalancingAccountId <String>]`: 
  - `[BalancingAccountNumber <String>]`: 
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[JournalLines <IMicrosoftGraphJournalLine[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
    - `[AccountId <String>]`: 
    - `[AccountNumber <String>]`: 
    - `[Amount <Decimal?>]`: 
    - `[Comment <String>]`: 
    - `[Description <String>]`: 
    - `[DocumentNumber <String>]`: 
    - `[ExternalDocumentNumber <String>]`: 
    - `[JournalDisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[LineNumber <Int32?>]`: 
    - `[PostingDate <DateTime?>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

PAYMENTMETHODS <IMicrosoftGraphPaymentMethod[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

PAYMENTTERMS <IMicrosoftGraphPaymentTerm[]>: .
  - `[Id <String>]`: Read-only.
  - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
  - `[Code <String>]`: 
  - `[DiscountDateCalculation <String>]`: 
  - `[DiscountPercent <Decimal?>]`: 
  - `[DisplayName <String>]`: 
  - `[DueDateCalculation <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

PICTURE <IMicrosoftGraphPicture[]>: .
  - `[Id <String>]`: Read-only.
  - `[Content <Byte[]>]`: 
  - `[ContentType <String>]`: 
  - `[Height <Int32?>]`: 
  - `[Width <Int32?>]`: 

PURCHASEINVOICELINES <IMicrosoftGraphPurchaseInvoiceLine[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
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
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[BaseUnitOfMeasureId <String>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[Gtin <String>]`: 
    - `[Inventory <Decimal?>]`: 
    - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ItemCategoryCode <String>]`: 
    - `[ItemCategoryId <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[PriceIncludesTax <Boolean?>]`: 
    - `[TaxGroupCode <String>]`: 
    - `[TaxGroupId <String>]`: 
    - `[Type <String>]`: 
    - `[UnitCost <Decimal?>]`: 
    - `[UnitPrice <Decimal?>]`: 
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

PURCHASEINVOICES <IMicrosoftGraphPurchaseInvoice[]>: .
  - `[Id <String>]`: Read-only.
  - `[BuyFromAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: 
    - `[CountryLetterCode <String>]`: 
    - `[PostalCode <String>]`: 
    - `[State <String>]`: 
    - `[Street <String>]`: 
  - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[DueDate <DateTime?>]`: 
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
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Blocked <Boolean?>]`: 
      - `[Category <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[SubCategory <String>]`: 
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
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[BaseUnitOfMeasureId <String>]`: 
      - `[Blocked <Boolean?>]`: 
      - `[DisplayName <String>]`: 
      - `[Gtin <String>]`: 
      - `[Inventory <Decimal?>]`: 
      - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
      - `[ItemCategoryCode <String>]`: 
      - `[ItemCategoryId <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[Picture <IMicrosoftGraphPicture[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[Content <Byte[]>]`: 
        - `[ContentType <String>]`: 
        - `[Height <Int32?>]`: 
        - `[Width <Int32?>]`: 
      - `[PriceIncludesTax <Boolean?>]`: 
      - `[TaxGroupCode <String>]`: 
      - `[TaxGroupId <String>]`: 
      - `[Type <String>]`: 
      - `[UnitCost <Decimal?>]`: 
      - `[UnitPrice <Decimal?>]`: 
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
  - `[ShipToAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
  - `[ShipToContact <String>]`: 
  - `[ShipToName <String>]`: 
  - `[Status <String>]`: 
  - `[TotalAmountExcludingTax <Decimal?>]`: 
  - `[TotalAmountIncludingTax <Decimal?>]`: 
  - `[TotalTaxAmount <Decimal?>]`: 
  - `[Vendor <IMicrosoftGraphVendor>]`: vendor
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Balance <Decimal?>]`: 
    - `[Blocked <String>]`: 
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
      - `[Code <String>]`: 
      - `[DiscountDateCalculation <String>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DisplayName <String>]`: 
      - `[DueDateCalculation <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
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

SALESCREDITMEMOLINES <IMicrosoftGraphSalesCreditMemoLine[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
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
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[BaseUnitOfMeasureId <String>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[Gtin <String>]`: 
    - `[Inventory <Decimal?>]`: 
    - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ItemCategoryCode <String>]`: 
    - `[ItemCategoryId <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[PriceIncludesTax <Boolean?>]`: 
    - `[TaxGroupCode <String>]`: 
    - `[TaxGroupId <String>]`: 
    - `[Type <String>]`: 
    - `[UnitCost <Decimal?>]`: 
    - `[UnitPrice <Decimal?>]`: 
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

SALESCREDITMEMOS <IMicrosoftGraphSalesCreditMemo[]>: .
  - `[Id <String>]`: Read-only.
  - `[BillToCustomerId <String>]`: 
  - `[BillToCustomerNumber <String>]`: 
  - `[BillToName <String>]`: 
  - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: 
    - `[CountryLetterCode <String>]`: 
    - `[PostalCode <String>]`: 
    - `[State <String>]`: 
    - `[Street <String>]`: 
  - `[CreditMemoDate <DateTime?>]`: 
  - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Blocked <String>]`: 
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
      - `[Code <String>]`: 
      - `[DiscountDateCalculation <String>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DisplayName <String>]`: 
      - `[DueDateCalculation <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ShipmentMethodId <String>]`: 
    - `[TaxAreaDisplayName <String>]`: 
    - `[TaxAreaId <String>]`: 
    - `[TaxLiable <Boolean?>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Type <String>]`: 
    - `[Website <String>]`: 
  - `[CustomerId <String>]`: 
  - `[CustomerName <String>]`: 
  - `[CustomerNumber <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[DueDate <DateTime?>]`: 
  - `[Email <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
  - `[InvoiceId <String>]`: 
  - `[InvoiceNumber <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
  - `[PaymentTermsId <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[PricesIncludeTax <Boolean?>]`: 
  - `[SalesCreditMemoLines <IMicrosoftGraphSalesCreditMemoLine[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Blocked <Boolean?>]`: 
      - `[Category <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[SubCategory <String>]`: 
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
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[BaseUnitOfMeasureId <String>]`: 
      - `[Blocked <Boolean?>]`: 
      - `[DisplayName <String>]`: 
      - `[Gtin <String>]`: 
      - `[Inventory <Decimal?>]`: 
      - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
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
  - `[Salesperson <String>]`: 
  - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
  - `[Status <String>]`: 
  - `[TotalAmountExcludingTax <Decimal?>]`: 
  - `[TotalAmountIncludingTax <Decimal?>]`: 
  - `[TotalTaxAmount <Decimal?>]`: 

SALESINVOICELINES <IMicrosoftGraphSalesInvoiceLine[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
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
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[BaseUnitOfMeasureId <String>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[Gtin <String>]`: 
    - `[Inventory <Decimal?>]`: 
    - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ItemCategoryCode <String>]`: 
    - `[ItemCategoryId <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[PriceIncludesTax <Boolean?>]`: 
    - `[TaxGroupCode <String>]`: 
    - `[TaxGroupId <String>]`: 
    - `[Type <String>]`: 
    - `[UnitCost <Decimal?>]`: 
    - `[UnitPrice <Decimal?>]`: 
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

SALESINVOICES <IMicrosoftGraphSalesInvoice[]>: .
  - `[Id <String>]`: Read-only.
  - `[BillToCustomerId <String>]`: 
  - `[BillToCustomerNumber <String>]`: 
  - `[BillToName <String>]`: 
  - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: 
    - `[CountryLetterCode <String>]`: 
    - `[PostalCode <String>]`: 
    - `[State <String>]`: 
    - `[Street <String>]`: 
  - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Blocked <String>]`: 
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
      - `[Code <String>]`: 
      - `[DiscountDateCalculation <String>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DisplayName <String>]`: 
      - `[DueDateCalculation <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ShipmentMethodId <String>]`: 
    - `[TaxAreaDisplayName <String>]`: 
    - `[TaxAreaId <String>]`: 
    - `[TaxLiable <Boolean?>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Type <String>]`: 
    - `[Website <String>]`: 
  - `[CustomerId <String>]`: 
  - `[CustomerName <String>]`: 
  - `[CustomerNumber <String>]`: 
  - `[CustomerPurchaseOrderReference <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[DueDate <DateTime?>]`: 
  - `[Email <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
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
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Blocked <Boolean?>]`: 
      - `[Category <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[SubCategory <String>]`: 
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
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[BaseUnitOfMeasureId <String>]`: 
      - `[Blocked <Boolean?>]`: 
      - `[DisplayName <String>]`: 
      - `[Gtin <String>]`: 
      - `[Inventory <Decimal?>]`: 
      - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
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

SALESORDERLINES <IMicrosoftGraphSalesOrderLine[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
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
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[BaseUnitOfMeasureId <String>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[Gtin <String>]`: 
    - `[Inventory <Decimal?>]`: 
    - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ItemCategoryCode <String>]`: 
    - `[ItemCategoryId <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[PriceIncludesTax <Boolean?>]`: 
    - `[TaxGroupCode <String>]`: 
    - `[TaxGroupId <String>]`: 
    - `[Type <String>]`: 
    - `[UnitCost <Decimal?>]`: 
    - `[UnitPrice <Decimal?>]`: 
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

SALESORDERS <IMicrosoftGraphSalesOrder[]>: .
  - `[Id <String>]`: Read-only.
  - `[BillToCustomerId <String>]`: 
  - `[BillToCustomerNumber <String>]`: 
  - `[BillToName <String>]`: 
  - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: 
    - `[CountryLetterCode <String>]`: 
    - `[PostalCode <String>]`: 
    - `[State <String>]`: 
    - `[Street <String>]`: 
  - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Blocked <String>]`: 
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
      - `[Code <String>]`: 
      - `[DiscountDateCalculation <String>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DisplayName <String>]`: 
      - `[DueDateCalculation <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ShipmentMethodId <String>]`: 
    - `[TaxAreaDisplayName <String>]`: 
    - `[TaxAreaId <String>]`: 
    - `[TaxLiable <Boolean?>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Type <String>]`: 
    - `[Website <String>]`: 
  - `[CustomerId <String>]`: 
  - `[CustomerName <String>]`: 
  - `[CustomerNumber <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[Email <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
  - `[FullyShipped <Boolean?>]`: 
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
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Blocked <Boolean?>]`: 
      - `[Category <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[SubCategory <String>]`: 
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
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[BaseUnitOfMeasureId <String>]`: 
      - `[Blocked <Boolean?>]`: 
      - `[DisplayName <String>]`: 
      - `[Gtin <String>]`: 
      - `[Inventory <Decimal?>]`: 
      - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
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
  - `[Salesperson <String>]`: 
  - `[SellingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
  - `[ShipToContact <String>]`: 
  - `[ShipToName <String>]`: 
  - `[ShippingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
  - `[Status <String>]`: 
  - `[TotalAmountExcludingTax <Decimal?>]`: 
  - `[TotalAmountIncludingTax <Decimal?>]`: 
  - `[TotalTaxAmount <Decimal?>]`: 

SALESQUOTELINES <IMicrosoftGraphSalesQuoteLine[]>: .
  - `[Id <String>]`: Read-only.
  - `[Account <IMicrosoftGraphAccount>]`: account
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Blocked <Boolean?>]`: 
    - `[Category <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[SubCategory <String>]`: 
  - `[AccountId <String>]`: 
  - `[AmountExcludingTax <Decimal?>]`: 
  - `[AmountIncludingTax <Decimal?>]`: 
  - `[Description <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[DiscountPercent <Decimal?>]`: 
  - `[DocumentId <String>]`: 
  - `[Item <IMicrosoftGraphItem>]`: item
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[BaseUnitOfMeasureId <String>]`: 
    - `[Blocked <Boolean?>]`: 
    - `[DisplayName <String>]`: 
    - `[Gtin <String>]`: 
    - `[Inventory <Decimal?>]`: 
    - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ItemCategoryCode <String>]`: 
    - `[ItemCategoryId <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[PriceIncludesTax <Boolean?>]`: 
    - `[TaxGroupCode <String>]`: 
    - `[TaxGroupId <String>]`: 
    - `[Type <String>]`: 
    - `[UnitCost <Decimal?>]`: 
    - `[UnitPrice <Decimal?>]`: 
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

SALESQUOTES <IMicrosoftGraphSalesQuote[]>: .
  - `[Id <String>]`: Read-only.
  - `[AcceptedDate <DateTime?>]`: 
  - `[BillToCustomerId <String>]`: 
  - `[BillToCustomerNumber <String>]`: 
  - `[BillToName <String>]`: 
  - `[BillingPostalAddress <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: 
    - `[CountryLetterCode <String>]`: 
    - `[PostalCode <String>]`: 
    - `[State <String>]`: 
    - `[Street <String>]`: 
  - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[Blocked <String>]`: 
    - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[CurrencyCode <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Number <String>]`: 
    - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
      - `[Code <String>]`: 
      - `[DiscountDateCalculation <String>]`: 
      - `[DiscountPercent <Decimal?>]`: 
      - `[DisplayName <String>]`: 
      - `[DueDateCalculation <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[ShipmentMethod <IMicrosoftGraphShipmentMethod>]`: shipmentMethod
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Code <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ShipmentMethodId <String>]`: 
    - `[TaxAreaDisplayName <String>]`: 
    - `[TaxAreaId <String>]`: 
    - `[TaxLiable <Boolean?>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Type <String>]`: 
    - `[Website <String>]`: 
  - `[CustomerId <String>]`: 
  - `[CustomerName <String>]`: 
  - `[CustomerNumber <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DocumentDate <DateTime?>]`: 
  - `[DueDate <DateTime?>]`: 
  - `[Email <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
  - `[PaymentTermsId <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[SalesQuoteLines <IMicrosoftGraphSalesQuoteLine[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Account <IMicrosoftGraphAccount>]`: account
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Blocked <Boolean?>]`: 
      - `[Category <String>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Number <String>]`: 
      - `[SubCategory <String>]`: 
    - `[AccountId <String>]`: 
    - `[AmountExcludingTax <Decimal?>]`: 
    - `[AmountIncludingTax <Decimal?>]`: 
    - `[Description <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DocumentId <String>]`: 
    - `[Item <IMicrosoftGraphItem>]`: item
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[BaseUnitOfMeasureId <String>]`: 
      - `[Blocked <Boolean?>]`: 
      - `[DisplayName <String>]`: 
      - `[Gtin <String>]`: 
      - `[Inventory <Decimal?>]`: 
      - `[ItemCategory <IMicrosoftGraphItemCategory>]`: itemCategory
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Code <String>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
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

SHIPMENTMETHODS <IMicrosoftGraphShipmentMethod[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

TAXAREAS <IMicrosoftGraphTaxArea[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[TaxType <String>]`: 

TAXGROUPS <IMicrosoftGraphTaxGroup[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[TaxType <String>]`: 

UNITSOFMEASURE <IMicrosoftGraphUnitOfMeasure[]>: .
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[InternationalStandardCode <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

VENDORS <IMicrosoftGraphVendor[]>: .
  - `[Id <String>]`: Read-only.
  - `[Address <IMicrosoftGraphPostalAddressType>]`: postalAddressType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: 
    - `[CountryLetterCode <String>]`: 
    - `[PostalCode <String>]`: 
    - `[State <String>]`: 
    - `[Street <String>]`: 
  - `[Balance <Decimal?>]`: 
  - `[Blocked <String>]`: 
  - `[Currency <IMicrosoftGraphCurrency>]`: currency
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AmountDecimalPlaces <String>]`: 
    - `[AmountRoundingPrecision <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Symbol <String>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Email <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[PaymentMethod <IMicrosoftGraphPaymentMethod>]`: paymentMethod
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PaymentMethodId <String>]`: 
  - `[PaymentTerm <IMicrosoftGraphPaymentTerm>]`: paymentTerm
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
    - `[Code <String>]`: 
    - `[DiscountDateCalculation <String>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DisplayName <String>]`: 
    - `[DueDateCalculation <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PaymentTermsId <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[TaxLiable <Boolean?>]`: 
  - `[TaxRegistrationNumber <String>]`: 
  - `[Website <String>]`: 

## RELATED LINKS

