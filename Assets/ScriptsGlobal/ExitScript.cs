using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public GameObject ExitPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ExitPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ExitPanel.active)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                ExitPanel.SetActive(false);
            }


            if(Input.GetKeyDown(KeyCode.Return))
            {
                Application.Quit();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitPanel.SetActive(true);
            }
        }


    }
}
