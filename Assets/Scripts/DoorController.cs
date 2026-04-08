using UnityEngine;

public class DoorController : MonoBehaviour
{
    [Header("Animator Door (Optional)")]
    public Animator doorAnimator;

    [Header("Transform Door (Optional)")]
    public Transform doorTransform;
    public Vector3 openPositionOffset;
    public float openSpeed = 2f;

    private bool isOpen = false;
    private Vector3 closedPosition;
    private Vector3 openPosition;

    private void Start()
    {
        if (doorTransform != null)
        {
            closedPosition = doorTransform.position;
            openPosition = closedPosition + openPositionOffset;
        }
    }

    public void OpenDoor()   // ← MUST be public, void, no parameters
    {
        if (isOpen) return;

        isOpen = true;
        Debug.Log("Door opening: " + gameObject.name);

        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Open");
        }
    }

    private void Update()
    {
        if (isOpen && doorTransform != null)
        {
            doorTransform.position = Vector3.Lerp(
                doorTransform.position,
                openPosition,
                Time.deltaTime * openSpeed
            );
        }
    }
}
