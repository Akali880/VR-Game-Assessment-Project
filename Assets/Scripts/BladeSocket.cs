using UnityEngine;

public class BladeSocket : MonoBehaviour
{
    public Transform targetPosition;
    public float snapDistance = 0.2f;
    public BladePuzzleController puzzleController;
    public int bladeIndex;

    private bool _isFilled = false;

    private void OnTriggerStay(Collider other)
    {
        if (_isFilled) return;

        BladePiece blade = other.GetComponent<BladePiece>();
        if (blade != null && blade.bladeIndex == bladeIndex)
        {
            float distance = Vector3.Distance(other.transform.position, targetPosition.position);
            if (distance <= snapDistance)
            {
                SnapBlade(other.transform);
                _isFilled = true;
                puzzleController.BladePlaced(bladeIndex);
            }
        }
    }

    private void SnapBlade(Transform bladeTransform)
    {
        bladeTransform.position = targetPosition.position;
        bladeTransform.rotation = targetPosition.rotation;

        Rigidbody rb = bladeTransform.GetComponent<Rigidbody>();
        if (rb != null)
            rb.isKinematic = true;
    }
}
