using UnityEngine;
using System.IO;

// Loads the bundled index.html into a WebView object.
// Requires the unity-webview plugin (https://github.com/gree/unity-webview).
public class WebGameLoader : MonoBehaviour
{
    void Start()
    {
        var webViewObject = new GameObject("WebViewObject").AddComponent<WebViewObject>();
        webViewObject.Init();
        string localPath = Path.Combine(Application.streamingAssetsPath, "index.html");
        webViewObject.LoadURL("file://" + localPath);
        webViewObject.SetVisibility(true);
    }
}
