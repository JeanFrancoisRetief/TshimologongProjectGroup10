using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public int healthDisplayValue;
    public TMP_Text healthValueText;

    public GameObject LossScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = 3000;

        LossScreen.SetActive(false);
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

        if(playerHealth <= 0)
        {
            LossScreen.SetActive(true);
            // Unlocks the cursor so it can move freely
            Cursor.lockState = CursorLockMode.None;

            // Makes the cursor visible on the screen
            Cursor.visible = true;
        }
    }
}
