---
external help file:
Module Name: Microsoft.Graph.Beta.Financials
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.financials/update-mgbetafinancialcompanytaxgroup
schema: 2.0.0
---

# Update-MgBetaFinancialCompanyTaxGroup

## SYNOPSIS
Update the navigation property taxGroups in financials

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaFinancialCompanyTaxGroup -CompanyId <String> -TaxGroupId <String>
 [-AdditionalProperties <Hashtable>] [-Code <String>] [-DisplayName <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-TaxType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaFinancialCompanyTaxGroup -CompanyId <String> -TaxGroupId <String>
 -BodyParameter <IMicrosoftGraphTaxGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaFinancialCompanyTaxGroup -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphTaxGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaFinancialCompanyTaxGroup -InputObject <IFinancialsIdentity> [-AdditionalProperties <Hashtable>]
 [-Code <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-TaxType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property taxGroups in financials

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
taxGroup
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTaxGroup
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

### -Id
The unique identifier for an entity.
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

### -TaxGroupId
The unique identifier of taxGroup

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

### -TaxType
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

### Microsoft.Graph.Beta.PowerShell.Models.IFinancialsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTaxGroup

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTaxGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphTaxGroup>`: taxGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[TaxType <String>]`: 

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

