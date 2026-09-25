using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> BookingsCmdletConfigurations =
    [
        // The SDK ships no cmdlets for the /solutions root singleton itself (Get-MgSolution /
        // Update-MgSolution do not exist): src/Bookings/Bookings.md removes every solutionsRoot
        // operation with remove-path-by-operation ^solution\.solutionsRoot.*$. Exact-path, all
        // methods, so operations on children like /solutions/bookingBusinesses are unaffected.
        new(OverrideKind.SuppressOperation, Method: null, "/solutions", Match: PathMatch.Exact, Value: null,
            Reason: "Bookings.md remove-path-by-operation ^solution\\.solutionsRoot.*$"),

        // Most nouns under /solutions/ drop the "Solution" prefix (for example
        // Get-MgBookingBusiness, Get-MgVirtualEventWebinar). BackupRestore is a known
        // exception where published cmdlets keep the Solution prefix.
        new(OverrideKind.StripNounPrefix, Method: null, "/solutions/", Match: PathMatch.Prefix, Value: "Solution",
            Reason: "Bookings/VirtualEvents naming pattern under /solutions/*; BackupRestore is explicitly excluded in ApplyNounOverrides"),

        new(OverrideKind.SuppressOperation, Method: null, "/solutions/virtualevents", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: the virtualEvents root node ships nothing; children ship (Get-MgVirtualEventWebinar)"),
    ];
}
