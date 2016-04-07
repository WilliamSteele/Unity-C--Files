using UnityEngine;
using System.Collections;

public class Camera2Teleport : MonoBehaviour {


    //Script attached to the Camera Switcher trigger.

    public Camera Camera1;
    public Camera Camera2;


    void Start()
    {

    }

    void Update()
    {

    }
    //When the Player actor enters the trigger this changes the main camera view we're using from the starting camera to the secondary camera view.
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Camera1.enabled = true;

            Camera2.enabled = false;
        }
    }
    //When you exit the trigger, this switches the camera back to the main camera view.

}

