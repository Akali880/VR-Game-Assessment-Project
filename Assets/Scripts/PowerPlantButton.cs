using UnityEngine;

public class PowerPlantButton : MonoBehaviour
{
    public bool isPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        isPressed = true;
        Debug.Log("Power plant shutdown button pressed!");
    }
}
