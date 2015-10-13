﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

	private bool gameStarted = false;
	[SerializeField]
	private Text gameStateText;
	[SerializeField]
	private GameObject player;
	[SerializeField]
	private BirdMovement birdMovement;
	[SerializeField]
	private FollowCamera followCamera;
	private float restartDelay = 3f;
	private float restartTimer;
	private PlayerMovement playerMovement;
	private PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;

		playerMovement = player.GetComponent<PlayerMovement> ();
		playerHealth = player.GetComponent<PlayerHealth> ();

		// Prevent the player from moving at the start of the game
		playerMovement.enabled = false;

		// Prevent the bird from moving at the start of the game
		birdMovement.enabled = false;

		// Prevent the follow camera from moving to its game position
		followCamera.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
