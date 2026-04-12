using UnityEngine;

public class StartStopButtons : MonoBehaviour
{
    public GameObject ButtonPressed;
    public GameObject ButtonUnpressed;
    public bool isPressed;

    public GameObject SpawnerScriptHolder;
    public GameObject BlockingWalls;


    public enum ButtonType
    {
        Start,
        Stop
    }

    public ButtonType thisButtonType;

    public GameObject ButtonUIhintText;
    public GameObject GameUIhintText;

    public StartStopButtons OtherStartStopButtonsScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ButtonUIhintText.SetActive(false);
        GameUIhintText.SetActive(false);

        SpawnerScriptHolder.SetActive(false);
        BlockingWalls.SetActiveRecursively(false);

        if (thisButtonType == ButtonType.Start)
        {
            isPressed = false;
        }
        if (thisButtonType == ButtonType.Stop)
        {
            isPressed = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed)
        {
            ButtonPressed.SetActiveRecursively(true);
            ButtonUnpressed.SetActiveRecursively(false);
        }
        else
        {
            ButtonPressed.SetActiveRecursively(false);
            ButtonUnpressed.SetActiveRecursively(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(!isPressed)
        //ButtonUIhintText.SetActive(true);

        if (!isPressed)
        {
            isPressed = true;
            OtherStartStopButtonsScript.isPressed = false;


            if (thisButtonType == ButtonType.Start)
            {
                GameUIhintText.SetActive(true);
                SpawnerScriptHolder.SetActive(true);
                BlockingWalls.SetActiveRecursively(true);

            }

            if (thisButtonType == ButtonType.Stop)
            {
                GameUIhintText.SetActive(false);
                SpawnerScriptHolder.SetActive(false);
                BlockingWalls.SetActiveRecursively(false);

            }


        }
        else
        {

            //isPressed = false;
            //OtherStartStopButtonsScript.isPressed = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //if (Input.GetKeyDown(KeyCode.E))
        //{
            
        //}

        
    }

    public void OnTriggerExit(Collider other)
    {
        //ButtonUIhintText.SetActive(false);
    }
}
