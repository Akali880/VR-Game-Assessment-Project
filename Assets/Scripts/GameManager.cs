using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // -------------------------
    // TASK STATES
    // -------------------------
    [Header("Task States")]
    public bool task1Completed;
    public bool task2Completed;
    public bool task3Completed;

    // -------------------------
    // ROOM 1 CONTROLLERS
    // -------------------------
    [Header("Room 1 Controllers")]
    public SolarPanelController solarPanel;
    public NonRenewableController nonRenewable;

    // -------------------------
    // ROOM 2 CONTROLLERS
    // -------------------------
    [Header("Room 2 Controllers")]
    public WindTurbineController windTurbine;

    // -------------------------
    // ROOM 3 CONTROLLERS
    // -------------------------
    [Header("Room 3 Controllers")]
    public PowerPlantController powerPlant;
    public HydroDamController hydroDam;

    // -------------------------
    // DOORS
    // -------------------------
    [Header("Doors")]
    public DoorController doorToRoom2;
    public DoorController doorToRoom3;
    public DoorController exitDoor;

    // -------------------------
    // SINGLETON SETUP
    // -------------------------
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    // ============================================================
    // ROOM 1 LOGIC (Solar Panel + Fossil Machine)
    // ============================================================
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

    // ============================================================
    // ROOM 2 LOGIC (Wind Turbine Assembly)
    // ============================================================
    public void CompleteTask2()
    {
        if (task2Completed) return;

        task2Completed = true;
        Debug.Log("Task 2 Completed!");

        if (doorToRoom3 != null)
            doorToRoom3.OpenDoor();
    }

    // ============================================================
    // ROOM 3 LOGIC (Power Plant Shutdown + Hydro Dam Activation)
    // ============================================================
    public void CheckTask3Progress()
    {
        if (task3Completed) return;

        if (powerPlant != null && hydroDam != null)
        {
            if (powerPlant.plantOff && hydroDam.damActivated)
            {
                CompleteTask3();
            }
        }
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
