---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/update-mgfinancialcompanyitem
schema: 2.0.0
---

# Update-MgFinancialCompanyItem

## SYNOPSIS
Update the navigation property items in financials

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgFinancialCompanyItem -CompanyId <String> -ItemId <String> [-AdditionalProperties <Hashtable>]
 [-BaseUnitOfMeasureId <String>] [-Blocked] [-DisplayName <String>] [-Gtin <String>] [-Id <String>]
 [-Inventory <Decimal>] [-ItemCategory <IMicrosoftGraphItemCategory>] [-ItemCategoryCode <String>]
 [-ItemCategoryId <String>] [-LastModifiedDateTime <DateTime>] [-Number <String>]
 [-Picture <IMicrosoftGraphPicture[]>] [-PriceIncludesTax] [-TaxGroupCode <String>] [-TaxGroupId <String>]
 [-Type <String>] [-UnitCost <Decimal>] [-UnitPrice <Decimal>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgFinancialCompanyItem -CompanyId <String> -ItemId <String> -BodyParameter <IMicrosoftGraphItem>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgFinancialCompanyItem -InputObject <IFinancialsIdentity> -BodyParameter <IMicrosoftGraphItem>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgFinancialCompanyItem -InputObject <IFinancialsIdentity> [-AdditionalProperties <Hashtable>]
 [-BaseUnitOfMeasureId <String>] [-Blocked] [-DisplayName <String>] [-Gtin <String>] [-Id <String>]
 [-Inventory <Decimal>] [-ItemCategory <IMicrosoftGraphItemCategory>] [-ItemCategoryCode <String>]
 [-ItemCategoryId <String>] [-LastModifiedDateTime <DateTime>] [-Number <String>]
 [-Picture <IMicrosoftGraphPicture[]>] [-PriceIncludesTax] [-TaxGroupCode <String>] [-TaxGroupId <String>]
 [-Type <String>] [-UnitCost <Decimal>] [-UnitPrice <Decimal>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property items in financials

## EXAMPLES

## PARAMETERS

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

### -BaseUnitOfMeasureId
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
item
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItem
Parameter Sets: Update, UpdateViaIdentity
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

### -Gtin
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -Inventory
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

### -ItemCategory
itemCategory
To construct, please use Get-Help -Online and see NOTES section for ITEMCATEGORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemCategory
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ItemCategoryCode
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

### -ItemCategoryId
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

### -ItemId
key: id of item

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

### -Picture
.
To construct, please use Get-Help -Online and see NOTES section for PICTURE properties and create a hash table.

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

### -PriceIncludesTax
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

### -TaxGroupCode
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

### -TaxGroupId
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

### -UnitCost
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

### -UnitPrice
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItem

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphItem>: item
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

ITEMCATEGORY <IMicrosoftGraphItemCategory>: itemCategory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

PICTURE <IMicrosoftGraphPicture[]>: .
  - `[Id <String>]`: Read-only.
  - `[Content <Byte[]>]`: 
  - `[ContentType <String>]`: 
  - `[Height <Int32?>]`: 
  - `[Width <Int32?>]`: 

## RELATED LINKS

