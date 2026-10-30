using System.Collections.Generic;
using System.Net.Http;
namespace WrapperGenerator;
public static partial class CmdletConfigurator
{
    // The published beta commands retain both roots as numbered parameter sets.
    // MgCommandMetadata retains only the first URI; official Financials 2.38.0 proxy
    // definitions prove the additional DimensionId, JournalId and alternative ItemId sets.
    private static readonly List<Entry> FinancialsCmdletConfigurations =
    [
        GroupVariants(new OperationVariantGroup(
        [
            new("GET", "/financials/companies/{company-id}/dimensionValues", "Root"),
            new("GET", "/financials/companies/{company-id}/dimensionValues/{dimensionValue-id}", "Root"),
            new("GET", "/financials/companies/{company-id}/dimensions/{dimension-id}/dimensionValues", "Nested"),
            new("GET", "/financials/companies/{company-id}/dimensions/{dimension-id}/dimensionValues/{dimensionValue-id}", "Nested"),
        ], "Root"), "Get-MgBetaFinancialCompanyDimensionValue: List/Get and List1/Get1 add DimensionId."),
        GroupVariants(new OperationVariantGroup(
        [
            new("GET", "/financials/companies/{company-id}/dimensionValues/$count", "Root"),
            new("GET", "/financials/companies/{company-id}/dimensions/{dimension-id}/dimensionValues/$count", "Nested"),
        ], "Root"), "Get-MgBetaFinancialCompanyDimensionValueCount: root Get1 and nested Get add DimensionId."),
        GroupVariants(new OperationVariantGroup(
        [
            new("GET", "/financials/companies/{company-id}/itemCategories", "Root"),
            new("GET", "/financials/companies/{company-id}/itemCategories/{itemCategory-id}", "Root"),
            new("GET", "/financials/companies/{company-id}/items/{item-id}/itemCategory", "Nested"),
        ], "Root"), "Get-MgBetaFinancialCompanyItemCategory: List/Get use ItemCategoryId; Get1 uses ItemId."),
        // Neither mandatory ID set contains the other, so writes cannot have a
        // natural root default. Keep the item navigation explicit, not suppressed.
        new(OverrideKind.ReplaceNoun, HttpMethod.Patch, "/financials/companies/{}/items/{}/itemcategory",
            PathMatch.Exact, "FinancialCompanyItemCategoryByItem",
            "Published Update1 uses ItemId, not ItemCategoryId; distinguish the /items/{item-id}/itemCategory write."),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/financials/companies/{}/items/{}/itemcategory",
            PathMatch.Exact, "FinancialCompanyItemCategoryByItem",
            "Published Delete1 uses ItemId, not ItemCategoryId; distinguish the /items/{item-id}/itemCategory write."),
        GroupVariants(new OperationVariantGroup(
        [
            new("GET", "/financials/companies/{company-id}/journalLines", "Root"),
            new("GET", "/financials/companies/{company-id}/journalLines/{journalLine-id}", "Root"),
            new("GET", "/financials/companies/{company-id}/journals/{journal-id}/journalLines", "Nested"),
            new("GET", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/{journalLine-id}", "Nested"),
        ], "Root"), "Get-MgBetaFinancialCompanyJournalLine: List/Get and List1/Get1 add JournalId."),
        GroupVariants(new OperationVariantGroup(
        [
            new("GET", "/financials/companies/{company-id}/journalLines/$count", "Root"),
            new("GET", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/$count", "Nested"),
        ], "Root"), "Get-MgBetaFinancialCompanyJournalLineCount: Get/Get1 add JournalId."),
        GroupVariants(new OperationVariantGroup(
        [
            new("GET", "/financials/companies/{company-id}/journalLines/{journalLine-id}/account", "Root"),
            new("GET", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/{journalLine-id}/account", "Nested"),
        ], "Root"), "Get-MgBetaFinancialCompanyJournalLineAccount: Get/Get1 add JournalId."),
        GroupVariants(new OperationVariantGroup(
        [
            new("POST", "/financials/companies/{company-id}/journalLines", "Root"),
            new("POST", "/financials/companies/{company-id}/journals/{journal-id}/journalLines", "Nested"),
        ], "Root"), "New-MgBetaFinancialCompanyJournalLine: Create/Create1 and expanded sets add JournalId."),
        GroupVariants(new OperationVariantGroup(
        [
            new("PATCH", "/financials/companies/{company-id}/journalLines/{journalLine-id}", "Root"),
            new("PATCH", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/{journalLine-id}", "Nested"),
        ], "Root"), "Update-MgBetaFinancialCompanyJournalLine: Update/Update1 and expanded sets add JournalId."),
        GroupVariants(new OperationVariantGroup(
        [
            new("DELETE", "/financials/companies/{company-id}/journalLines/{journalLine-id}", "Root"),
            new("DELETE", "/financials/companies/{company-id}/journals/{journal-id}/journalLines/{journalLine-id}", "Nested"),
        ], "Root"), "Remove-MgBetaFinancialCompanyJournalLine: Delete/Delete1 add JournalId."),
    ];
}
