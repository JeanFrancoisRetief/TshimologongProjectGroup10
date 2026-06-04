using UnityEngine;

public class GameModes : MonoBehaviour
{
    public enum GameMode
    {
        ElectricityPlatformer,
        RecyclingManager,
        StressManager,
        ArtifactHunter
    }

    public GameMode currentGameMode;

    public GameObject MusicForPlatforming;
    public GameObject MusicForRecyling;
    public GameObject MusicForStress;
    public GameObject MusicForArtifacts;

    public FirstVsThirdPerson firstVsThirdPersonScript;
    public GameObject StressScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentGameMode = GameMode.RecyclingManager;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentGameMode == GameMode.ElectricityPlatformer)
        {
            MusicForPlatforming.SetActive(true);
            MusicForRecyling.SetActive(false);
            MusicForStress.SetActive(false);
            MusicForArtifacts.SetActive(false);
        }
        else if(currentGameMode == GameMode.RecyclingManager)
        {
            MusicForPlatforming.SetActive(false);
            MusicForRecyling.SetActive(true);
            MusicForStress.SetActive(false);
            MusicForArtifacts.SetActive(false);
        }
        else if (currentGameMode == GameMode.StressManager)
        {
            MusicForPlatforming.SetActive(false);
            MusicForRecyling.SetActive(false);
            MusicForStress.SetActive(true);
            MusicForArtifacts.SetActive(false);
        }
        else if (currentGameMode == GameMode.ArtifactHunter)
        {
            MusicForPlatforming.SetActive(false);
            MusicForRecyling.SetActive(false);
            MusicForStress.SetActive(false);
            MusicForArtifacts.SetActive(true);
        }
    }
}
