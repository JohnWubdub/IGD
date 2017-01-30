using UnityEngine;
using System.Collections;

public class Targeting : MonoBehaviour { 

    public float MovementSpeed; //public number to allow for chnages during gameplay

	void Start ()
    {
	
	}
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + MovementSpeed, 0); //Upward Movement
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - MovementSpeed, 0); //Downward Movement
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x + MovementSpeed, transform.position.y, 0); //Rightward Movement
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x - MovementSpeed, transform.position.y, 0); //Leftward Movement
        }

    }
}
