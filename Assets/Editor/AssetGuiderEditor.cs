/*************************************************************************
 *  Copyright © 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AssetGuiderEditor.cs
 *  Description  :  Capture the event of open Asset in Unity and call OS
 *                  open the Asset use the default application.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  3/7/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEditor;
using UnityEngine;

namespace MGS.AssetGuider
{
    public class AssetGuiderEditor : ScriptableWizard
    {
        [MenuItem("Tool/Guider Editor &G")]
        private static void ShowEditor()
        {
            DisplayWizard<AssetGuiderEditor>("Asset Guider Editor", "Save");
        }

        [SerializeField]
        private string extensions;

        private void OnEnable()
        {
            extensions = EditorPrefs.GetString(AssetGuider.KEY_GUIDER_EXTENSIONS);
            if (string.IsNullOrEmpty(extensions))
            {
                extensions = ".txt$|.shader$";
                UpdateEditorSettings();
            }
        }

        private void OnWizardCreate()
        {
            UpdateEditorSettings();
        }

        private void UpdateEditorSettings()
        {
            EditorPrefs.SetString(AssetGuider.KEY_GUIDER_EXTENSIONS, extensions);
        }
    }
}