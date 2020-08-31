---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/new-mgfinancialcompanysaleinvoiceline
schema: 2.0.0
---

# New-MgFinancialCompanySaleInvoiceLine

## SYNOPSIS
Create new navigation property to salesInvoiceLines for financials

## SYNTAX

### CreateExpanded (Default)
```
New-MgFinancialCompanySaleInvoiceLine -CompanyId <String> [-AccountBlocked] [-AccountCategory <String>]
 [-AccountDisplayName <String>] [-AccountId <String>] [-AccountId1 <String>]
 [-AccountLastModifiedDateTime <DateTime>] [-AccountNumber <String>] [-AccountSubCategory <String>]
 [-AmountExcludingTax <Decimal>] [-AmountIncludingTax <Decimal>] [-Code <String>] [-Description <String>]
 [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>]
 [-Id <String>] [-InvoiceDiscountAllocation <Decimal>] [-ItemBaseUnitOfMeasureId <String>] [-ItemBlocked]
 [-ItemCategoryCode <String>] [-ItemCategoryDisplayName <String>] [-ItemCategoryId <String>]
 [-ItemCategoryLastModifiedDateTime <DateTime>] [-ItemDisplayName <String>] [-ItemGtin <String>]
 [-ItemId <String>] [-ItemId1 <String>] [-ItemInventory <Decimal>] [-ItemLastModifiedDateTime <DateTime>]
 [-ItemNumber <String>] [-ItemPicture <IMicrosoftGraphPicture[]>] [-ItemPriceIncludesTax]
 [-ItemTaxGroupCode <String>] [-ItemTaxGroupId <String>] [-ItemType <String>] [-ItemUnitCost <Decimal>]
 [-ItemUnitPrice <Decimal>] [-LineType <String>] [-MicrosoftGraphEntityId <String>] [-NetAmount <Decimal>]
 [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>] [-Sequence <Int32>]
 [-ShipmentDate <DateTime>] [-TaxCode <String>] [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>]
 [-UnitOfMeasureId <String>] [-UnitPrice <Decimal>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgFinancialCompanySaleInvoiceLine -CompanyId <String> -BodyParameter <IMicrosoftGraphSalesInvoiceLine>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgFinancialCompanySaleInvoiceLine -CompanyId <String> -SalesInvoiceId <String>
 -BodyParameter <IMicrosoftGraphSalesInvoiceLine> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded1
```
New-MgFinancialCompanySaleInvoiceLine -CompanyId <String> -SalesInvoiceId <String> [-AccountBlocked]
 [-AccountCategory <String>] [-AccountDisplayName <String>] [-AccountId <String>] [-AccountId1 <String>]
 [-AccountLastModifiedDateTime <DateTime>] [-AccountNumber <String>] [-AccountSubCategory <String>]
 [-AmountExcludingTax <Decimal>] [-AmountIncludingTax <Decimal>] [-Code <String>] [-Description <String>]
 [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>]
 [-Id <String>] [-InvoiceDiscountAllocation <Decimal>] [-ItemBaseUnitOfMeasureId <String>] [-ItemBlocked]
 [-ItemCategoryCode <String>] [-ItemCategoryDisplayName <String>] [-ItemCategoryId <String>]
 [-ItemCategoryLastModifiedDateTime <DateTime>] [-ItemDisplayName <String>] [-ItemGtin <String>]
 [-ItemId <String>] [-ItemId1 <String>] [-ItemInventory <Decimal>] [-ItemLastModifiedDateTime <DateTime>]
 [-ItemNumber <String>] [-ItemPicture <IMicrosoftGraphPicture[]>] [-ItemPriceIncludesTax]
 [-ItemTaxGroupCode <String>] [-ItemTaxGroupId <String>] [-ItemType <String>] [-ItemUnitCost <Decimal>]
 [-ItemUnitPrice <Decimal>] [-LineType <String>] [-MicrosoftGraphEntityId <String>] [-NetAmount <Decimal>]
 [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>] [-Sequence <Int32>]
 [-ShipmentDate <DateTime>] [-TaxCode <String>] [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>]
 [-UnitOfMeasureId <String>] [-UnitPrice <Decimal>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgFinancialCompanySaleInvoiceLine -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphSalesInvoiceLine> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgFinancialCompanySaleInvoiceLine -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphSalesInvoiceLine> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgFinancialCompanySaleInvoiceLine -InputObject <IFinancialsIdentity> [-AccountBlocked]
 [-AccountCategory <String>] [-AccountDisplayName <String>] [-AccountId <String>] [-AccountId1 <String>]
 [-AccountLastModifiedDateTime <DateTime>] [-AccountNumber <String>] [-AccountSubCategory <String>]
 [-AmountExcludingTax <Decimal>] [-AmountIncludingTax <Decimal>] [-Code <String>] [-Description <String>]
 [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>]
 [-Id <String>] [-InvoiceDiscountAllocation <Decimal>] [-ItemBaseUnitOfMeasureId <String>] [-ItemBlocked]
 [-ItemCategoryCode <String>] [-ItemCategoryDisplayName <String>] [-ItemCategoryId <String>]
 [-ItemCategoryLastModifiedDateTime <DateTime>] [-ItemDisplayName <String>] [-ItemGtin <String>]
 [-ItemId <String>] [-ItemId1 <String>] [-ItemInventory <Decimal>] [-ItemLastModifiedDateTime <DateTime>]
 [-ItemNumber <String>] [-ItemPicture <IMicrosoftGraphPicture[]>] [-ItemPriceIncludesTax]
 [-ItemTaxGroupCode <String>] [-ItemTaxGroupId <String>] [-ItemType <String>] [-ItemUnitCost <Decimal>]
 [-ItemUnitPrice <Decimal>] [-LineType <String>] [-MicrosoftGraphEntityId <String>] [-NetAmount <Decimal>]
 [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>] [-Sequence <Int32>]
 [-ShipmentDate <DateTime>] [-TaxCode <String>] [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>]
 [-UnitOfMeasureId <String>] [-UnitPrice <Decimal>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgFinancialCompanySaleInvoiceLine -InputObject <IFinancialsIdentity> [-AccountBlocked]
 [-AccountCategory <String>] [-AccountDisplayName <String>] [-AccountId <String>] [-AccountId1 <String>]
 [-AccountLastModifiedDateTime <DateTime>] [-AccountNumber <String>] [-AccountSubCategory <String>]
 [-AmountExcludingTax <Decimal>] [-AmountIncludingTax <Decimal>] [-Code <String>] [-Description <String>]
 [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax] [-DiscountPercent <Decimal>] [-DocumentId <String>]
 [-Id <String>] [-InvoiceDiscountAllocation <Decimal>] [-ItemBaseUnitOfMeasureId <String>] [-ItemBlocked]
 [-ItemCategoryCode <String>] [-ItemCategoryDisplayName <String>] [-ItemCategoryId <String>]
 [-ItemCategoryLastModifiedDateTime <DateTime>] [-ItemDisplayName <String>] [-ItemGtin <String>]
 [-ItemId <String>] [-ItemId1 <String>] [-ItemInventory <Decimal>] [-ItemLastModifiedDateTime <DateTime>]
 [-ItemNumber <String>] [-ItemPicture <IMicrosoftGraphPicture[]>] [-ItemPriceIncludesTax]
 [-ItemTaxGroupCode <String>] [-ItemTaxGroupId <String>] [-ItemType <String>] [-ItemUnitCost <Decimal>]
 [-ItemUnitPrice <Decimal>] [-LineType <String>] [-MicrosoftGraphEntityId <String>] [-NetAmount <Decimal>]
 [-NetAmountIncludingTax <Decimal>] [-NetTaxAmount <Decimal>] [-Quantity <Decimal>] [-Sequence <Int32>]
 [-ShipmentDate <DateTime>] [-TaxCode <String>] [-TaxPercent <Decimal>] [-TotalTaxAmount <Decimal>]
 [-UnitOfMeasureId <String>] [-UnitPrice <Decimal>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to salesInvoiceLines for financials

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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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

### -AccountId1
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

### -AccountLastModifiedDateTime
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

### -AccountNumber
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

### -AccountSubCategory
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
salesInvoiceLine
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesInvoiceLine
Parameter Sets: Create, Create1, CreateViaIdentity, CreateViaIdentity1
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -ItemBaseUnitOfMeasureId
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

### -ItemBlocked
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

### -ItemCategoryCode
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

### -ItemCategoryDisplayName
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

### -ItemCategoryId
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

### -ItemCategoryLastModifiedDateTime
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

### -ItemDisplayName
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

### -ItemGtin
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

### -ItemId1
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

### -ItemInventory
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

### -ItemLastModifiedDateTime
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

### -ItemNumber
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

### -ItemPicture
.
To construct, see NOTES section for ITEMPICTURE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPicture[]
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ItemPriceIncludesTax
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

### -ItemTaxGroupCode
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

### -ItemTaxGroupId
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

### -ItemType
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

### -ItemUnitCost
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

### -ItemUnitPrice
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

### -MicrosoftGraphEntityId
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

### -SalesInvoiceId
key: salesInvoice-id of salesInvoice

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesInvoiceLine

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesInvoiceLine

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSalesInvoiceLine>: salesInvoiceLine
  - `[Id <String>]`: Read-only.
  - `[AccountBlocked <Boolean?>]`: 
  - `[AccountCategory <String>]`: 
  - `[AccountDisplayName <String>]`: 
  - `[AccountId <String>]`: 
  - `[AccountId1 <String>]`: Read-only.
  - `[AccountLastModifiedDateTime <DateTime?>]`: 
  - `[AccountNumber <String>]`: 
  - `[AccountSubCategory <String>]`: 
  - `[AmountExcludingTax <Decimal?>]`: 
  - `[AmountIncludingTax <Decimal?>]`: 
  - `[Code <String>]`: 
  - `[Description <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[DiscountPercent <Decimal?>]`: 
  - `[DocumentId <String>]`: 
  - `[InvoiceDiscountAllocation <Decimal?>]`: 
  - `[ItemBaseUnitOfMeasureId <String>]`: 
  - `[ItemBlocked <Boolean?>]`: 
  - `[ItemCategoryCode <String>]`: 
  - `[ItemCategoryDisplayName <String>]`: 
  - `[ItemCategoryId <String>]`: 
  - `[ItemCategoryLastModifiedDateTime <DateTime?>]`: 
  - `[ItemDisplayName <String>]`: 
  - `[ItemGtin <String>]`: 
  - `[ItemId <String>]`: 
  - `[ItemId1 <String>]`: Read-only.
  - `[ItemInventory <Decimal?>]`: 
  - `[ItemLastModifiedDateTime <DateTime?>]`: 
  - `[ItemNumber <String>]`: 
  - `[ItemPicture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[ItemPriceIncludesTax <Boolean?>]`: 
  - `[ItemTaxGroupCode <String>]`: 
  - `[ItemTaxGroupId <String>]`: 
  - `[ItemType <String>]`: 
  - `[ItemUnitCost <Decimal?>]`: 
  - `[ItemUnitPrice <Decimal?>]`: 
  - `[LineType <String>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
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

ITEMPICTURE <IMicrosoftGraphPicture[]>: .
  - `[Id <String>]`: Read-only.
  - `[Content <Byte[]>]`: 
  - `[ContentType <String>]`: 
  - `[Height <Int32?>]`: 
  - `[Width <Int32?>]`: 

## RELATED LINKS

