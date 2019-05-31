using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	public GameObject player;
	public GameObject targetPrefab;
	public int score; 
	public Text noteText;
	public Text scoreText;
	public GameObject [] spawnLocations;
	public GameObject restartButton;



	int randomInt;

	private GameObject lastNote;

	void Start ()
	{

		score = 0;
		noteText.text = "NOTE";
		InvokeRepeating("GenerateTarget", 1.0f, 1.5f);


		

	}

	 public void SetScoreText ()
	 {
	 	score++;


	 	scoreText.text = "SCORE: " + score.ToString ();

	 	print("score: " + score.ToString());

	 	if (score>=10)
	 	{
	 		restartButton.SetActive(true);
	 	}
	 }


	 public void SetNoteText (string note)
	 
	 {
	 	noteText.text = note;
	 }


	 public void GenerateTarget ()
	 {
	 	
		GameObject thisSpawnLocation;
		GameObject thisTarget;

		thisSpawnLocation = spawnLocations[(Random.Range(0,4))];

		Vector3 maayan = thisSpawnLocation.transform.position;

		 thisTarget = Instantiate(targetPrefab, maayan, Quaternion.identity);

		 thisTarget.GetComponent<Target>().note = thisSpawnLocation.name;

		 //spawnLocations.GetComponent<AudioClip>().Audio.play = thisTarget;


	 }

	 private Dictionary<string, int> noteToIndex = new Dictionary<string, int>()
	 {
		{"F", 0},
		{"D", 1},
		{"B", 2},
		{"G", 3},
		{"E", 4}
	
	 };

	 public void PlayNote(string note)
	 {

	 	int index = noteToIndex[note];

	
	 		AudioSource audio = spawnLocations[index].GetComponent<AudioSource>();
        	audio.Play();
		 
	 }


}

		




