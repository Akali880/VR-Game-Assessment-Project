using UnityEngine;

public class DamController : MonoBehaviour
{
    public bool isOn;
    public Light statusLight;

    private void Start()
    {
        UpdateVisual();
    }

    public void TurnOn()
    {
        isOn = true;
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        if (statusLight != null)
            statusLight.color = isOn ? Color.cyan : Color.gray;
    }
}
