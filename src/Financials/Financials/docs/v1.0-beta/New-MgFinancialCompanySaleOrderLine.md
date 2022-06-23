---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/new-mgfinancialcompanysaleorderline
schema: 2.0.0
---

# New-MgFinancialCompanySaleOrderLine

## SYNOPSIS
Create new navigation property to salesOrderLines for financials

## SYNTAX

### CreateExpanded (Default)
```
New-MgFinancialCompanySaleOrderLine -CompanyId <String> [-Account <IMicrosoftGraphAccount>]
 [-AccountId <String>] [-AdditionalProperties <Hashtable>] [-AmountExcludingTax <Decimal>]
 [-AmountIncludingTax <Decimal>] [-Description <String>] [-DiscountAmount <Decimal>]
 [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>] [-Id <String>]
 [-InvoiceDiscountAllocation <Decimal>] [-InvoicedQuantity <Decimal>] [-InvoiceQuantity <Decimal>]
 [-Item <IMicrosoftGraphItem>] [-ItemId <String>] [-LineType <String>] [-NetAmount <Decimal>]
 [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>] [-Sequence <Int32>]
 [-ShipmentDate <DateTime>] [-ShippedQuantity <Decimal>] [-ShipQuantity <Decimal>] [-TaxCode <String>]
 [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>] [-UnitOfMeasureId <String>] [-UnitPrice <Decimal>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgFinancialCompanySaleOrderLine -CompanyId <String> -BodyParameter <IMicrosoftGraphSalesOrderLine>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgFinancialCompanySaleOrderLine -CompanyId <String> -SalesOrderId <String>
 -BodyParameter <IMicrosoftGraphSalesOrderLine> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded1
```
New-MgFinancialCompanySaleOrderLine -CompanyId <String> -SalesOrderId <String>
 [-Account <IMicrosoftGraphAccount>] [-AccountId <String>] [-AdditionalProperties <Hashtable>]
 [-AmountExcludingTax <Decimal>] [-AmountIncludingTax <Decimal>] [-Description <String>]
 [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>]
 [-Id <String>] [-InvoiceDiscountAllocation <Decimal>] [-InvoicedQuantity <Decimal>]
 [-InvoiceQuantity <Decimal>] [-Item <IMicrosoftGraphItem>] [-ItemId <String>] [-LineType <String>]
 [-NetAmount <Decimal>] [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>]
 [-Sequence <Int32>] [-ShipmentDate <DateTime>] [-ShippedQuantity <Decimal>] [-ShipQuantity <Decimal>]
 [-TaxCode <String>] [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>] [-UnitOfMeasureId <String>]
 [-UnitPrice <Decimal>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgFinancialCompanySaleOrderLine -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphSalesOrderLine> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgFinancialCompanySaleOrderLine -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphSalesOrderLine> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgFinancialCompanySaleOrderLine -InputObject <IFinancialsIdentity> [-Account <IMicrosoftGraphAccount>]
 [-AccountId <String>] [-AdditionalProperties <Hashtable>] [-AmountExcludingTax <Decimal>]
 [-AmountIncludingTax <Decimal>] [-Description <String>] [-DiscountAmount <Decimal>]
 [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>] [-Id <String>]
 [-InvoiceDiscountAllocation <Decimal>] [-InvoicedQuantity <Decimal>] [-InvoiceQuantity <Decimal>]
 [-Item <IMicrosoftGraphItem>] [-ItemId <String>] [-LineType <String>] [-NetAmount <Decimal>]
 [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>] [-Sequence <Int32>]
 [-ShipmentDate <DateTime>] [-ShippedQuantity <Decimal>] [-ShipQuantity <Decimal>] [-TaxCode <String>]
 [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>] [-UnitOfMeasureId <String>] [-UnitPrice <Decimal>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgFinancialCompanySaleOrderLine -InputObject <IFinancialsIdentity> [-Account <IMicrosoftGraphAccount>]
 [-AccountId <String>] [-AdditionalProperties <Hashtable>] [-AmountExcludingTax <Decimal>]
 [-AmountIncludingTax <Decimal>] [-Description <String>] [-DiscountAmount <Decimal>]
 [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>] [-Id <String>]
 [-InvoiceDiscountAllocation <Decimal>] [-InvoicedQuantity <Decimal>] [-InvoiceQuantity <Decimal>]
 [-Item <IMicrosoftGraphItem>] [-ItemId <String>] [-LineType <String>] [-NetAmount <Decimal>]
 [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>] [-Sequence <Int32>]
 [-ShipmentDate <DateTime>] [-ShippedQuantity <Decimal>] [-ShipQuantity <Decimal>] [-TaxCode <String>]
 [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>] [-UnitOfMeasureId <String>] [-UnitPrice <Decimal>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to salesOrderLines for financials

## EXAMPLES

## PARAMETERS

### -Account
account
To construct, please use Get-Help -Online and see NOTES section for ACCOUNT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccount
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AmountExcludingTax
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AmountIncludingTax
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
salesOrderLine
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrderLine
Parameter Sets: Create, Create1, CreateViaIdentity, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyId
key: id of company

```yaml
Type: System.String
Parameter Sets: Create, Create1, CreateExpanded, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiscountAmount
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiscountAppliedBeforeTax
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiscountPercent
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DocumentId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IFinancialsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentity1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InvoiceDiscountAllocation
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoicedQuantity
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InvoiceQuantity
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Item
item
To construct, please use Get-Help -Online and see NOTES section for ITEM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItem
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ItemId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LineType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetAmount
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetAmountIncludingTax
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetTaxAmount
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Quantity
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SalesOrderId
key: id of salesOrder

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sequence
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentDate
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShippedQuantity
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipQuantity
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaxPercent
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TotalTaxAmount
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnitOfMeasureId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnitPrice
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrderLine

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrderLine

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCOUNT <IMicrosoftGraphAccount>: account
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Blocked <Boolean?>]`: 
  - `[Category <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Number <String>]`: 
  - `[SubCategory <String>]`: 

BODYPARAMETER <IMicrosoftGraphSalesOrderLine>: salesOrderLine
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

INPUTOBJECT <IFinancialsIdentity>: Identity Parameter
  - `[AccountId <String>]`: key: id of account
  - `[AgedAccountsPayableId <String>]`: key: id of agedAccountsPayable
  - `[AgedAccountsReceivableId <String>]`: key: id of agedAccountsReceivable
  - `[CompanyId <String>]`: key: id of company
  - `[CompanyInformationId <String>]`: key: id of companyInformation
  - `[CountryRegionId <String>]`: key: id of countryRegion
  - `[CurrencyId <String>]`: key: id of currency
  - `[CustomerId <String>]`: key: id of customer
  - `[CustomerPaymentId <String>]`: key: id of customerPayment
  - `[CustomerPaymentJournalId <String>]`: key: id of customerPaymentJournal
  - `[DimensionId <String>]`: key: id of dimension
  - `[DimensionValueId <String>]`: key: id of dimensionValue
  - `[EmployeeId <String>]`: key: id of employee
  - `[GeneralLedgerEntryId <String>]`: key: id of generalLedgerEntry
  - `[ItemCategoryId <String>]`: key: id of itemCategory
  - `[ItemId <String>]`: key: id of item
  - `[JournalId <String>]`: key: id of journal
  - `[JournalLineId <String>]`: key: id of journalLine
  - `[PaymentMethodId <String>]`: key: id of paymentMethod
  - `[PaymentTermId <String>]`: key: id of paymentTerm
  - `[PictureId <String>]`: key: id of picture
  - `[PurchaseInvoiceId <String>]`: key: id of purchaseInvoice
  - `[PurchaseInvoiceLineId <String>]`: key: id of purchaseInvoiceLine
  - `[SalesCreditMemoId <String>]`: key: id of salesCreditMemo
  - `[SalesCreditMemoLineId <String>]`: key: id of salesCreditMemoLine
  - `[SalesInvoiceId <String>]`: key: id of salesInvoice
  - `[SalesInvoiceLineId <String>]`: key: id of salesInvoiceLine
  - `[SalesOrderId <String>]`: key: id of salesOrder
  - `[SalesOrderLineId <String>]`: key: id of salesOrderLine
  - `[SalesQuoteId <String>]`: key: id of salesQuote
  - `[SalesQuoteLineId <String>]`: key: id of salesQuoteLine
  - `[ShipmentMethodId <String>]`: key: id of shipmentMethod
  - `[TaxAreaId <String>]`: key: id of taxArea
  - `[TaxGroupId <String>]`: key: id of taxGroup
  - `[UnitOfMeasureId <String>]`: key: id of unitOfMeasure
  - `[VendorId <String>]`: key: id of vendor

ITEM <IMicrosoftGraphItem>: item
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

## RELATED LINKS

