// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell
{
    public static class PSCmdletExtensions
    {
        /// <summary>
        /// Overrides OnDefault method in the generated cmdlets.
        /// </summary>
        /// <param name="cmdlet">The calling <see cref="PSCmdlet"/></param>
        /// <param name="responseMessage">The HTTP response message from the service.</param>
        /// <param name="returnNow">Determines whether the caller should return after OverrideOnDefault is called, or not. </param>
        public static void OverrideOnDefault(this PSCmdlet cmdlet, System.Net.Http.HttpResponseMessage responseMessage, ref System.Threading.Tasks.Task<bool> returnNow)
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                if (cmdlet.MyInvocation?.BoundParameters?.ContainsKey("PassThru") == true)
                {
                    cmdlet.WriteObject(true);
                }
                returnNow = System.Threading.Tasks.Task.FromResult(true);
            }
        }

        /// <summary>
        /// Determines is a parameter has been provided by the user.
        /// </summary>
        /// <param name="cmdlet">The executing cmdlet.</param>
        /// <param name="parameterName">The name of the parameter to check.</param>
        /// <returns>True is the parameter was set by the user, otherwise false.</returns>
        public static bool IsParameterBound(this PSCmdlet cmdlet, string parameterName)
        {
            return cmdlet.MyInvocation?.BoundParameters.ContainsKey(parameterName) ?? false;
        }

        /// <summary>
        /// Determines is a parameter has been provided by the user.
        /// </summary>
        /// <typeparam name="TPSCmdlet">Cmdlet type.</typeparam>
        /// <typeparam name="TProp">Property type.</typeparam>
        /// <param name="cmdlet">The executing cmdlet.</param>
        /// <param name="propertySelector">The parameter to check</param>
        /// <returns>True is the parameter was set by the user, otherwise false.</returns>
        internal static bool IsParameterBound<TPSCmdlet, TProp>(this TPSCmdlet cmdlet, Expression<Func<TPSCmdlet, TProp>> propertySelector) where TPSCmdlet : PSCmdlet
        {
            var propName = ((MemberExpression)propertySelector.Body).Member.Name;
            return cmdlet.IsParameterBound(propName);
        }

        internal static void ThrowParameterError(this PSCmdlet cmdlet, string message, params object[] parameters)
        {
            cmdlet.ThrowError(message.FormatCurrentCulture(parameters), ErrorCategory.InvalidArgument);
        }

        internal static void ThrowParameterError(this PSCmdlet cmdlet, string parameterName)
        {
            cmdlet.ThrowError($"Must specify '{parameterName}'.", ErrorCategory.InvalidArgument);
        }

        internal static void ThrowError(this PSCmdlet cmdlet, string message, ErrorCategory errorCategory)
        {
            cmdlet.ThrowTerminatingError(
                new ErrorRecord(
                    new ArgumentException(message),
                    Guid.NewGuid().ToString(),
                    errorCategory,
                    null)
                );
        }

        /// <summary>
        /// Creates a <see cref="GraphSettings"/> with shared read access to the data store.
        /// </summary>
        /// <param name="cmdlet">The calling cmdlet.</param>
        /// <returns>A new instance of <see cref="GraphSettings"/>.</returns>
        internal static GraphSettings GetContextSettings(this PSCmdlet _)
            => new GraphSettings(ProtectedFileProvider.CreateFileProvider(Constants.ContextSettingsPath, FileProtection.SharedRead));

        internal static IEnumerable<T> RunScript<T>(string script)
            => System.Management.Automation.PowerShell.Create().AddScript(script).Invoke<T>();

        internal static IEnumerable<T> RunScript<T>(this PSCmdlet cmdlet, string script)
          => cmdlet?.InvokeCommand.RunScript<T>(script) ?? RunScript<T>(script);

        internal static IEnumerable<T> RunScript<T>(this CommandInvocationIntrinsics cii, string script)
            => cii.InvokeScript(script).Select(o => o?.BaseObject).Where(o => o != null).OfType<T>();
    }
}
