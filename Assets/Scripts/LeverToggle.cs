using UnityEngine;

public class LeverToggle : MonoBehaviour
{
    public enum LeverType { Dam, PowerPlant }

    public LeverType leverType;

    [Header("Visuals")]
    public Renderer indicatorRenderer;
    public Color offColor = Color.red;
    public Color onColor = Color.green;

    private bool isOn;

    private void Start()
    {
        UpdateVisual();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Again, simple: any touch toggles
        Toggle();
    }

    private void Toggle()
    {
        isOn = !isOn;
        UpdateVisual();

        Task3Controller controller = FindFirstObjectByType<Task3Controller>();
        if (controller != null)
        {
            if (leverType == LeverType.Dam)
            {
                controller.SetDamOn(isOn);
            }
            else if (leverType == LeverType.PowerPlant)
            {
                controller.SetPowerPlantOn(isOn);
            }
        }

        Debug.Log(leverType + " lever is now " + (isOn ? "ON" : "OFF"));
    }

    private void UpdateVisual()
    {
        if (indicatorRenderer != null)
        {
            indicatorRenderer.material.color = isOn ? onColor : offColor;
        }
    }
}
