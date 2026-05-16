using TMPro;
using UnityEngine;

public class PlatformerScore : MonoBehaviour
{
    public int score;
    public TMP_Text ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
    }
}
