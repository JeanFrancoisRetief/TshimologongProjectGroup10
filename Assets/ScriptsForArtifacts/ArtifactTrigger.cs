using UnityEngine;

public class ArtifactTrigger : MonoBehaviour
{
    public int ArtifactIndex;

    public Artifacts artifactsScript;

    public GameObject currentObj;

    

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
            artifactsScript.ArtifactCount++;

            if(ArtifactIndex == 1)
            {
                artifactsScript.Artifact001.SetActiveRecursively(true);
            }
            else if(ArtifactIndex == 2)
            {
                artifactsScript.Artifact002.SetActiveRecursively(true);
            }





                currentObj.SetActiveRecursively(false);
        }
    }
}
