using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject paperBook;
    public GameObject plasticBottle;
    public GameObject metalCan;
    public GameObject glassBottle;

    public GameObject randomObj;
    public float delay = 5f;
    public Transform spawnPos;
    private int randomNumber;

    //public bool isSpawnerActive;

    void Awake()
    {
        StartCoroutine(SpawnRoutine());
        randomObj = paperBook;
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(1, 5);
        if(randomNumber == 1)
        {
            randomObj = paperBook;
        }
        if (randomNumber == 2)
        {
            randomObj = plasticBottle;
        }
        if (randomNumber == 3)
        {
            randomObj = metalCan;
        }
        if (randomNumber == 4)
        {
            randomObj = glassBottle;
        }
    }

    IEnumerator SpawnRoutine()
    {
        while (true) // Loop forever
        {
            Instantiate(randomObj, spawnPos.position, Quaternion.identity);
            yield return new WaitForSeconds(delay); // Wait before next spawn
        }
    }
}
