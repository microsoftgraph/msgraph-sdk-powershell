// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Interfaces
{
    using System;
    using System.IO;

    public interface IFileProvider : IDisposable
    {
        string FilePath { get; }
        Stream Stream { get; }
        StreamReader CreateReader();
        StreamWriter CreateWriter();
    }
}
