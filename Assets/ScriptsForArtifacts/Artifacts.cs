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
    public GameObject Artifact003;
    public GameObject Artifact004;
    public GameObject Artifact005;
    public GameObject Artifact006;
    public GameObject Artifact007;
    public GameObject Artifact008;
    public GameObject Artifact009;
    public GameObject Artifact010;


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
