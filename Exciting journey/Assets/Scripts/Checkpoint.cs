﻿using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public LevelManager levelManager;

	void Start () {

        levelManager = FindObjectOfType<LevelManager>();
	
	}
	
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "CharacterNew")
        {
            levelManager.currentCheckpoint = gameObject;
            Debug.Log("Activated Checkpoint" + transform.position);
        }
    }
}
