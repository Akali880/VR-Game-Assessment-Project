using UnityEngine;

public class PowerPlantButtonController : MonoBehaviour
{
    public PowerPlantController powerPlant;

    public void OnPressed()
    {
        if (powerPlant != null)
            powerPlant.ShutDownPlant();
    }
}
