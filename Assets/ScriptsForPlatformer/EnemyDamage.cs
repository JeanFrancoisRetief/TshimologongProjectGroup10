using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyHealth;

    public GameObject Enemy;
    public GameObject FullHealthState;
    public GameObject TwoHealthState;
    public GameObject OneHealthState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyHealth = 3;
        FullHealthState.SetActive(true);
        TwoHealthState.SetActive(false);
        OneHealthState.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        enemyHealth--;
        if (enemyHealth == 2)
        {
            FullHealthState.SetActive(false);
            TwoHealthState.SetActive(true);
            OneHealthState.SetActive(false);
        }
        else if(enemyHealth == 1)
        {
            FullHealthState.SetActive(false);
            TwoHealthState.SetActive(false);
            OneHealthState.SetActive(true);
        }
        else if (enemyHealth == 0)
        {
            Enemy.SetActiveRecursively(false);
        }
    }
}
