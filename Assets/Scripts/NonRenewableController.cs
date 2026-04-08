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
        runningVisual.SetActive(true);
        offVisual.SetActive(false);
    }

    private void Update()
    {
        if (!machineOff && shutdownButton.isPressed)
        {
            machineOff = true;
            Debug.Log("Machine is now OFF!");

            runningVisual.SetActive(false);
            offVisual.SetActive(true);

            GameManager.Instance.CheckTask1Progress();
        }
    }
}
