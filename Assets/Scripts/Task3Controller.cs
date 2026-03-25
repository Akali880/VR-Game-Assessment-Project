using UnityEngine;

public class Task3Controller : MonoBehaviour
{
    private bool damOn;
    private bool powerPlantOn;

    public void SetDamOn(bool on)
    {
        damOn = on;
        Debug.Log("Task3: Dam is " + (on ? "ON" : "OFF"));
        CheckCompletion();
    }

    public void SetPowerPlantOn(bool on)
    {
        powerPlantOn = on;
        Debug.Log("Task3: Power plant is " + (on ? "ON" : "OFF"));
        CheckCompletion();
    }

    private void CheckCompletion()
    {
        // Condition: dam ON, power plant OFF
        if (damOn && !powerPlantOn)
        {
            Debug.Log("Task 3 complete! Unlocking exit.");
            GameManager.Instance.CompleteTask3();
        }
    }
}
