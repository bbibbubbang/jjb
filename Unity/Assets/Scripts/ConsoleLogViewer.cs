using UnityEngine;
using UnityEngine.UI;
using System.Text;

// Shows a popup with console logs and allows copying them to the clipboard.
public class ConsoleLogViewer : MonoBehaviour
{
    [SerializeField] private Button openButton;
    [SerializeField] private GameObject logPanel;
    [SerializeField] private Text logText;
    [SerializeField] private Button copyButton;

    private StringBuilder logBuffer = new StringBuilder();

    void Awake()
    {
        logPanel.SetActive(false);
        openButton.onClick.AddListener(TogglePanel);
        copyButton.onClick.AddListener(CopyLogs);
        Application.logMessageReceived += HandleLog;
    }

    void OnDestroy()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        logBuffer.AppendLine(logString);
        if (type == LogType.Error || type == LogType.Exception)
        {
            logBuffer.AppendLine(stackTrace);
        }
    }

    void TogglePanel()
    {
        logPanel.SetActive(!logPanel.activeSelf);
        logText.text = logBuffer.ToString();
    }

    void CopyLogs()
    {
        GUIUtility.systemCopyBuffer = logBuffer.ToString();
    }
}
