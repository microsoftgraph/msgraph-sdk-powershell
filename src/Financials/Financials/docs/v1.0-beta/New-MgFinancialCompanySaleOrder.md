---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/new-mgfinancialcompanysaleorder
schema: 2.0.0
---

# New-MgFinancialCompanySaleOrder

## SYNOPSIS
Create new navigation property to salesOrders for financials

## SYNTAX

### CreateExpanded (Default)
```
New-MgFinancialCompanySaleOrder -CompanyId <String> [-AdditionalProperties <Hashtable>]
 [-BillingPostalAddress <IMicrosoftGraphPostalAddressType>] [-BillToCustomerId <String>]
 [-BillToCustomerNumber <String>] [-BillToName <String>] [-Currency <IMicrosoftGraphCurrency>]
 [-CurrencyCode <String>] [-CurrencyId <String>] [-Customer <IMicrosoftGraphCustomer>] [-CustomerId <String>]
 [-CustomerName <String>] [-CustomerNumber <String>] [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax]
 [-Email <String>] [-ExternalDocumentNumber <String>] [-FullyShipped] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-Number <String>] [-OrderDate <DateTime>] [-PartialShipping]
 [-PaymentTerm <IMicrosoftGraphPaymentTerm>] [-PaymentTermsId <String>] [-PhoneNumber <String>]
 [-PricesIncludeTax] [-RequestedDeliveryDate <DateTime>] [-SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]
 [-Salesperson <String>] [-SellingPostalAddress <IMicrosoftGraphPostalAddressType>]
 [-ShippingPostalAddress <IMicrosoftGraphPostalAddressType>] [-ShipToContact <String>] [-ShipToName <String>]
 [-Status <String>] [-TotalAmountExcludingTax <Decimal>] [-TotalAmountIncludingTax <Decimal>]
 [-TotalTaxAmount <Decimal>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgFinancialCompanySaleOrder -CompanyId <String> -BodyParameter <IMicrosoftGraphSalesOrder> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgFinancialCompanySaleOrder -InputObject <IFinancialsIdentity> -BodyParameter <IMicrosoftGraphSalesOrder>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgFinancialCompanySaleOrder -InputObject <IFinancialsIdentity> [-AdditionalProperties <Hashtable>]
 [-BillingPostalAddress <IMicrosoftGraphPostalAddressType>] [-BillToCustomerId <String>]
 [-BillToCustomerNumber <String>] [-BillToName <String>] [-Currency <IMicrosoftGraphCurrency>]
 [-CurrencyCode <String>] [-CurrencyId <String>] [-Customer <IMicrosoftGraphCustomer>] [-CustomerId <String>]
 [-CustomerName <String>] [-CustomerNumber <String>] [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax]
 [-Email <String>] [-ExternalDocumentNumber <String>] [-FullyShipped] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-Number <String>] [-OrderDate <DateTime>] [-PartialShipping]
 [-PaymentTerm <IMicrosoftGraphPaymentTerm>] [-PaymentTermsId <String>] [-PhoneNumber <String>]
 [-PricesIncludeTax] [-RequestedDeliveryDate <DateTime>] [-SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]
 [-Salesperson <String>] [-SellingPostalAddress <IMicrosoftGraphPostalAddressType>]
 [-ShippingPostalAddress <IMicrosoftGraphPostalAddressType>] [-ShipToContact <String>] [-ShipToName <String>]
 [-Status <String>] [-TotalAmountExcludingTax <Decimal>] [-TotalAmountIncludingTax <Decimal>]
 [-TotalTaxAmount <Decimal>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to salesOrders for financials

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BillingPostalAddress
postalAddressType
To construct, please use Get-Help -Online and see NOTES section for BILLINGPOSTALADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPostalAddressType
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BillToCustomerId
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

### -BillToCustomerNumber
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

### -BillToName
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
salesOrder
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrder
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Currency
currency
To construct, please use Get-Help -Online and see NOTES section for CURRENCY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCurrency
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Customer
customer
To construct, please use Get-Help -Online and see NOTES section for CUSTOMER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomer
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomerId
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

### -CustomerName
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

### -CustomerNumber
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

### -DiscountAmount
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalDocumentNumber
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

### -FullyShipped
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -Number
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

### -OrderDate
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

### -PartialShipping
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

### -PaymentTerm
paymentTerm
To construct, please use Get-Help -Online and see NOTES section for PAYMENTTERM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPaymentTerm
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PricesIncludeTax
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

### -RequestedDeliveryDate
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

### -SalesOrderLines
.
To construct, please use Get-Help -Online and see NOTES section for SALESORDERLINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrderLine[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Salesperson
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

### -SellingPostalAddress
postalAddressType
To construct, please use Get-Help -Online and see NOTES section for SELLINGPOSTALADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPostalAddressType
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShippingPostalAddress
postalAddressType
To construct, please use Get-Help -Online and see NOTES section for SHIPPINGPOSTALADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPostalAddressType
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipToContact
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

### -ShipToName
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

### -Status
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

### -TotalAmountExcludingTax
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TotalAmountIncludingTax
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrder

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrder

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BILLINGPOSTALADDRESS <IMicrosoftGraphPostalAddressType>: postalAddressType
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: 
  - `[CountryLetterCode <String>]`: 
  - `[PostalCode <String>]`: 
  - `[State <String>]`: 
  - `[Street <String>]`: 

BODYPARAMETER <IMicrosoftGraphSalesOrder>: salesOrder
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

CURRENCY <IMicrosoftGraphCurrency>: currency
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AmountDecimalPlaces <String>]`: 
  - `[AmountRoundingPrecision <Decimal?>]`: 
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Symbol <String>]`: 

CUSTOMER <IMicrosoftGraphCustomer>: customer
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

PAYMENTTERM <IMicrosoftGraphPaymentTerm>: paymentTerm
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CalculateDiscountOnCreditMemos <Boolean?>]`: 
  - `[Code <String>]`: 
  - `[DiscountDateCalculation <String>]`: 
  - `[DiscountPercent <Decimal?>]`: 
  - `[DisplayName <String>]`: 
  - `[DueDateCalculation <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 

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

SELLINGPOSTALADDRESS <IMicrosoftGraphPostalAddressType>: postalAddressType
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: 
  - `[CountryLetterCode <String>]`: 
  - `[PostalCode <String>]`: 
  - `[State <String>]`: 
  - `[Street <String>]`: 

SHIPPINGPOSTALADDRESS <IMicrosoftGraphPostalAddressType>: postalAddressType
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: 
  - `[CountryLetterCode <String>]`: 
  - `[PostalCode <String>]`: 
  - `[State <String>]`: 
  - `[Street <String>]`: 

## RELATED LINKS

