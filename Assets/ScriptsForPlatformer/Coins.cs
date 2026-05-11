using UnityEngine;

public class Coins : MonoBehaviour
{
    public float spinSpeed = 50f;
    public PlatformerScore platformerScoreScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotates the object around the Y-axis by spinSpeed degrees per second
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            platformerScoreScript.score++;
            gameObject.SetActiveRecursively(false);
        }
        
    }
}
