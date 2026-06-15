using TMPro;
using UnityEngine;

public class Badges : MonoBehaviour
{
    public GameObject BadgesPanel;
    private bool isPanelActive;
    public Score scoreScript;

    public PlatformerScore platformerScoreScript;
    public GameObject player;

    public Artifacts artifactsScript;

    public StressManagerMainScript stressManagerMainScript;

    public GameObject WinPanel;

    public int badgeCount;
    public TMP_Text BadgeCountText;
    public GameObject notifcationIcon;
    private int badge001Count;
    private int badge002Count;
    private int badge003Count;
    private int badge004Count;
    private int badge005Count;
    private int badge006Count;
    private int badge007Count;
    private int badge008Count;
    private int badge009Count;
    private int badge010Count;
    private int badge011Count;
    private int badge012Count;
    private bool checkedBadge;

    [Header("Recycle")]
    public GameObject BadgeCover001;
    public GameObject BadgeCover002;
    public GameObject BadgeCover003;
    private bool gotBadge001;
    private bool gotBadge002;
    private bool gotBadge003;

    [Header("Archeology")]
    public GameObject BadgeCover004;
    public GameObject BadgeCover005;
    public GameObject BadgeCover006;
    private bool gotBadge004;
    private bool gotBadge005;
    private bool gotBadge006;

    [Header("Stress Manager")]
    public GameObject BadgeCover007;
    public GameObject BadgeCover008;
    public GameObject BadgeCover009;
    private bool gotBadge007;
    private bool gotBadge008;
    private bool gotBadge009;

    [Header("Electricity")]
    public GameObject BadgeCover010;
    public GameObject BadgeCover011;
    public GameObject BadgeCover012;
    private bool gotBadge010;
    private bool gotBadge011;
    private bool gotBadge012;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notifcationIcon.SetActive(false);
        BadgesPanel.SetActive(false);
        isPanelActive = false;

        // 1. Disable VSync (required for targetFrameRate to work on most platforms)
        QualitySettings.vSyncCount = 0;

        // 2. Set the desired frame rate
        Application.targetFrameRate = 30;

        WinPanel.SetActive(false);

        gotBadge001 = false;
        gotBadge002 = false;
        gotBadge003 = false;

        gotBadge004 = false;
        gotBadge005 = false;
        gotBadge006 = false;

        gotBadge007 = false;
        gotBadge008 = false;
        gotBadge009 = false;

        gotBadge010 = false;
        gotBadge011 = false;
        gotBadge012 = false;

        
        badge001Count = 0;
        badge002Count = 0;
        badge003Count = 0;
        badge004Count = 0;
        badge005Count = 0;
        badge006Count = 0;
        badge007Count = 0;
        badge008Count = 0;
        badge009Count = 0;
        badge010Count = 0;
        badge011Count = 0;
        badge012Count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        badgeCount = badge001Count + badge002Count + badge003Count + badge004Count+ badge005Count + badge006Count + badge007Count
            + badge008Count + badge009Count + badge010Count + badge011Count + badge012Count;
        BadgeCountText.text = badgeCount.ToString() + "/12";

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(isPanelActive)
            {
                BadgesPanel.SetActive(false);
                isPanelActive = false;
                notifcationIcon.SetActive(false);
            }
            else
            {
                BadgesPanel.SetActive(true);
                isPanelActive = true;
                notifcationIcon.SetActive(false);
            }
        }


        //Recycling Game
        if(scoreScript.scoreValue != 0)
        {
            BadgeCover001.SetActive(false);
            gotBadge001 = true;
            badge001Count = 1;

        }

        if(scoreScript.scoreValue == 30)
        {
            BadgeCover002.SetActive(false);
            gotBadge002 = true;
            badge002Count = 1;
        }

        if (scoreScript.scoreValue == -10)
        {
            BadgeCover003.SetActive(false);
            gotBadge003 = true;
            badge003Count = 1;
        }

        //platformer game
        if (player.transform.position.y > 6)
        {
            BadgeCover010.SetActive(false);
            gotBadge010 = true;
            badge010Count = 1;
        }
        if (platformerScoreScript.score >= 180)
        {
            BadgeCover011.SetActive(false);
            gotBadge011 = true;
            badge011Count = 1;
        }
        if (platformerScoreScript.enemyKillCount >= 25)
        {
            BadgeCover012.SetActive(false);
            gotBadge012 = true;
            badge012Count = 1;
        }
        //artifact game
        if (artifactsScript.ArtifactCount >= 1)
        {
            BadgeCover004.SetActive(false);
            gotBadge004 = true;
            badge004Count = 1;
        }
        if (artifactsScript.Artifact003.active)
        {
            BadgeCover005.SetActive(false);
            gotBadge005 = true;
            badge005Count = 1;
        }
        if (artifactsScript.ArtifactCount >= 10)
        {
            BadgeCover006.SetActive(false);
            gotBadge006 = true;
            badge006Count = 1;
        }

        //stress game
        if(stressManagerMainScript.GrandTotalPerformancePoints >= 500)
        {
            BadgeCover007.SetActive(false);
            gotBadge007 = true;
            badge007Count = 1;
        }
        if (stressManagerMainScript.MentalHealthPoints >= 100)
        {
            BadgeCover008.SetActive(false);
            gotBadge008 = true;
            badge008Count = 1;
        }
        if (stressManagerMainScript.StaminaPoints <= 0)
        {
            BadgeCover009.SetActive(false);
            gotBadge009 = true;
            badge009Count = 1;
        }



        //win

        if(gotBadge001 && gotBadge002 && gotBadge003 && gotBadge004 && gotBadge005 && gotBadge006 && gotBadge007 && gotBadge008 && gotBadge009 && gotBadge010 && gotBadge011 && gotBadge012)
        {
            WinPanel.SetActive(true);
        }
        
    }
}
