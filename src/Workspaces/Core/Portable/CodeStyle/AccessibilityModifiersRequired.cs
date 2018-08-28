﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.


using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CodeStyle
{
    internal enum AccessibilityModifiersRequired
    {
        // The rule is not run
        Never = 0,

        // Accessibility modifiers are added if missing, even if default
        Always = 1,

        // Future proofing for when C# adds default interface methods.  At that point
        // accessibility modifiers will be allowed in interfaces, and some people may
        // want to require them, while some may want to keep the traditional C# style
        // that public interface members do not need accessibility modifiers.
        ForNonInterfaceMembers = 2,

        // Remove any accessibility modifier that matches the default
        OmitIfDefault = 3
    }

    internal class EditorconfigOptionToAccessibilityModifiersRequired
    {
        internal static readonly Dictionary<string, AccessibilityModifiersRequired> options = new Dictionary<string, AccessibilityModifiersRequired>
        {
            { "always", AccessibilityModifiersRequired.Always },
            { "never", AccessibilityModifiersRequired.Never },
            { "for_non_interface_members", AccessibilityModifiersRequired.ForNonInterfaceMembers },
            { "omit_if_default", AccessibilityModifiersRequired.OmitIfDefault }
        };
    }
}
