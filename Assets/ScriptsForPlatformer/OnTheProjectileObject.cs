using UnityEngine;

public class OnTheProjectileObject : MonoBehaviour
{
    public float lifeTime = 5f;

    void Start()
    {
        // Automatically destroy after a set time
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Add logic for hitting enemies or obstacles here
        Debug.Log("Hit " + collision.gameObject.name);


        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().DamageEnemy();
        }



        // Destroy the projectile on impact
        Destroy(gameObject);
    }
}
