// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CommunityToolkit.WinUI.Controls;

public class LinkClickedEventArgs : EventArgs
{
    public Uri Uri { get; }

    public LinkClickedEventArgs(Uri uri)
    {
        this.Uri = uri;
    }
}
