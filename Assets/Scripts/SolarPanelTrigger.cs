using UnityEngine;

public class SolarPanelTrigger : MonoBehaviour
{
    [Header("Settings")]
    public string lightObjectTag = "LightObject";
    public float requiredChargeTime = 3f; // seconds

    private float currentChargeTime;
    private bool isCharged;

    private void OnTriggerStay(Collider other)
    {
        if (isCharged) return;

        if (other.CompareTag(lightObjectTag))
        {
            currentChargeTime += Time.deltaTime;

            if (currentChargeTime >= requiredChargeTime)
            {
                isCharged = true;
                Debug.Log("Solar panel fully charged!");
                CheckTaskCompletion();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(lightObjectTag) && !isCharged)
        {
            currentChargeTime = 0f; // reset if light leaves too early
        }
    }

    private void CheckTaskCompletion()
    {
        Task1Controller controller = FindFirstObjectByType<Task1Controller>();
        if (controller != null)
        {
            controller.SolarPanelCharged();
        }
    }
}
