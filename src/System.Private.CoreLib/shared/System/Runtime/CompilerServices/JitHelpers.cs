// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

////////////////////////////////////////////////////////////////////////////////
// JitHelpers
//    Low-level Jit Helpers
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Threading;
using System.Runtime;
using System.Runtime.Versioning;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using Internal.Runtime.CompilerServices;

namespace System.Runtime.CompilerServices
{
    internal static partial class JitHelpers
    {
        // The special dll name to be used for DllImport of QCalls
        internal const string QCall = "QCall";
    }
}