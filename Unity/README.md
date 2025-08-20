# Unity WebView Build

This folder contains a minimal Unity project setup for running the existing web game inside a WebView.

## Prerequisites
- Unity 2021.3 or compatible version.
- [unity-webview](https://github.com/gree/unity-webview) plugin imported into the project.

## Usage
1. Open this `Unity` folder as a Unity project.
2. Import the `unity-webview` plugin.
3. Create a new scene and add an empty `GameObject`.
4. Attach the `WebGameLoader` script to the `GameObject`.
5. Build the project for your target platform (e.g., WebGL or mobile). The script loads `index.html` from `StreamingAssets` into a WebView.

The original `index.html` game is bundled under `Assets/StreamingAssets` and will be displayed within the WebView when the scene runs.
