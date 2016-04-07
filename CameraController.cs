using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    //Camera Controller for both cameras. Follows the players transform position (x,y,z).
    //Does not transform it's own position in correspondence with the player keeping the camera static but tracking players movements.
    public GameObject target;
    public float damping = 0;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.position = position;

        transform.LookAt(target.transform.position);
    }
}
