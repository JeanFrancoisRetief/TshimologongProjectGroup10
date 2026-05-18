using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject lightBulb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightBulb.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        lightBulb.SetActive(false);
    }
}
