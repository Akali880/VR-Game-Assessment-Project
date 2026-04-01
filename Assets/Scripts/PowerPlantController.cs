using UnityEngine;

public class PowerPlantController : MonoBehaviour
{
    public bool isOn = true;
    public Light statusLight;

    private void Start()
    {
        UpdateVisual();
    }

    public void TurnOff()
    {
        isOn = false;
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        if (statusLight != null)
            statusLight.color = isOn ? Color.red : Color.gray;
    }
}
