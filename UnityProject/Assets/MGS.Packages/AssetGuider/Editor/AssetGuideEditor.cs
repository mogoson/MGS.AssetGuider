/*************************************************************************
 *  Copyright © 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AssetGuideEditor.cs
 *  Description  :  Capture the event of open Asset in Unity and call OS
 *                  open the Asset use the default application.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  3/7/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using System.IO;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace MGS.AssetGuider
{
    public class AssetGuideEditor
    {
        #region Field and Property
        private const string SETTINGS_PATH = "Assets/MGS.Packages/AssetGuider/Editor/AssetGuiderSettings.asset";
        #endregion

        #region Private Method
        [MenuItem("Tool/Asset Guider Settings")]
        private static void FocusSettings()
        {
            var settings = AssetDatabase.LoadAssetAtPath(SETTINGS_PATH, typeof(AssetGuiderSettings)) as AssetGuiderSettings;
            if (settings == null)
            {
                settings = ScriptableObject.CreateInstance<AssetGuiderSettings>();
                AssetDatabase.CreateAsset(settings, SETTINGS_PATH);
            }
            Selection.activeObject = settings;
        }

        [OnOpenAsset]
        private static bool OnOpenAsset(int instanceID, int line)
        {
            var settings = AssetDatabase.LoadAssetAtPath(SETTINGS_PATH, typeof(AssetGuiderSettings)) as AssetGuiderSettings;
            if (settings == null)
            {
                return false;
            }

            var assetPath = Application.dataPath + "/" + AssetDatabase.GetAssetPath(instanceID).Replace("Assets", string.Empty);
            if (Regex.IsMatch(Path.GetExtension(assetPath), settings.extensions))
            {
                Application.OpenURL(assetPath);
                return true;
            }
            return false;
        }
        #endregion
    }
}