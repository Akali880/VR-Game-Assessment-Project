using UnityEngine;

public class DamButtonController : MonoBehaviour
{
    public HydroDamController hydroDam;

    public void OnPressed()
    {
        if (hydroDam != null)
            hydroDam.ActivateDam();
    }
}
