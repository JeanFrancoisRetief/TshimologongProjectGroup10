using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public int healthDisplayValue;
    public TMP_Text healthValueText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = 3000;
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplayValue = Mathf.FloorToInt(playerHealth / 30);
        healthValueText.text = healthDisplayValue.ToString();

        if (playerHealth > 3000)
        {
            playerHealth = 3000;
        }
    }
}
