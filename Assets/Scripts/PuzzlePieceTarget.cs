using UnityEngine;

public class PuzzlePieceTarget : MonoBehaviour
{
    public string requiredPieceName;
    public bool isCorrect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == requiredPieceName)
        {
            isCorrect = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == requiredPieceName)
        {
            isCorrect = false;
        }
    }
}
