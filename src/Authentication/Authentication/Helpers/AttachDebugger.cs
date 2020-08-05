// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Management.Automation;
using System.Threading;
using Debugger = System.Diagnostics.Debugger;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class AttachDebugger
    {
        internal static void Break(this PSCmdlet invokedCmdLet)
        {
            while (!Debugger.IsAttached)
            {
                Console.Error.WriteLine($"Waiting for debugger to attach to process {Process.GetCurrentProcess().Id}");
                for (var i = 0; i < 50; i++)
                {
                    if (Debugger.IsAttached)
                    {
                        break;
                    }

                    Thread.Sleep(100);
                    Console.Error.Write(".");
                }

                Console.Error.WriteLine();
            }

            Debugger.Break();
        }
    }
}