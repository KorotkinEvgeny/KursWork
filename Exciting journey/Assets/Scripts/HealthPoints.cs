using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthPoints : MonoBehaviour {

    public int maxPlayerHealth;
    public static int PlayerHealth;

    Text text;

    private LevelManager levelManager;

	void Start () {
        text = GetComponent<Text>();
        PlayerHealth = maxPlayerHealth;
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	void Update () {

        text.text = "" + PlayerHealth;
       
	
	}
}
