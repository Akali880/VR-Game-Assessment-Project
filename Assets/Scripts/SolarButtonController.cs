using UnityEngine;

public class SolarButtonController : MonoBehaviour
{
    public SolarPanelController solarPanel;

    public void OnPressed()
    {
        if (solarPanel != null)
            solarPanel.PowerOn();
    }
}

