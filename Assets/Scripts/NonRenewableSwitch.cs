using UnityEngine;

public class NonRenewableSwitch : MonoBehaviour
{
    [Header("Visuals")]
    public Renderer indicatorRenderer;
    public Color onColor = Color.red;
    public Color offColor = Color.green;

    private bool isOff;

    private void Start()
    {
        UpdateVisual();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Simple: if any controller or object touches it, toggle
        // You can refine by checking tags like "Hand" or "Controller"
        ToggleSwitch();
    }

    private void ToggleSwitch()
    {
        isOff = !isOff;
        Debug.Log("Non-renewable source is now " + (isOff ? "OFF" : "ON"));
        UpdateVisual();

        Task1Controller controller = FindFirstObjectByType<Task1Controller>();
        if (controller != null)
        {
            controller.NonRenewableTurnedOff(isOff);
        }
    }

    private void UpdateVisual()
    {
        if (indicatorRenderer != null)
        {
            indicatorRenderer.material.color = isOff ? offColor : onColor;
        }
    }
}
