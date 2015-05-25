using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour {

    public LevelManager levelManager;
    public AudioSource deathSound;

	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "CharacterNew")
        {
            levelManager.RespawnPlayer();
            Score.score = Score.score - 10;
            HealthPoints.PlayerHealth -= 1;
            deathSound.Play();
        }
    }
}
