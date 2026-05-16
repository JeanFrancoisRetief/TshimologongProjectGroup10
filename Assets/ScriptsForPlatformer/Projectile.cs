using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float launchForce = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Left-click
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Create the projectile at the firePoint's position and rotation
        GameObject bullet = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody and apply force
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firePoint.forward * launchForce, ForceMode.Impulse);
        }
    }
}
