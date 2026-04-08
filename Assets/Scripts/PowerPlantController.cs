using UnityEngine;

public class PowerPlantController : MonoBehaviour
{
    [Header("Button Reference")]
    public PowerPlantButton shutdownButton;

    [Header("Visuals")]
    public GameObject runningVisual;
    public GameObject offVisual;

    [Header("State")]
    public bool plantOff = false;

    private void Start()
    {
        runningVisual.SetActive(true);
        offVisual.SetActive(false);
    }

    private void Update()
    {
        if (!plantOff && shutdownButton.isPressed)
        {
            plantOff = true;
            Debug.Log("Power plant is now OFF!");

            runningVisual.SetActive(false);
            offVisual.SetActive(true);

            GameManager.Instance.CheckTask3Progress();
        }
    }
}
