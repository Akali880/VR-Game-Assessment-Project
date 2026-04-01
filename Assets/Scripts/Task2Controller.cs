using UnityEngine;

public class Task2Controller : MonoBehaviour
{
    public PuzzlePieceTarget[] targets;
    public WindmillController windmill;

    private bool _completed;

    private void Update()
    {
        if (_completed) return;
        if (targets == null || targets.Length == 0 || windmill == null) return;

        bool allCorrect = true;
        foreach (var t in targets)
        {
            if (!t.isCorrect)
            {
                allCorrect = false;
                break;
            }
        }

        if (allCorrect)
        {
            _completed = true;
            windmill.SetActive(true);
            GameManager.Instance.CompleteTask2();
        }
    }
}
