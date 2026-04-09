using UnityEngine;

public class NonRenewableController : MonoBehaviour
{
    public GameObject runningVisual;
    public GameObject offVisual;
    [HideInInspector] public bool isOff = false;

    public void TurnOffMachine()
    {
        isOff = true;

        if (runningVisual != null)
            runningVisual.SetActive(false);

        if (offVisual != null)
            offVisual.SetActive(true);

        GameManager.Instance.CheckTask1Progress();
    }
}
