using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    //Player Controller for the player cube.

    private Rigidbody rb;
    public float speed;
    public float maxspeed = 10;
    public float time;
    public float stop;


    void Start () {
        rb = GetComponent<Rigidbody>();

    }
    //Basic Vector3 movement.
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (speed < maxspeed)
        {

            rb.AddForce(movement * speed);
        }
        else
        {
            rb.StopForce;
        }
    }
  
 
    //OnTriggerEnter for the Object named "Lamp" that will transform the "Lamp" object to a child object of the "Player" Object.
    //This, essentially, attaches the lamp to our players actor.
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Lamp")
        {
            other.transform.parent = transform;
        }
    }
}
