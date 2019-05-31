using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public GameManager gameManager; 
	public float speed;
	public int score;

	private Rigidbody rb;


	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (0.0f, moveVertical, 0.0f);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		print("on trigger enter");
		if(other.gameObject.CompareTag("targetPrefab"))
		 {
			gameManager.SetScoreText();

			


		}
	}

}
