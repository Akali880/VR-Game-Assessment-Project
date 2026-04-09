using UnityEngine;

public class HydroDamController : MonoBehaviour
{
    public GameObject damInactiveVisual;
    public GameObject damActiveVisual;
    public bool damActivated = false;

    public void ActivateDam()
    {
        if (damActivated) return;

        damActivated = true;

        if (damInactiveVisual != null)
            damInactiveVisual.SetActive(false);

        if (damActiveVisual != null)
            damActiveVisual.SetActive(true);

        GameManager.Instance.CheckTask3Progress();
    }
}
