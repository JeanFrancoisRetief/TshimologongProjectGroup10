using UnityEngine;

public class GameModeTrigger : MonoBehaviour
{
    public GameModes gameModesScript;

    public GameObject otherTrigger;

    //public GameModes.GameMode switchToGameMode;

    public enum TriggerType
    {
        PlatformerToRecyling,
        PlatformerToArtifacts,
        PlatformerToStress
    }

    public TriggerType currentTriggerType;
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
            if(currentTriggerType == TriggerType.PlatformerToRecyling)
            {
                if(gameModesScript.currentGameMode == GameModes.GameMode.ElectricityPlatformer)
                {
                    gameModesScript.currentGameMode = GameModes.GameMode.RecyclingManager;
                }
                else if (gameModesScript.currentGameMode == GameModes.GameMode.RecyclingManager)
                {
                    gameModesScript.currentGameMode = GameModes.GameMode.ElectricityPlatformer;
                }            
            }

            if(currentTriggerType == TriggerType.PlatformerToStress)
            {
                if (gameModesScript.currentGameMode == GameModes.GameMode.ElectricityPlatformer)
                {
                    gameModesScript.currentGameMode = GameModes.GameMode.StressManager;
                    gameModesScript.StressScreen.SetActive(true);
                }
                else if (gameModesScript.currentGameMode == GameModes.GameMode.StressManager)
                {
                    gameModesScript.currentGameMode = GameModes.GameMode.ElectricityPlatformer;
                }
            }

            if (currentTriggerType == TriggerType.PlatformerToArtifacts)
            {
                if (gameModesScript.currentGameMode == GameModes.GameMode.ElectricityPlatformer)
                {
                    gameModesScript.currentGameMode = GameModes.GameMode.ArtifactHunter;
                }
                else if (gameModesScript.currentGameMode == GameModes.GameMode.ArtifactHunter)
                {
                    gameModesScript.currentGameMode = GameModes.GameMode.ElectricityPlatformer;
                }
            }

            

            otherTrigger.SetActive(true);
            if (currentTriggerType != TriggerType.PlatformerToStress)
                gameModesScript.firstVsThirdPersonScript.switchCamMode();
            gameObject.SetActive(false);
        }
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (currentTriggerType == TriggerType.PlatformerToStress)
            {
                if (gameModesScript.currentGameMode == GameModes.GameMode.StressManager)
                {
                    
                    gameModesScript.StressScreen.SetActive(true);
                }
            }
        }


        }*/
}
