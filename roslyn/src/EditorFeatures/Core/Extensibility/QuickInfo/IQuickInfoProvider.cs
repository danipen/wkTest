﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.CodeAnalysis.Editor
{
    internal interface IQuickInfoProvider
    {
        Task<QuickInfoItem> GetItemAsync(Document document, int position, CancellationToken cancellationToken);
    }
}
