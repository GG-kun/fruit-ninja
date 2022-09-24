using UnityEngine;

public class ScoreboardUI : MonoBehaviour
{
    [Header("UI")]
    [Tooltip("Scoreboard row UI prefab")]
    [SerializeField]
    private GameObject rowPrefab;

    // Start is called before the first frame update
    void Start()
    {
        foreach (int score in Scoreboard.GetScoreboard())
        {
            ScoreboardRowUI row = Instantiate(rowPrefab, transform).GetComponent<ScoreboardRowUI>();
            row.SetScore(score.ToString());
        }
    }
}
