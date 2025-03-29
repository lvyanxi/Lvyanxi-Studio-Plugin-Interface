// PluginInfoAttribute.cs
using System;

[AttributeUsage(AttributeTargets.Class)]
public class PluginInfoAttribute : Attribute
{
    public string Author { get; }
    public string Description { get; }
    public string Version { get; }
    public string ReleaseDate { get; }

    public PluginInfoAttribute(string author, string description, string version, string releaseDate)
    {
        Author = author;
        Description = description;
        Version = version;
        ReleaseDate = releaseDate;
    }
}