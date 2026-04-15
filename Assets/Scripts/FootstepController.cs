using UnityEngine;

public class FootstepController : MonoBehaviour
{
    [Header("References")]
    public AudioSource footstepSource;
    public Transform playerRoot;   // The object that ACTUALLY moves (CharacterController recommended)

    [Header("Footstep Clips")]
    public AudioClip[] footstepClips;

    [Header("Settings")]
    public float minSpeed = 0.05f;      // Movement threshold
    public float stepInterval = 0.45f;  // Time between steps
    public float rotationIgnoreThreshold = 0.001f; // Ignore micro movement from rotation

    private Vector3 lastPosition;
    private float stepTimer;

    private void Start()
    {
        if (playerRoot == null)
            playerRoot = transform;

        lastPosition = playerRoot.position;
    }

    private void Update()
    {
        Vector3 currentPos = playerRoot.position;
        Vector3 delta = currentPos - lastPosition;

        // Ignore vertical movement
        delta.y = 0f;

        // Ignore tiny micro-movements caused by rotation
        if (delta.sqrMagnitude < rotationIgnoreThreshold)
        {
            lastPosition = currentPos;
            return;
        }

        float speed = delta.magnitude / Time.deltaTime;
        lastPosition = currentPos;

        bool isMoving = speed > minSpeed;

        if (isMoving)
        {
            stepTimer -= Time.deltaTime;

            if (stepTimer <= 0f)
            {
                PlayFootstep();
                stepTimer = stepInterval; // Prevent double-steps
            }
        }
        else
        {
            // Reset timer so steps don't fire instantly when starting again
            stepTimer = stepInterval;
        }
    }

    private void PlayFootstep()
    {
        if (footstepClips.Length == 0 || footstepSource == null)
            return;

        AudioClip clip = footstepClips[Random.Range(0, footstepClips.Length)];
        footstepSource.PlayOneShot(clip);
    }
}
