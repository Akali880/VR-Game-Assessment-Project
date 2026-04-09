using UnityEngine;

public class SolarButtonController : MonoBehaviour
{
    public SolarPanelController solarPanel;

    // This will be called by XR Simple Interactable
    public void OnPressed()
    {
        if (solarPanel != null)
            solarPanel.PowerOn();
    }
}
