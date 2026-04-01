using UnityEngine;

public class Task1Controller : MonoBehaviour
{
    public SolarPanel solarPanel;
    public NonRenewableGenerator generator;

    private bool _completed;

    private void Update()
    {
        if (_completed) return;
        if (solarPanel == null || generator == null) return;

        if (solarPanel.isActive && !generator.isOn)
        {
            _completed = true;
            GameManager.Instance.CompleteTask1();
        }
    }
}
