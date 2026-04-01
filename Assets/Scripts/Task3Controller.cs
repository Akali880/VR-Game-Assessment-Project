using UnityEngine;

public class Task3Controller : MonoBehaviour
{
    public DamController dam;
    public PowerPlantController powerPlant;

    private bool _completed;

    private void Update()
    {
        if (_completed) return;
        if (dam == null || powerPlant == null) return;

        if (dam.isOn && !powerPlant.isOn)
        {
            _completed = true;
            GameManager.Instance.CompleteTask3();
        }
    }
}
