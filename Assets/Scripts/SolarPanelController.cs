using UnityEngine;

public class SolarPanelController : MonoBehaviour
{
    [Header("Flashlight Reference")]
    public Light flashlight;

    [Header("State")]
    public bool isPowered = false;

    [Header("Visual")]
    public GameObject solarPanelVisual;

    private void Start()
    {
        if (solarPanelVisual != null)
            solarPanelVisual.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (flashlight == null) return;

        // Check if flashlight or its children are inside the trigger
        if (other.gameObject == flashlight.gameObject || other.transform.IsChildOf(flashlight.transform))
        {
            if (flashlight.enabled && flashlight.intensity > 0.1f)
            {
                if (!isPowered)
                {
                    isPowered = true;
                    Debug.Log("Solar panel is now powered.");

                    if (solarPanelVisual != null)
                        solarPanelVisual.SetActive(true);

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

                if (solarPanelVisual != null)
                    solarPanelVisual.SetActive(false);
            }
        }
    }
}
