using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public GameObject StartScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.LossScreen.active)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

        if(StartScreen.active)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                StartScreen.SetActive(false);
            }
        }
    }

    public void OnDeathConfirmRespawnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
