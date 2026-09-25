using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> MailCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, Method: null, "/replies/{}/replyto", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: the replyTo nav ships nothing under any root"),
    ];
}
