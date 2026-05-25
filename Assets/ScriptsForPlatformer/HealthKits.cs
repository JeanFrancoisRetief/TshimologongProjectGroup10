using UnityEngine;

public class HealthKits : MonoBehaviour
{
    public PlayerHealth playerHealthScript;
    public GameObject HealthHitPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerHealthScript.playerHealth += 25 * 30;

            HealthHitPrefab.SetActiveRecursively(false);
        }
        
        

    }
}
