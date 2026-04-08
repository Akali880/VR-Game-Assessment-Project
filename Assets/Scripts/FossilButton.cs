using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FossilButton : MonoBehaviour
{
    public bool isPressed = false;

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        isPressed = true;
        Debug.Log("Shutdown button pressed!");
    }
}
