using UnityEngine;

public class Folowplayer : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public FirstVsThirdPerson FirstVsThirdPersonScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FirstVsThirdPersonScript.isThirdPerson)
        {
            gameObject.transform.position = player2.transform.position;
        }
        else
        {
            gameObject.transform.position = player1.transform.position;
        }
        

    }
}
