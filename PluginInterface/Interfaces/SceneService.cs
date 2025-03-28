public interface SceneService
{
    string GetCurrentSceneName();
    bool IsSceneLoaded(string sceneName);
}