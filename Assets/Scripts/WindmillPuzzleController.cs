using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class WindmillPuzzleController : MonoBehaviour
{
    [Header("Sockets")]
    public XRSocketInteractor[] gearSockets;

    [Header("Windmill")]
    public WindmillController windmillController;

    private bool puzzleCompleted;

    private void Update()
    {
        if (puzzleCompleted) return;

        if (AllSocketsFilled())
        {
            puzzleCompleted = true;
            Debug.Log("Windmill puzzle complete!");

            if (windmillController != null)
                windmillController.SetPowered(true);

            GameManager.Instance.CompleteTask2();
        }
    }

    private bool AllSocketsFilled()
    {
        foreach (var socket in gearSockets)
        {
            if (socket == null)
                return false;

            // NEW XRIT API — check if anything is selected
            if (socket.interactablesSelected.Count == 0)
                return false;
        }

        return true;
    }
}
