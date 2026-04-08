using UnityEngine;

public class HydroButton : MonoBehaviour
{
    public bool isPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        isPressed = true;
        Debug.Log("Hydro button pressed!");
    }
}
