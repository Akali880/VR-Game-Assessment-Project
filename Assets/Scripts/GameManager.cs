using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Puzzle States")]
    public bool task1Completed;
    public bool task2Completed;
    public bool task3Completed;

    [Header("Doors")]
    public DoorController room2Door;
    public DoorController room3Door;
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

    public void CompleteTask1()
    {
        if (task1Completed) return;
        task1Completed = true;
        Debug.Log("Task 1 completed!");
        if (room2Door != null)
            room2Door.UnlockDoor();
    }

    public void CompleteTask2()
    {
        if (task2Completed) return;
        task2Completed = true;
        Debug.Log("Task 2 completed!");
        if (room3Door != null)
            room3Door.UnlockDoor();
    }

    public void CompleteTask3()
    {
        if (task3Completed) return;
        task3Completed = true;
        Debug.Log("Task 3 completed!");
        if (exitDoor != null)
            exitDoor.UnlockDoor();
    }
}
