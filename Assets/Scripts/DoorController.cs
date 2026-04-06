using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isOpen = false;
    public Vector3 openOffset = new Vector3(0, 0, -2f);
    public float openSpeed = 2f;

    private Vector3 _closedPosition;
    private Vector3 _targetPosition;

    private void Start()
    {
        _closedPosition = transform.position;
        _targetPosition = _closedPosition;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _targetPosition, Time.deltaTime * openSpeed);
    }

    public void OpenDoor()
    {
        if (isOpen) return;

        isOpen = true;
        _targetPosition = _closedPosition + openOffset;
    }
}
