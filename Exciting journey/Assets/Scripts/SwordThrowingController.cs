using UnityEngine;
using System.Collections;

public class SwordThrowingController : MonoBehaviour {

    public float throwingSpeed;

    public PlayerController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        if(player.transform.localScale.x < 0)
        {
            throwingSpeed = -throwingSpeed;
            //Отражение объекта
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(throwingSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Score.score += 100;
        }
        Destroy(gameObject);
    }

}
