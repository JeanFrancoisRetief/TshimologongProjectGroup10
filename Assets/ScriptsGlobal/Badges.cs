using UnityEngine;

public class Badges : MonoBehaviour
{
    public GameObject BadgesPanel;
    private bool isPanelActive;
    public Score scoreScript;

    [Header("Recycle")]
    public GameObject BadgeCover001;
    public GameObject BadgeCover002;
    public GameObject BadgeCover003;

    [Header("Archeology")]
    public GameObject BadgeCover004;
    public GameObject BadgeCover005;
    public GameObject BadgeCover006;

    [Header("Stress Manager")]
    public GameObject BadgeCover007;
    public GameObject BadgeCover008;
    public GameObject BadgeCover009;

    [Header("Electricity")]
    public GameObject BadgeCover010;
    public GameObject BadgeCover011;
    public GameObject BadgeCover012;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BadgesPanel.SetActive(false);
        isPanelActive = false;

        // 1. Disable VSync (required for targetFrameRate to work on most platforms)
        QualitySettings.vSyncCount = 0;

        // 2. Set the desired frame rate
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(isPanelActive)
            {
                BadgesPanel.SetActive(false);
                isPanelActive = false;
            }
            else
            {
                BadgesPanel.SetActive(true);
                isPanelActive = true;
            }
        }


        //Recycling Game
        if(scoreScript.scoreValue != 0)
        {
            BadgeCover001.SetActive(false);
        }

        if(scoreScript.scoreValue == 30)
        {
            BadgeCover002.SetActive(false);
        }

        if (scoreScript.scoreValue == -10)
        {
            BadgeCover003.SetActive(false);
        }


    }
}
