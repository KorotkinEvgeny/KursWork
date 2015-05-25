using UnityEngine;
using System.Collections;

public class PickUpCoin : MonoBehaviour {

    public int pointToAdd;
    public AudioSource coinPickUpSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PlayerController>()==null)
        {
            return;
        }
        
        Score.AddPoints(pointToAdd);
        coinPickUpSound.Play();
        Destroy(gameObject);
    }
}
