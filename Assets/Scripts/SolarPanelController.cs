using UnityEngine;

public class SolarPanelController : MonoBehaviour
{
    [Header("Flashlight Reference")]
    public Light flashlight;   // Assign the flashlight's Spot Light

    [Header("State")]
    public bool isPowered = false;

    [Header("Visual")]
    public GameObject solarPanelVisual;   // Assign your glowing/indicator visual here

    private void Start()
    {
        // Ensure visual starts OFF
        if (solarPanelVisual != null)
            solarPanelVisual.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (flashlight == null) return;

        // Check if flashlight or its children are inside the trigger
        if (other.gameObject == flashlight.gameObject || other.transform.IsChildOf(flashlight.transform))
        {
            // Flashlight must be ON and bright enough
            if (flashlight.enabled && flashlight.intensity > 0.1f)
            {
                if (!isPowered)
                {
                    isPowered = true;
                    Debug.Log("Solar panel is now powered.");

                    // Turn ON the visual
                    if (solarPanelVisual != null)
                        solarPanelVisual.SetActive(true);

                    // Notify GameManager to check both conditions
                    GameManager.Instance.CheckTask1Progress();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (flashlight == null) return;

        if (other.gameObject == flashlight.gameObject || other.transform.IsChildOf(flashlight.transform))
        {
            if (isPowered)
            {
                isPowered = false;
                Debug.Log("Solar panel lost power.");

                // Turn OFF the visual
                if (solarPanelVisual != null)
                    solarPanelVisual.SetActive(false);
            }
        }
    }
}
