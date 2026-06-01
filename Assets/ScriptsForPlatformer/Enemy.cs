using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player; // Assign the Player object in the Inspector
    private NavMeshAgent agent;

    private float dist;

    public int enemyHealth;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemyHealth = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(agent.transform.position, player.transform.position);
        if (player != null)
        {
            // Update the agent's destination to the player's current position
            if(dist < 15)
            {
                agent.SetDestination(player.position);
            }
            
        }

    }

    public void DamageEnemy()
    {
        enemyHealth--;
    }
}
