using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    // Mail.md's three shared directives are already covered by v1.0 derived parity
    // data. Mail_directiveMigrationMap.json and MailDirectiveMigrationTests review
    // that coverage without duplicating it here; beta has no compatible input.
    private static readonly List<Entry> MailCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, Method: null, "/replies/{}/replyto", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: the replyTo nav ships nothing under any root"),
    ];
}
