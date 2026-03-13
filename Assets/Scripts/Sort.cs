using UnityEngine;

public class Sort : MonoBehaviour
{
    public enum MaterialType {
        metal,
        glass,
        paper,
        other
    };

    public MaterialType thisObjectMatType;
    
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
        if(other.tag == "Metal")
        {

        }
        else if (other.tag == "Glass")
        {

        }
        else if (other.tag == "Paper")
        {

        }
        else if (other.tag == "Other")
        {

        }
    }
}
