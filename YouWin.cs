using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YouWin : MonoBehaviour {

    public Text winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("You Win!");
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
