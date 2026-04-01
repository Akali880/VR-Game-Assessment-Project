using UnityEngine;

public class SolarPanel : MonoBehaviour
{
    public bool isActive;
    public Light indicatorLight; // small light to show it's active

    private void Start()
    {
        UpdateVisual();
    }

    public void SetActive(bool active)
    {
        isActive = active;
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        if (indicatorLight != null)
            indicatorLight.color = isActive ? Color.green : Color.red;
    }
}
