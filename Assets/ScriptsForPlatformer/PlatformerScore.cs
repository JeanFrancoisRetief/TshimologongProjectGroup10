using TMPro;
using UnityEngine;

public class PlatformerScore : MonoBehaviour
{
    public int score;
    public int enemyKillCount;
    public TMP_Text ScoreText;
    public TMP_Text KillText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        enemyKillCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        KillText.text = enemyKillCount.ToString();
    }
}
