using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public UnityEvent<int> onScoreChanged; // Skor deðiþtiðinde bildirim gönderir

    private int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        onScoreChanged?.Invoke(score); // Observer'lara bildir
    }
}