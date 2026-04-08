using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class WindTurbineController : MonoBehaviour
{
    [Header("Blade Sockets")]
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;

    [Header("State")]
    public bool task2Complete = false;

    private void Update()
    {
        if (task2Complete) return;

        bool blade1Inserted = socket1.hasSelection;
        bool blade2Inserted = socket2.hasSelection;
        bool blade3Inserted = socket3.hasSelection;

        if (blade1Inserted && blade2Inserted && blade3Inserted)
        {
            task2Complete = true;
            Debug.Log("Wind turbine fully assembled!");

            GameManager.Instance.CompleteTask2();
        }
    }
}
