// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Extensions;
using System;
using System.Globalization;

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    /// <summary>
    /// Microsoft Graph service profile.
    /// </summary>
    public class PSGraphServiceProfile
    {
        /// <summary>
        /// The name of the profile.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of a profile.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Creates a new <see cref="PSGraphServiceProfile"/> object.
        /// </summary>
        /// <param name="name">The name of the profile to create.</param>
        /// <returns>A new <see cref="PSGraphServiceProfile"/>.</returns>
        internal static PSGraphServiceProfile Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            return new PSGraphServiceProfile { Name = GetProfileVersion(name), Description = GetProfileDescription(name) };
        }

        /// <summary>
        /// Gets a full description of the profile.
        /// </summary>
        /// <param name="profileName">The name of a profile.</param>
        /// <returns>A full description of a profile.</returns>
        internal static string GetProfileDescription(string profileName)
        {
            if (profileName.ContainsValue("USGOV-DOD"))
            {
                return string.Format(CultureInfo.CurrentCulture, Constants.ProfileDescription, GetProfileVersion(profileName), "the US Government L5 (DOD)");
            }
            else if (profileName.ContainsValue("USGOV"))
            {
                return string.Format(CultureInfo.CurrentCulture, Constants.ProfileDescription, GetProfileVersion(profileName), "the US Government L4");
            }
            else if (profileName.ContainsValue("Germany"))
            {
                return string.Format(CultureInfo.CurrentCulture, Constants.ProfileDescription, GetProfileVersion(profileName), "Germany");
            }
            else if (profileName.ContainsValue("China"))
            {
                return string.Format(CultureInfo.CurrentCulture, Constants.ProfileDescription, GetProfileVersion(profileName), "China");
            }
            else
            {
                return string.Format(CultureInfo.CurrentCulture,Constants.ProfileDescription, GetProfileVersion(profileName), "the Global");
            }

        }

        /// <summary>
        /// Gets the version of a profile.
        /// </summary>
        /// <param name="profileName">The name of a profile.</param>
        /// <returns>The version of a profile.</returns>
        internal static string GetProfileVersion(string profileName)
        {
            return profileName.ContainsValue("beta") ? "beta" : "v1.0";
        }
    }
}
