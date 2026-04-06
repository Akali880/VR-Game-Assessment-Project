using UnityEngine;

public class BladePuzzleController : MonoBehaviour
{
    public int totalBlades = 3;
    private int _placedBlades = 0;

    [Header("Windmill")]
    public Transform windmillRotor;
    public float rotationSpeed = 100f;
    private bool _isActive = false;

    [Header("Output Light")]
    public Light poweredLight;

    private void Update()
    {
        if (_isActive && windmillRotor != null)
        {
            windmillRotor.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }

    public void BladePlaced(int index)
    {
        _placedBlades++;

        if (_placedBlades >= totalBlades)
        {
            ActivateWindmill();
        }
    }

    private void ActivateWindmill()
    {
        _isActive = true;

        if (poweredLight != null)
            poweredLight.enabled = true;

        GameManager.Instance.CompleteTask2();
    }
}
