using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Task States")]
    public bool task1Completed;
    public bool task2Completed;
    public bool task3Completed;

    [Header("Puzzle Controllers")]
    public SolarPanelController solarPanel;
    public NonRenewableController nonRenewable;

    [Header("Doors")]
    public DoorController doorToRoom2;
    public DoorController doorToRoom3;
    public DoorController exitDoor;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    // NEW: Only completes Task 1 when BOTH conditions are true
    public void CheckTask1Progress()
    {
        if (task1Completed) return;

        if (solarPanel != null && nonRenewable != null)
        {
            if (solarPanel.isPowered && nonRenewable.machineOff)
            {
                CompleteTask1();
            }
        }
    }

    public void CompleteTask1()
    {
        if (task1Completed) return;

        task1Completed = true;
        Debug.Log("Task 1 Completed!");

        if (doorToRoom2 != null)
            doorToRoom2.OpenDoor();
    }

    public void CompleteTask2()
    {
        if (task2Completed) return;

        task2Completed = true;
        Debug.Log("Task 2 Completed!");

        if (doorToRoom3 != null)
            doorToRoom3.OpenDoor();
    }

    public void CompleteTask3()
    {
        if (task3Completed) return;

        task3Completed = true;
        Debug.Log("Task 3 Completed!");

        if (exitDoor != null)
            exitDoor.OpenDoor();
    }
}
