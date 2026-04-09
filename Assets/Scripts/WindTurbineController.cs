using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class WindTurbineController : MonoBehaviour
{
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;

    private int bladesAttached = 0;
    private bool taskCompleted = false;

    private void Start()
    {
        socket1.selectEntered.AddListener(OnBladeInserted);
        socket2.selectEntered.AddListener(OnBladeInserted);
        socket3.selectEntered.AddListener(OnBladeInserted);
    }

    private void OnBladeInserted(SelectEnterEventArgs args)
    {
        if (taskCompleted) return;

        bladesAttached++;

        if (bladesAttached >= 3)
        {
            taskCompleted = true;
            GameManager.Instance.CompleteTask2();
        }
    }
}
