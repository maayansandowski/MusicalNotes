using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	public GameManager gameManager; 
	public GameObject player;
	public GameObject backstop;
	public string note = "";

	private float moveSpeed = 2.75f;


	void Start (){

		gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
	}

	void Update ()
	{
	 transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
	}


    void OnTriggerEnter (Collider other)
    {


    	if(other.gameObject.CompareTag("player") || other.gameObject.CompareTag("backstop"))
    	{

    		gameManager.SetNoteText (note);

    		Destroy (this.gameObject);
    	}

 		if (other.gameObject.CompareTag("player"))
 		{
 			gameManager.PlayNote(note);
 		}

    }

}
