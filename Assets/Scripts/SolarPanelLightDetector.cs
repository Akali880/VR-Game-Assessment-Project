using UnityEngine;

public class SolarPanelLightDetector : MonoBehaviour
{
    public SolarPanel solarPanel;
    public Transform flashlight; // reference to flashlight transform
    public float maxDistance = 5f;
    public float angleThreshold = 30f;

    private void Update()
    {
        if (flashlight == null || solarPanel == null)
            return;

        Vector3 toPanel = (transform.position - flashlight.position);
        float distance = toPanel.magnitude;

        if (distance > maxDistance)
        {
            solarPanel.SetActive(false);
            return;
        }

        // Check angle between flashlight forward and direction to panel
        float angle = Vector3.Angle(flashlight.forward, toPanel);
        bool isHit = angle < angleThreshold;

        solarPanel.SetActive(isHit);
    }
}
