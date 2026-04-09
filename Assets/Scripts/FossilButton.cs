using UnityEngine;

public class FossilButton : MonoBehaviour
{
    public NonRenewableController nonRenewable;

    public void OnPressed()
    {
        if (nonRenewable != null)
            nonRenewable.TurnOffMachine();
    }
}
