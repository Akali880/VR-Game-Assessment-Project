using UnityEngine;

public class NonRenewableController : MonoBehaviour
{
    [Header("Button Reference")]
    public FossilButton shutdownButton;

    [Header("Visuals")]
    public GameObject runningVisual;
    public GameObject offVisual;

    [Header("Machine State")]
    public bool machineOff = false;

    private void Start()
    {
        // Machine starts ON
        runningVisual.SetActive(true);
        offVisual.SetActive(false);
    }

    private void Update()
    {
        if (!machineOff && shutdownButton.isPressed)
        {
            machineOff = true;
            Debug.Log("Machine is now OFF!");

            // Switch visuals
            runningVisual.SetActive(false);
            offVisual.SetActive(true);

            // Notify GameManager to check both conditions
            GameManager.Instance.CheckTask1Progress();
        }
    }
}

