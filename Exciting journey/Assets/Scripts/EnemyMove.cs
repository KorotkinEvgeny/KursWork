using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

    public float moveSpeed;
    public bool isMoveRight;
    private bool isFacingRight;

    private Animator anim;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool isWallTached;

    private bool isFalling;
    //public float edgeCheckRadius;
    public Transform fallCheck;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Проверка на столкновение со стеной
        isWallTached = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        // Проверка на пустое пространство под объектом

        isFalling = Physics2D.OverlapCircle(fallCheck.position, wallCheckRadius, whatIsWall);

        if(isWallTached || !isFalling)
        {
            isMoveRight = !isMoveRight;
        }

	    if(isMoveRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (GetComponent<Rigidbody2D>().velocity.x > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (GetComponent<Rigidbody2D>().velocity.x < 0 && isFacingRight)
        {
            Flip();
        }
	}

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        //зеркально отражаем персонажа по оси Х
        theScale.x *= -1;
        //задаем новый размер персонажа, равный старому, но зеркально отраженный
        transform.localScale = theScale;
    }
}
