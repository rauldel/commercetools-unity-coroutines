# commercetools-unity-coroutines
This repository contains a custom version of the C# commercetools SDK intended to work with Unity engine.

### ⚠ Disclaimer ⚠
This SDK was initially forked from an already deprecated SDK from commercetools and the changes made were made for making it work with Unity engine. 

Therefore, you must be aware that some extra changes may be needed for introducing latest updates from current supported .NET commercetools SDK.

### Constraints
This SDK uses coroutines for the HTTP requests. If the build target of your Unity project supports multithreading, please consider using [the other SDK version I prepared which is based on async/await operators](https://github.com/rauldel/commercetools-unity-async).

## Installation 💻

This manual assumes that you, beloved reader, are used to work with Unity engine, so we won't explain here Unity essentials such as the Unity editor or any other basic configuration stuff.

Moreover, we assume that you have already created a Unity project.

So, let's get to it:

1) First thing to do is clone this repository in its own folder (not the one you used for your Unity project).

2) Once you have a local copy of this repository, simply copy the entire `ctLite` folder in your Unity project. I recommend you to paste it under the `Assets` folder of your Unity project.

3) Once pasting is done, you'll get a ton of errors after Unity engine completed importing all the files from `ctLite` folder.

4) These errors happen because the API compatibility level of your Unity project is not the proper one. In order to make this SDK work, we must aim for `API Compatibility Level = .NET 4.x`

5) Simply open the Project Settings (`Edit > Project Settings`), in the left menu select the `Player` option, and then in the right panel scroll down to the `Other Settings` section. You should see there a dropdown for selecting the `API Compatibility Level`, just select `.NET 4.x` and all errors should disappear.

6) Now you're good to start programming your ecommerce with Unity and commercetools. Give a look to the [Cloud Runner repository](https://github.com/rauldel/machaton_ct_project) for knowing how we implemented a small game that includes commercetools.
