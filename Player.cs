using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    public float maxspeed = 10;
    private Animator myAnimator;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myAnimator = GetComponent<Animator>();

    }

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
            rb.AddForce(moveHorizontal, 0.0f, moveVertical);
        }
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }

        {
            if (Input.GetKeyDown("space"))

            {
                myAnimator.SetBool("letsJump", true);
            }



            Debug.Log(movement);
        }
    }
}


        
    

    

    



          


  