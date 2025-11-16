/*************************************************************************
 *  Copyright © 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AssetGuider.cs
 *  Description  :  null.
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

namespace MGS.AssetGuider.Editors
{
    public class AssetGuider
    {
        public const string KEY_GUIDER_EXTENSIONS = "KEY_GUIDER_EXTENSIONS";

        [OnOpenAsset]
        private static bool OnOpenAsset(int instanceID, int line)
        {
            var extensions = EditorPrefs.GetString(KEY_GUIDER_EXTENSIONS);
            var assetPath = AssetDatabase.GetAssetPath(instanceID);
            var filePath = $"{Application.dataPath}/{assetPath.Replace("Assets", string.Empty)}";
            if (Regex.IsMatch(Path.GetExtension(filePath), extensions))
            {
                Application.OpenURL(filePath);
                return true;
            }
            return false;
        }
    }
}