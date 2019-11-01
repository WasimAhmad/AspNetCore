// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections.Features
{
    public interface IStreamListener
    {
        ValueTask<ConnectionContext> StartUnidirectionalStreamAsync();
        ValueTask<ConnectionContext> StartBidirectionalStreamAsync();
        ValueTask<ConnectionContext> AcceptAsync();
    }
}