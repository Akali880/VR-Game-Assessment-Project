using UnityEngine;

public class PowerPlantController : MonoBehaviour
{
    public GameObject runningVisual;
    public GameObject offVisual;

    [Header("Effects")]
    public ParticleSystem smokeSystem;

    public bool plantOff = false;

    public void ShutDownPlant()
    {
        if (plantOff) return;

        plantOff = true;

        if (runningVisual != null)
            runningVisual.SetActive(false);

        if (offVisual != null)
            offVisual.SetActive(true);

        // Stop smoke when shutting down
        if (smokeSystem != null)
            smokeSystem.Stop();

        GameManager.Instance.CheckTask3Progress();
    }
}
