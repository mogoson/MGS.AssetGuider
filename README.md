[TOC]

# MGS.AssetGuider

## Summary
- Unity Asset guider.

## Ability
- Config a guider to open Unity Asset use the OS default application.

## Install

- Unity --> Window --> Package Manager --> "+" --> Add package from git URL...

  ```text
  https://github.com/mogoson/MGS.AssetGuider.git?path=/Assets
  ```

## Prerequisite
- Unity provide the API(OnOpenAsset callback attribute) to capture the event of open Asset.

## Scheme
- Use Unity EditorPrefs to record the extensions of Assets those we want to open them use our designated applications.
- Write extend editor code, capture the event of open Asset in Unity by OnOpenAsset callback attribute and get the extension of current Asset.
- Check the extension, if it was record in the config file, Use the OS default application to open it. if not, we do not handle it but Unity do.
- Set the default application of Asset by type(extension) in OS. example set "Sublime Text" as the default editor of Shader Asset.

## Usage
1. Click the menu item "Tool/Guider Editor" in Unity editor menu bar to open the Asset Guider Editor.

1. Config the "Extensions" in the Asset Guider Editor.

1. Set the default application of Asset by type(extension) in OS. example set "Sublime Text" as the default editor of Shader Asset.

1. AssetGuider will be work when the Asset(it's extension config in the the Asset Guider Editor, example Shader) will be opened.

---

Copyright © 2025 Mogoson.	mogoson@outlook.com
