﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Owin.Security.Cookies
{
    /// <summary>
    /// Default values related to cookie-based authentication middleware
    /// </summary>
    public static class CookieAuthenticationDefaults
    {
        /// <summary>
        /// The default value used for CookieAuthenticationOptions.AuthenticationType
        /// </summary>
        public const string AuthenticationType = "Cookies";

        /// <summary>
        /// The AuthenticationType used specifically by the UseApplicationSignInCookie extension method.
        /// </summary>
        public const string ApplicationAuthenticationType = "Application";

        /// <summary>
        /// The AuthenticationType used specifically by the UseExternalSignInCookie extension method.
        /// </summary>
        public const string ExternalAuthenticationType = "External";

        /// <summary>
        /// The prefix used to provide a default CookieAuthenticationOptions.CookieName
        /// </summary>
        public const string CookiePrefix = ".AspNet.";

        /// <summary>
        /// The default value used by UseApplicationSignInCookie for the
        /// CookieAuthenticationOptions.LoginPath
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Login", Justification = "By design")]
        public const string LoginPath = "/Account/Login";

        /// <summary>
        /// The default value used by UseApplicationSignInCookie for the
        /// CookieAuthenticationOptions.LogoutPath
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Logout", Justification = "By design")]
        public const string LogoutPath = "/Account/Logout";

        /// <summary>
        /// The default value of the CookieAuthenticationOptions.ReturnUrlParameter
        /// </summary>
        public const string ReturnUrlParameter = "ReturnUrl";
    }
}