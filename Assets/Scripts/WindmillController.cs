using UnityEngine;

public class WindmillController : MonoBehaviour
{
    public Transform blades;
    public float rotationSpeed = 100f;
    public bool isActive;
    public Light windmillLight;

    private void Update()
    {
        if (isActive && blades != null)
        {
            blades.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }

        if (windmillLight != null)
            windmillLight.enabled = isActive;
    }

    public void SetActive(bool active)
    {
        isActive = active;
    }
}
