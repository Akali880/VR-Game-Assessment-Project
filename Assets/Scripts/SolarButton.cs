using UnityEngine;

public class SolarButton : MonoBehaviour
{
    public SolarPanelController solarPanel;

    private void OnTriggerEnter(Collider other)
    {
        solarPanel.PowerOn();
    }
}
