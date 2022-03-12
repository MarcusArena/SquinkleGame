
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class QUIIIIID : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private float movement = 0f;
    public bool IsMoving;
    public GameObject FUCK;
    public static bool HeadTimesEndOfGame;
    public GameObject god;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        ProcessInputs();


    }
    private void ProcessInputs()
    {
        movement = Input.GetAxis("Horizontal");
        if (movement > 0f)
        {
            Vector2 moveInput = new Vector2(movement * speed, rb.velocity.y);
            moveVelocity = moveInput.normalized * speed;

        }
        else if (movement < 0f)
        {
            Vector2 moveInput = new Vector2(movement * speed, rb.velocity.y);
            moveVelocity = moveInput.normalized * speed;
            //haciadondemirar.flipX = true;
        }
        else
        {
            Vector2 moveInput = new Vector2(0 * speed, rb.velocity.y);
            moveVelocity = moveInput.normalized * speed;
            //haciadondemirar.flipX = false;

        }
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        Death();


    }

    private void Death()
    {
        //  || god.getComponent(SquinkleGod).HeadTimesEndOfGame
        if (FUCK.activeSelf && IsMoving)
        {

            if (moveVelocity.x != 0)
            {
                Debug.Log("Failed!");
                Destroy(gameObject);
            }
        }

    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("GOD"))
        {
            Destroy(col.gameObject);
        }
    }

}
