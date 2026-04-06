using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class DamController : MonoBehaviour
{
    public bool damOpened = false;

    [Header("Button")]
    public XRBaseInteractable damButton;

    [Header("Power Plant")]
    public PowerPlantController powerPlant;

    private void Start()
    {
        if (damButton != null)
            damButton.selectEntered.AddListener(OnButtonPressed);
    }

    private void OnDestroy()
    {
        if (damButton != null)
            damButton.selectEntered.RemoveListener(OnButtonPressed);
    }

    private void OnButtonPressed(SelectEnterEventArgs args)
    {
        if (damOpened) return;

        damOpened = true;
        Debug.Log("Dam button pressed — dam is now open!");

        if (powerPlant != null)
            powerPlant.CheckActivation();
    }
}
