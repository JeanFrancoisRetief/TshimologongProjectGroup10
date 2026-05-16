using UnityEngine;

public class FirstVsThirdPerson : MonoBehaviour
{
    public bool isThirdPerson;

    public GameObject ThirdPersonCharacter;
    public GameObject ThirdPersonCam;
    public GameObject Tuttext;

    public GameObject FirstPersonCharacter;
    public GameObject FirstPersonCam;
    public GameObject FirstPersonCamHolder;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isThirdPerson = false;

        // Makes the cursor invisible
        Cursor.visible = false;

        // Optional: Locks the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (isThirdPerson)
        {
            ThirdPersonCharacter.SetActive(true);
            ThirdPersonCam.SetActive(true);
            Tuttext.SetActive(true);

            FirstPersonCharacter.SetActive(false);
            FirstPersonCam.SetActive(false);
            FirstPersonCamHolder.SetActive(false);
        }
        else
        {
            ThirdPersonCharacter.SetActive(false);
            ThirdPersonCam.SetActive(false);
            Tuttext.SetActive(false);

            FirstPersonCharacter.SetActive(true);
            FirstPersonCam.SetActive(true);
            FirstPersonCamHolder.SetActive(true);
        }

        


        if (Input.GetKeyDown(KeyCode.C))
        {
            if(isThirdPerson)
            {
                FirstPersonCharacter.transform.position = ThirdPersonCharacter.transform.position;
                FirstPersonCharacter.transform.rotation = ThirdPersonCharacter.transform.rotation;
            }
            else
            {
                ThirdPersonCharacter.transform.position = FirstPersonCharacter.transform.position;
                ThirdPersonCharacter.transform.rotation = FirstPersonCharacter.transform.rotation;
            }


                isThirdPerson = !isThirdPerson;
        }
    }
}
