using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class FossilButton : MonoBehaviour
{
    public bool isPressed = false;

    [Header("Interactable")]
    public XRBaseInteractable interactable;

    [Header("Indicator Light")]
    public Light statusLight;

    private void Start()
    {
        interactable.selectEntered.AddListener(OnButtonPressed);
    }

    private void OnDestroy()
    {
        interactable.selectEntered.RemoveListener(OnButtonPressed);
    }

    private void OnButtonPressed(SelectEnterEventArgs args)
    {
        if (isPressed) return;

        isPressed = true;
        Debug.Log("Shutdown button pressed!");

        if (statusLight != null)
            statusLight.enabled = true;
    }
}
