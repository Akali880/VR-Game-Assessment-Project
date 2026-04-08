using UnityEngine;

public class HydroDamController : MonoBehaviour
{
    [Header("Button Reference")]
    public HydroButton hydroButton;

    [Header("Visual")]
    public GameObject waterVisual;

    [Header("State")]
    public bool damActivated = false;

    private void Start()
    {
        if (waterVisual != null)
            waterVisual.SetActive(false);
    }

    private void Update()
    {
        if (!damActivated && hydroButton.isPressed)
        {
            damActivated = true;
            Debug.Log("Hydro dam activated!");

            if (waterVisual != null)
                waterVisual.SetActive(true);

            GameManager.Instance.CheckTask3Progress();
        }
    }
}
