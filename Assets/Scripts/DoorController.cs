using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isLocked = true;
    public Transform openPosition;
    public Transform closedPosition;
    public float openSpeed = 2f;

    private bool _isOpening;

    private void Start()
    {
        // Ensure door starts closed
        if (closedPosition != null)
            transform.position = closedPosition.position;
    }

    private void Update()
    {
        if (_isOpening && openPosition != null)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition.position, Time.deltaTime * openSpeed);
        }
    }

    public void UnlockDoor()
    {
        isLocked = false;
        _isOpening = true;
    }
}
