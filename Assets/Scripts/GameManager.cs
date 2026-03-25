using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Doors")]
    public GameObject doorRoom2;   // Door from Room 1 to Room 2
    public GameObject doorRoom3;   // Door from Room 2 to Room 3
    public GameObject doorExit;    // Final museum exit door

    [Header("Task States")]
    public bool task1Completed;
    public bool task2Completed;
    public bool task3Completed;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CompleteTask1()
    {
        if (task1Completed) return;
        task1Completed = true;
        Debug.Log("Task 1 completed! Unlocking Room 2.");
        if (doorRoom2 != null)
            doorRoom2.SetActive(false); // Disable door collider/mesh to "open"
    }

    public void CompleteTask2()
    {
        if (task2Completed) return;
        task2Completed = true;
        Debug.Log("Task 2 completed! Unlocking Room 3.");
        if (doorRoom3 != null)
            doorRoom3.SetActive(false);
    }

    public void CompleteTask3()
    {
        if (task3Completed) return;
        task3Completed = true;
        Debug.Log("Task 3 completed! Unlocking Exit.");
        if (doorExit != null)
            doorExit.SetActive(false);
    }
}
