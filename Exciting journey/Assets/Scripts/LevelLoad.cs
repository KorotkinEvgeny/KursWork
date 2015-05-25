using UnityEngine;
using System.Collections;

public class LevelLoad : MonoBehaviour {

    private bool isPlayerInside;

    public string levelToLoad;

	// Use this for initialization
	void Start () {
        isPlayerInside = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(isPlayerInside == true)
        {
            Application.LoadLevel(levelToLoad);
        }
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "CharacterNew")
        {
            isPlayerInside = true;
        }
    }
}
