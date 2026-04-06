using UnityEngine;

public class PowerPlantController : MonoBehaviour
{
    public bool isPowered = false;

    [Header("Indicator Light")]
    public Light indicatorLight;

    [Header("Dam Reference")]
    public DamController damController;

    public void CheckActivation()
    {
        if (isPowered) return;

        if (damController != null && damController.damOpened)
        {
            ActivatePlant();
        }
    }

    private void ActivatePlant()
    {
        isPowered = true;
        Debug.Log("Power plant activated!");

        if (indicatorLight != null)
            indicatorLight.enabled = true;

        GameManager.Instance.CompleteTask3();
    }
}
