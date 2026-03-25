using UnityEngine;

public class WinMessage : MonoBehaviour
{
    public GameObject messageObject;

    private void Start()
    {
        if (messageObject != null)
            messageObject.SetActive(false);
    }

    private void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.task3Completed)
        {
            if (messageObject != null && !messageObject.activeSelf)
            {
                messageObject.SetActive(true);
            }
        }
    }
}
