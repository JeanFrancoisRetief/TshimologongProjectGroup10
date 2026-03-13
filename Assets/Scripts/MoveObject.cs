using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.1f; // A value between 0 and 1 for smoothing

    void Update()
    {
        // Interpolate position
        transform.position = Vector3.Lerp(transform.position, target.position, smoothSpeed * Time.deltaTime);
    }
}
