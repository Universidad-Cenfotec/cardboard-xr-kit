using UnityEngine;

public class DebugGraphicsAPI : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 900, 40),
            "Graphics API: " + SystemInfo.graphicsDeviceType);

        GUI.Label(new Rect(10, 40, 900, 40),
            "Stereo: " + (XRSettingsEnabled() ? "XR ON" : "XR OFF"));
    }

    bool XRSettingsEnabled()
    {
#if UNITY_2019_3_OR_NEWER
        return UnityEngine.XR.Management.XRGeneralSettings.Instance != null &&
               UnityEngine.XR.Management.XRGeneralSettings.Instance.Manager != null &&
               UnityEngine.XR.Management.XRGeneralSettings.Instance.Manager.isInitializationComplete;
#else
        return false;
#endif
    }
}
