using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float XAxisInput;
    private float YAxisInput;
    public float MoveSpeed;
    public float JumpForce;
    public bool isJumping = false;

    void OnEnable()
    {
       
       rb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        XAxisInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(XAxisInput * MoveSpeed, 0, 0);


        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && !isJumping)
        {
            rb2d.velocity = new Vector3(0, 10, 0);
            isJumping = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isJumping = false;
        }

        Debug.Log("colliding");
    }

}
