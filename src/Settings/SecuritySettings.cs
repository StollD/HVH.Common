/**
 * HVH.Common - Common code that is shared between the projects
 * Copyright (c) Dorian Stoll 2017
 * Licensed under the terms of the MIT License
 */

using System;
using MadMilkman.Ini;

namespace HVH.Common.Settings
{
    [SectionName("security")]
    public class SecuritySettings : Settings<SecuritySettings>
    {
        [IniSerialization("keySize")]
        public Int32 keySize { get; set; }

        [IniSerialization("encryption")]
        public String encryption { get; set; }
    }
}