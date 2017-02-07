/**
 * HVH.Common - Common code that is shared between the projects
 * Copyright (c) Dorian Stoll 2017
 * Licensed under the terms of the MIT License
 */

using System;
using MadMilkman.Ini;

namespace HVH.Common.Settings
{
    [SectionName("connection")]
    public class ConnectionSettings : Settings<ConnectionSettings>
    {
        [IniSerialization("server")]
        public String server { get; set; }

        [IniSerialization("port")]
        public Int32 port { get; set; }
    }
}