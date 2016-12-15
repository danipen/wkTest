﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal class DefaultDocumentTextDifferencingService : IDocumentTextDifferencingService
    {
        public async Task<IEnumerable<TextChange>> GetTextChangesAsync(Document oldDocument, Document newDocument, CancellationToken cancellationToken)
        {
            return await newDocument.GetTextChangesAsync(oldDocument, cancellationToken).ConfigureAwait(false);
        }
    }
}
