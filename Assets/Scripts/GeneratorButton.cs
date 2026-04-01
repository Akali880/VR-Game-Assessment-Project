using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GeneratorButton : MonoBehaviour
{
    public NonRenewableGenerator generator;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable _interactable;

    private void Awake()
    {
        _interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        _interactable.selectEntered.AddListener(OnPressed);
    }

    private void OnDestroy()
    {
        if (_interactable != null)
            _interactable.selectEntered.RemoveListener(OnPressed);
    }

    private void OnPressed(SelectEnterEventArgs args)
    {
        if (generator != null)
            generator.TurnOff();
    }
}
