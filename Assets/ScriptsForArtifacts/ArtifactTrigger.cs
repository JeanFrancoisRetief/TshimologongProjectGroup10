using UnityEngine;

public class ArtifactTrigger : MonoBehaviour
{
    public int ArtifactIndex;

    public Artifacts artifactsScript;

    public GameObject currentObj;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        artifactsScript.Artifact001.SetActiveRecursively(false);
        artifactsScript.Artifact002.SetActiveRecursively(false);
        artifactsScript.Artifact003.SetActiveRecursively(false);
        artifactsScript.Artifact004.SetActiveRecursively(false);
        artifactsScript.Artifact005.SetActiveRecursively(false);
        artifactsScript.Artifact006.SetActiveRecursively(false);
        artifactsScript.Artifact007.SetActiveRecursively(false);
        artifactsScript.Artifact008.SetActiveRecursively(false);
        artifactsScript.Artifact009.SetActiveRecursively(false);
        artifactsScript.Artifact010.SetActiveRecursively(false);
        
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
            else if (ArtifactIndex == 3)
            {
                artifactsScript.Artifact003.SetActiveRecursively(true);
            }
            else if (ArtifactIndex == 4)
            {
                artifactsScript.Artifact004.SetActiveRecursively(true);
            }
            else if (ArtifactIndex == 5)
            {
                artifactsScript.Artifact005.SetActiveRecursively(true);
            }
            else if (ArtifactIndex == 6)
            {
                artifactsScript.Artifact006.SetActiveRecursively(true);
            }
            else if (ArtifactIndex == 7)
            {
                artifactsScript.Artifact007.SetActiveRecursively(true);
            }
            else if (ArtifactIndex == 8)
            {
                artifactsScript.Artifact008.SetActiveRecursively(true);
            }
            else if (ArtifactIndex == 9)
            {
                artifactsScript.Artifact009.SetActiveRecursively(true);
            }
            else if (ArtifactIndex == 10)
            {
                artifactsScript.Artifact010.SetActiveRecursively(true);
            }


            currentObj.SetActiveRecursively(false);
        }
    }
}
