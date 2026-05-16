using UnityEngine;

public class ShootMode : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 targetPositionShootMode;
    private Vector3 targetPositionStandByMode;
    private Vector3 targetPosition;

    public GameObject targetObjShootMode;
    public GameObject targetObjStandByMode;

    public bool InShootMode;

    private void Start()
    {
        InShootMode = false;
    }

    void Update()
    {
        targetPositionShootMode = targetObjShootMode.transform.position;
        targetPositionStandByMode = targetObjStandByMode.transform.position;
        // Moves the object at a constant speed independent of frame rate
        if (!InShootMode && Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            InShootMode = true;
        }
        else if(InShootMode && Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            InShootMode = false;
        }


        if(InShootMode)
        {
            targetPosition = targetPositionShootMode;

            gameObject.GetComponent<Projectile>().launchForce = 40;
        }
        else
        {
            targetPosition = targetPositionStandByMode;

            gameObject.GetComponent<Projectile>().launchForce = 25;
        }
            //transform.position = targetPosition;

        if (transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }

    }
}
