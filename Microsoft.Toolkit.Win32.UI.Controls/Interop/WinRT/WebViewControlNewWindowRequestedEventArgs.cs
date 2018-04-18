// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System;
using System.Security;

namespace Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT
{
    /// <summary>
    /// Provides data for the <see cref="IWebView.NewWindowRequested"/> event. This class cannot be inherited.
    /// </summary>
    /// <remarks>Copy from <see cref="Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs"/> to avoid requirement to link Windows.winmd</remarks>
    /// <seealso cref="System.EventArgs" />
    /// <seealso cref="Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs"/>
    public sealed class WebViewControlNewWindowRequestedEventArgs : EventArgs
    {
        [SecurityCritical]
        private readonly Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs _args;

        internal WebViewControlNewWindowRequestedEventArgs(Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs args)
        {
            _args = args ?? throw new ArgumentNullException(nameof(args));
        }

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="IWebView"/> is attempting to navigate to.
        /// </summary>
        /// <value>The Uniform Resource Identifier (URI) of the content the <see cref="IWebView"/> is attempting to navigate to.</value>
        public Uri Uri => _args.Uri;

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content where the navigation was initiated.
        /// </summary>
        /// <value>The the Uniform Resource Identifier (URI) of the content where the navigation was initiated.</value>
        public Uri Referrer => _args.Referrer;

        /// <summary>
        /// Gets or sets a value that marks the routed event as handled.
        /// </summary>
        /// <value><see langword="true" /> if handled; otherwise, <see langword="false" />.</value>
        public bool Handled
        {
            get => _args.Handled;
            set => _args.Handled = value;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs"/> to <see cref="WebViewControlNewWindowRequestedEventArgs"/>.
        /// </summary>
        /// <param name="args">The <see cref="Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs"/> instance containing the event data.</param>
        /// <returns>The result of the conversion.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates")]
        public static implicit operator WebViewControlNewWindowRequestedEventArgs(Windows.Web.UI.WebViewControlNewWindowRequestedEventArgs args) => new WebViewControlNewWindowRequestedEventArgs(args);
    }
}