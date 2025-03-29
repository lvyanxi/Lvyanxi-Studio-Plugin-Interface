// ILSPlugin.cs
using System.Collections.Generic;
using System;

public interface LSPlugin : IDisposable
{
    void Initialize();
    void Update();
    List<string> GetSupportedScenes();
    bool ShouldLoadInCurrentScene(string currentScene);
    void OnSceneLoaded(string sceneName);
    void OnSceneUnloaded(string sceneName);
}

