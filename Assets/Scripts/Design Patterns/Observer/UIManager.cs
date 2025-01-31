using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;

    private void OnEnable()
    {
        scoreManager.onScoreChanged.AddListener(UpdateScoreUI);
    }

    private void OnDisable()
    {
        scoreManager.onScoreChanged.RemoveListener(UpdateScoreUI);
    }

    private void UpdateScoreUI(int score)
    {
        Debug.Log($"Skor Güncellendi: {score}");
    }
}
