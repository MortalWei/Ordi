﻿using System.Configuration;

namespace OrdiOwin.Core.Settings
{
            return ConfigurationManager.GetSection("loadedAssemblies") as LoadedAssembliesSettings;
}