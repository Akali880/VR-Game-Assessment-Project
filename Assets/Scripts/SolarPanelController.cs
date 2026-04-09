using UnityEngine;

public class SolarPanelController : MonoBehaviour
{
    public GameObject solarPanelVisual;
    [HideInInspector] public bool isPowered = false;

    public void PowerOn()
    {
        isPowered = true;
        if (solarPanelVisual != null)
            solarPanelVisual.SetActive(true);

        GameManager.Instance.CheckTask1Progress();
    }
}
