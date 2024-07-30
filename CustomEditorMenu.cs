// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//
// **************************************************************** //

#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEngine;

namespace AbyssMoth
{
    [HelpURL("https://github.com/RimuruDev/Unity-YandexGame-Cleaner-Helper")]
    public sealed class CustomEditorMenu
    {
        private const string folderPath = "Assets/YandexGame/WorkingData/Editor";

        [MenuItem("_GameData/Delete YandexGame WorkingData Folder")]
        private static void DeleteWorkingDataFolder()
        {
            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
                File.Delete(folderPath + ".meta");
                AssetDatabase.Refresh();
                Debug.Log($"Deleted folder: {folderPath}");
            }
            else
            {
                Debug.LogWarning($"Folder not found: {folderPath}");
            }
        }
    }
}
#endif
