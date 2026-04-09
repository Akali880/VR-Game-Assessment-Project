using UnityEngine;

public class PowerPlantController : MonoBehaviour
{
    public GameObject runningVisual;
    public GameObject offVisual;
    public bool plantOff = false;

    public void ShutDownPlant()
    {
        if (plantOff) return;

        plantOff = true;

        if (runningVisual != null)
            runningVisual.SetActive(false);

        if (offVisual != null)
            offVisual.SetActive(true);

        GameManager.Instance.CheckTask3Progress();
    }
}
