﻿// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABILITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Python.Core;
using Microsoft.Python.LanguageServer.Extensibility;

namespace Microsoft.Python.LanguageServer.Extensions {
    /// <summary>
    /// Implemented on a class that can create a language server extension.
    /// This class must have a default constructor.
    /// </summary>
    public interface ILanguageServerExtensionProvider {
        /// <summary>
        /// Called when the extension is loaded for a language server.
        /// </summary>
        Task<ILanguageServerExtension> CreateAsync(IServiceContainer services, 
            IReadOnlyDictionary<string, object> properties, CancellationToken cancellationToken = default);
    }
}
