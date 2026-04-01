using UnityEngine;

public class SortTrigger : MonoBehaviour
{
    public Score scoreScript;
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
        if (this.gameObject.tag == "Metal")
        {
            if (other.TryGetComponent<Sort>(out Sort sortScript)) ;
            {
                if(sortScript.thisObjectMatType == Sort.MaterialType.metal)
                {
                    //Correct
                    scoreScript.scoreValue++;
                }
                else
                {
                    scoreScript.scoreValue--;
                }
            }
        }
        else if (this.gameObject.tag == "Glass")
        {
            if (other.TryGetComponent<Sort>(out Sort sortScript)) ;
            {
                if (sortScript.thisObjectMatType == Sort.MaterialType.glass)
                {
                    //Correct
                    scoreScript.scoreValue++;
                }
                else
                {
                    scoreScript.scoreValue--;
                }
            }
        }
        else if (this.gameObject.tag == "Paper")
        {
            if (other.TryGetComponent<Sort>(out Sort sortScript)) ;
            {
                if (sortScript.thisObjectMatType == Sort.MaterialType.paper)
                {
                    //Correct
                    scoreScript.scoreValue++;
                }
                else
                {
                    scoreScript.scoreValue--;
                }
            }
        }
        else if (this.gameObject.tag == "Plastic")
        {
            if (other.TryGetComponent<Sort>(out Sort sortScript)) ;
            {
                if (sortScript.thisObjectMatType == Sort.MaterialType.plastic)
                {
                    //Correct
                    scoreScript.scoreValue++;
                }
                else
                {
                    scoreScript.scoreValue--;
                }
            }
        }
        else if (this.gameObject.tag == "Other")
        {
            if (other.TryGetComponent<Sort>(out Sort sortScript)) ;
            {
                if (sortScript.thisObjectMatType == Sort.MaterialType.other)
                {
                    //Correct
                    scoreScript.scoreValue++;
                }
                else
                {
                    scoreScript.scoreValue--;
                }
            }
        }
        
        other.enabled = false;
        //other.transform.position = new Vector3(0, -500, 0);
        Destroy(other);
        //scoreScript.pickupScript.heldObj = null;

    }


}
