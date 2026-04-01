using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PowerPlantButton : MonoBehaviour
{
    public PowerPlantController powerPlant;

    private XRBaseInteractable _interactable;

    private void Awake()
    {
        _interactable = GetComponent<XRBaseInteractable>();
        _interactable.selectEntered.AddListener(OnPressed);
    }

    private void OnDestroy()
    {
        if (_interactable != null)
            _interactable.selectEntered.RemoveListener(OnPressed);
    }

    private void OnPressed(SelectEnterEventArgs args)
    {
        if (powerPlant != null)
            powerPlant.TurnOff();
    }
}
