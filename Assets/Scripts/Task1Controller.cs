using UnityEngine;

public class Task1Controller : MonoBehaviour
{
    private bool solarCharged;
    private bool nonRenewableOff;

    public void SolarPanelCharged()
    {
        solarCharged = true;
        Debug.Log("Task1: Solar panel condition met.");
        CheckCompletion();
    }

    public void NonRenewableTurnedOff(bool isOff)
    {
        nonRenewableOff = isOff;
        Debug.Log("Task1: Non-renewable is off = " + isOff);
        CheckCompletion();
    }

    private void CheckCompletion()
    {
        if (solarCharged && nonRenewableOff)
        {
            Debug.Log("Task 1 complete! Unlocking next room.");
            GameManager.Instance.CompleteTask1();
        }
    }
}
