using System.Diagnostics;
using System.IO;
using JetBrains.Annotations;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEditor.Toolbars;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FK.Common.Editor
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public static class MainToolbarButtons
    {
        [MainToolbarElement("Open Project Settings", defaultDockPosition = MainToolbarDockPosition.Left)]
        public static MainToolbarElement ProjectSettingsButton()
        {
            var icon = EditorGUIUtility.IconContent("SettingsIcon").image as Texture2D;
            var content = new MainToolbarContent(icon, "Project Settings");
            return new MainToolbarButton(content, () => SettingsService.OpenProjectSettings());
        }

#if UNITY_EDITOR_WIN
        [MainToolbarElement("Open Builds in File Explorer", defaultDockPosition = MainToolbarDockPosition.Left)]
        public static MainToolbarElement BuildsButton()
        {
            var content = new MainToolbarContent("Builds", "Open Builds in File Explorer");
            return new MainToolbarButton(content, () => Process.Start("explorer.exe", "Builds"));
        }
#endif

        public static MainToolbarButton GetSceneButton(string text, string scenePath)
        {
            string sceneName = Path.GetFileName(scenePath);
            var content = new MainToolbarContent(text, $"Open \"{sceneName}.unity\"");
            return new MainToolbarButton(content, () => TryOpenScene(scenePath));
        }

        private static bool TryOpenScene(string scenePath, OpenSceneMode openSceneMode = OpenSceneMode.Single)
        {
            if (Application.isPlaying || !EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                return false;

            Scene scene = EditorSceneManager.OpenScene(scenePath, openSceneMode);
            return scene.isLoaded;
        }
    }
}
