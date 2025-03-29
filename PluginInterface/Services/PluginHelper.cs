// PluginHelper.cs

using System;

public static class PluginHelper
{
    public static void ValidatePlugin(Type pluginType)
    {
        if (!typeof(LSPlugin).IsAssignableFrom(pluginType))
            throw new ArgumentException("Type must implement ILSPlugin");
    }
}