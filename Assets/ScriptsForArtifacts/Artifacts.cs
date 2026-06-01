using TMPro;
using UnityEngine;

public class Artifacts : MonoBehaviour
{

    public int ArtifactCount;
    public TMP_Text ArtifactCountText;
    /*public struct Artifact
    {
        public string Name;
        public string Desciption;
        public GameObject ModelInCase;

    }

    [SerializeField]
    public Artifact[] ArtifactArray;*/
    public GameObject Artifact001;
    public GameObject Artifact002;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ArtifactCount = 0;

       

    }

    // Update is called once per frame
    void Update()
    {
        ArtifactCountText.text = ArtifactCount.ToString();
    }
}
