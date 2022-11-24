# MGS.AssetGuider

## Summary
- Unity Asset guider.

## Environment
- Unity 5.0 or above.
- .Net Framework 3.5 or above.

## Demand
- Config a guider to open Unity Asset use the OS default application.

## Prerequisite
- Unity provide the API(OnOpenAsset callback attribute) to capture the event of open Asset.

## Scheme
- Use a config file to record the extensions of Assets those we want to open them use our designated applications.
- Write extend editor code, capture the event of open Asset in Unity by OnOpenAsset callback attribute and get the extension of current Asset.
- Check the extension, if it was record in the config file, Use the OS default application to open it. if not, we do not handle it but Unity do.
- Set the default application of Asset by type(extension) in OS. example set "Sublime Text" as the default editor of Shader Asset.

## Usage
1. Find the menu item "Tool/Asset Guider/Settings" in Unity editor menu bar and click it to create(if none)and focus the AssetGuiderSettings.

1. Config the "Extensions" of AssetGuiderSettings in Unity Inspector.

1. Set the default application of Asset by type(extension) in OS. example set "Sublime Text" as the default editor of Shader Asset.

1. AssetGuider will be work when the Asset(it's extension config in the AssetGuiderSettings, example Shader) will be opened.

------
Copyright © 2021 Mogoson.	mogoson@outlook.com