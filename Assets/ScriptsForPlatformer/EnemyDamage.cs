using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public Enemy enemyScript;

    public GameObject Enemy;
    public GameObject FullHealthState;
    public GameObject TwoHealthState;
    public GameObject OneHealthState;

    public PlatformerScore platformerScoreScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FullHealthState.SetActive(true);
        TwoHealthState.SetActive(false);
        OneHealthState.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.enemyHealth == 2)
        {
            FullHealthState.SetActive(false);
            TwoHealthState.SetActive(true);
            OneHealthState.SetActive(false);
        }
        else if (enemyScript.enemyHealth == 1)
        {
            FullHealthState.SetActive(false);
            TwoHealthState.SetActive(false);
            OneHealthState.SetActive(true);
        }
        else if (enemyScript.enemyHealth == 0)
        {
            platformerScoreScript.enemyKillCount++;


            Enemy.SetActiveRecursively(false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        enemyScript.DamageEnemy();
    }


    
}
