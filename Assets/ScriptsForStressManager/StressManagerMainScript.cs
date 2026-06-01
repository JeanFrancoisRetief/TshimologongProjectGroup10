using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StressManagerMainScript : MonoBehaviour
{
    public GameObject SMMGPanel;

    public int DayCounter;
    public TMP_Text DayText;

    public float MentalHealthPoints;
    public float StaminaPoints;
    public float PerformancePoints;
    public float Hours;

    public float GrandTotalPerformancePoints;

    public Slider MHPslider;
    public Slider SPslider;
    public Slider PPslider;
    public Slider Hslider;
    public TMP_Text MHPtext;
    public TMP_Text SPtext;
    public TMP_Text PPtext;
    public TMP_Text Htext;

    public TMP_Text GrandTotalPPtext;

    public float currentMHPaddition;
    public float currentSPaddition;
    public float currentPPaddition;
    public float currentHaddition;

    public TMP_Text currentMHPtext;
    public TMP_Text currentSPtext;
    public TMP_Text currentPPtext;
    public TMP_Text currentHtext;

    private bool smallTaskClicked;
    private bool mediumTaskClicked;
    private bool largeTaskClicked;

    private bool RRsleepClicked;
    private bool RRnapClicked;
    private bool RRtvClicked;
    private bool RRvideogamesClicked;

    private bool RRTherapyClicked;
    private bool RRMeditateClicked;

    public Toggle ST_Toggle;
    public Toggle MT_Toggle;
    public Toggle LT_Toggle;

    public Toggle RRSleep_Toggle;
    public Toggle RRnap_Toggle;
    public Toggle RRtv_Toggle;
    public Toggle RRvideogames_Toggle;

    public Toggle RRTherapy_Toggle;
    public Toggle RRMeditate_Toggle;

    public GameObject ErrorPanel;
    public GameObject WeekEndPanel;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GrandTotalPerformancePoints = 0;

        DayCounter = 1;

        //init values
        MentalHealthPoints = 50;
        StaminaPoints = 50;
        PerformancePoints = 0;
        Hours = 24;

        currentMHPaddition = 0;
        currentSPaddition = 0;
        currentPPaddition = 0;
        currentHaddition = 0;

        smallTaskClicked = false;
        mediumTaskClicked = false;
        largeTaskClicked = false;

        RRsleepClicked = false;
        RRnapClicked = false;
        RRtvClicked = false;
        RRvideogamesClicked = false;

        ErrorPanel.SetActive(false);
        WeekEndPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //valitdaion
        ValidateValues();

        //Display
        DisplayOnSliders();

        //
        if(SMMGPanel.active)
        {
            // Unlocks the cursor so it can move freely
            Cursor.lockState = CursorLockMode.None;

            // Makes the cursor visible on the screen
            Cursor.visible = true;
        }
        else
        {
            // Makes the cursor invisible
            Cursor.visible = false;

            // Optional: Locks the cursor to the center of the screen
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

    public void ValidateValues()
    {
        if (MentalHealthPoints > 100)
        {
            MentalHealthPoints = 100;
        }

        if (StaminaPoints > 100)
        {
            StaminaPoints = 100;
        }

        if (PerformancePoints > 100)
        {
            PerformancePoints = 100;
        }

        if (Hours > 24)
        {
            Hours = 24;
        }

        if (MentalHealthPoints < 0)
        {
            MentalHealthPoints = 0;
        }

        if (StaminaPoints < 0)
        {
            StaminaPoints = 0;
        }

        if (PerformancePoints < 0)
        {
            PerformancePoints = 0;
        }

        if (Hours < 0)
        {
            Hours = 0;
        }
    }

    public void DisplayOnSliders()
    {
        MHPslider.value = MentalHealthPoints;
        SPslider.value = StaminaPoints;
        PPslider.value = PerformancePoints;
        Hslider.value = Hours;

        MHPtext.text = MentalHealthPoints.ToString();
        SPtext.text = StaminaPoints.ToString();
        PPtext.text = PerformancePoints.ToString();
        Htext.text = Hours.ToString();

        currentMHPtext.text = currentMHPaddition.ToString();
        currentSPtext.text = currentSPaddition.ToString();
        currentPPtext.text = currentPPaddition.ToString();
        currentHtext.text = currentHaddition.ToString();

        ST_Toggle.isOn = smallTaskClicked;
        MT_Toggle.isOn = mediumTaskClicked;
        LT_Toggle.isOn = largeTaskClicked;

        GrandTotalPPtext.text = GrandTotalPerformancePoints.ToString();

        RRSleep_Toggle.isOn = RRsleepClicked;
        RRnap_Toggle.isOn = RRnapClicked;
        RRtv_Toggle.isOn = RRtvClicked;
        RRvideogames_Toggle.isOn = RRvideogamesClicked;

        RRTherapy_Toggle.isOn = RRTherapyClicked;
        RRMeditate_Toggle.isOn = RRMeditateClicked;

        DayText.text = DayCounter.ToString();

    }


    public void AddToShedule()
    {
        MentalHealthPoints += currentMHPaddition;
        StaminaPoints += currentSPaddition;
        PerformancePoints += currentPPaddition;
        Hours += currentHaddition;
    }

    public void RemoveFromShedule()
    {
        MentalHealthPoints -= currentMHPaddition;
        StaminaPoints -= currentSPaddition;
        PerformancePoints -= currentPPaddition;
        Hours -= currentHaddition;
    }

    public void EndOfDay()
    {
        Hours = 24;

        GrandTotalPerformancePoints += PerformancePoints;
        PerformancePoints = 0;

        if(DayCounter < 5)
        {
            DayCounter++;
        }
        else
        {
            EndofWeek();
        }
        
    }

    public void EndofWeek()
    {
        WeekEndPanel.SetActive(true);
    }

    public void OnConfrimClick()
    {
        float MHPTestValue = MentalHealthPoints + currentMHPaddition;
        float SPTestValue = StaminaPoints + currentSPaddition;
        float HTestValue = Hours + currentHaddition;


        if ((MHPTestValue < 0) || (SPTestValue < 0) || (HTestValue < 0))
        {
            //Error Message
            ErrorPanel.SetActive(true);

        }
        else
        {
            

            AddToShedule();
        }
    }

    public void OnErrorPanelExitClick()
    {
        ErrorPanel.SetActive(false);
    }

    public void OnSmallTaskClick()
    {
        if(!smallTaskClicked)
        {
            currentMHPaddition += -5;
            currentSPaddition += -7;
            currentPPaddition += +10;
            currentHaddition += -1;
        }
        else
        {
            currentMHPaddition -= -5;
            currentSPaddition -= -7;
            currentPPaddition -= +10;
            currentHaddition -= -1;
        }

        smallTaskClicked = !smallTaskClicked;


    }

    public void OnMediumTaskClick()
    {
        if (!mediumTaskClicked)
        {
            currentMHPaddition += -15;
            currentSPaddition += -22;
            currentPPaddition += +30;
            currentHaddition += -3;
        }
        else
        {
            currentMHPaddition -= -15;
            currentSPaddition -= -22;
            currentPPaddition -= +30;
            currentHaddition -= -3;
        }

        mediumTaskClicked = !mediumTaskClicked;


    }

    public void OnLargeTaskClick()
    {
        if (!largeTaskClicked)
        {
            currentMHPaddition += -40;
            currentSPaddition += -60;
            currentPPaddition += +80;
            currentHaddition += -8;
        }
        else
        {
            currentMHPaddition -= -40;
            currentSPaddition -= -60;
            currentPPaddition -= +80;
            currentHaddition -= -8;
        }

        largeTaskClicked = !largeTaskClicked;


    }

    public void OnRRSleepClick()
    {
        if (!RRsleepClicked)
        {
            currentMHPaddition += +20;
            currentSPaddition += +80;
            currentPPaddition += 0;
            currentHaddition += -8;
        }
        else
        {
            currentMHPaddition -= +20;
            currentSPaddition -= +80;
            currentPPaddition -= 0;
            currentHaddition -= -8;
        }

        RRsleepClicked = !RRsleepClicked;
    }

    public void OnRRnapClick()
    {
        if (!RRnapClicked)
        {
            currentMHPaddition += +2;
            currentSPaddition += +10;
            currentPPaddition += 0;
            currentHaddition += -1;
        }
        else
        {
            currentMHPaddition -= +2;
            currentSPaddition -= +10;
            currentPPaddition -= 0;
            currentHaddition -= -1;
        }

        RRnapClicked = !RRnapClicked;
    }

    public void OnRRtvClick()
    {
        if (!RRtvClicked)
        {
            currentMHPaddition += +5;
            currentSPaddition += +5;
            currentPPaddition += 0;
            currentHaddition += -2;
        }
        else
        {
            currentMHPaddition -= +5;
            currentSPaddition -= +5;
            currentPPaddition -= 0;
            currentHaddition -= -2;
        }

        RRtvClicked = !RRtvClicked;
    }

    public void OnRRvideogamesClick()
    {
        if (!RRvideogamesClicked)
        {
            currentMHPaddition += +15;
            currentSPaddition += -5;
            currentPPaddition += 0;
            currentHaddition += -2;
        }
        else
        {
            currentMHPaddition -= +15;
            currentSPaddition -= -5;
            currentPPaddition -= 0;
            currentHaddition -= -2;
        }

        RRvideogamesClicked = !RRvideogamesClicked;
    }

    public void OnRRTherapyClick()
    {
        if (!RRTherapyClicked)
        {
            currentMHPaddition += +40;
            currentSPaddition += -30;
            currentPPaddition += 0;
            currentHaddition += -1;
        }
        else
        {
            currentMHPaddition -= +40;
            currentSPaddition -= -30;
            currentPPaddition -= 0;
            currentHaddition -= -1;
        }

        RRTherapyClicked = !RRTherapyClicked;
    }

    public void OnRRMeditateClick()
    {
        if (!RRMeditateClicked)
        {
            currentMHPaddition += +5;
            currentSPaddition += +5;
            currentPPaddition += 0;
            currentHaddition += -1;
        }
        else
        {
            currentMHPaddition -= +5;
            currentSPaddition -= +5;
            currentPPaddition -= 0;
            currentHaddition -= -1;
        }

        RRMeditateClicked = !RRMeditateClicked;
    }


}
