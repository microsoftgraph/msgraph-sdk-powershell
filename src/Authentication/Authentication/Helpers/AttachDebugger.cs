/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Management.Automation;

using Microsoft.Graph.PowerShell.Authentication.Cmdlets;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    internal static class AttachDebugger
    {
        internal static void Break(PSCmdlet invokedCmdLet)
        {
            while (!System.Diagnostics.Debugger.IsAttached)
            {
                Console.Error.WriteLine($"Waiting for debugger to attach to process {System.Diagnostics.Process.GetCurrentProcess().Id}");
                //invokedCmdLet.WriteDebug($"Waiting for debugger to attach to process {System.Diagnostics.Process.GetCurrentProcess().Id}");
                for (var i = 0; i < 50; i++)
                {
                    if (System.Diagnostics.Debugger.IsAttached)
                    {
                        break;
                    }
                    System.Threading.Thread.Sleep(100);
                    //invokedCmdLet.WriteDebug(".");
                    Console.Error.Write(".");
                }
                //invokedCmdLet.WriteDebug(Environment.NewLine);
                Console.Error.WriteLine();
            }
            System.Diagnostics.Debugger.Break();
        }
    }
}