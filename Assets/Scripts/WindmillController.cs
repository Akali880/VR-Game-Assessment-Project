using UnityEngine;

public class WindmillController : MonoBehaviour
{
    public Transform blades;
    public float rotationSpeed = 100f;
    public Light poweredLight;

    private bool isPowered;

    private void Update()
    {
        if (isPowered && blades != null)
        {
            blades.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }

    public void SetPowered(bool powered)
    {
        isPowered = powered;
        if (poweredLight != null)
        {
            poweredLight.enabled = powered;
        }
    }
}
