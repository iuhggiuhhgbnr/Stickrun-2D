using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Character_controll : MonoBehaviour
{
    private Rigidbody2D bravecookie;
    private Animator ani;
    //private float speed;
    //private float direction;
    private bool faceRight;
    float speed;
    private Vector3 localScale;
    //public float JUMP_value;
    void Start()
    {
        bravecookie = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        localScale = transform.localScale;
       
    }

    // Update is called once per frame
    void Update()
    {
        //direction = Input.GetAxis("Horizontal") * brav_speed;
        speed = Character_speed.brav_speed;

        if (CrossPlatformInputManager.GetButtonDown("Jump") && bravecookie.velocity.y == 0)
            bravecookie.AddForce(Vector2.up * Character_speed.brav_jump);

        if (Mathf.Abs(speed) > 0 && bravecookie.velocity.y == 0)
            ani.SetBool("isRunning", true);
        else
            ani.SetBool("isRunning", false);

        if(bravecookie.velocity.y == 0)
        {
            ani.SetBool("isJumping", false);
            ani.SetBool("isFalling", false);
        }

        if (bravecookie.velocity.y > 0)
        {
            ani.SetBool("isJumping", true);
        }

        if (bravecookie.velocity.y < 0)
        {
            ani.SetBool("isJumping", false);
            ani.SetBool("isFalling", true);
        }
    }


     void FixedUpdate()
    {
        //bravecookie.velocity = new Vector2(direction, bravecookie.velocity.y);
        bravecookie.velocity = new Vector2(speed, bravecookie.velocity.y);
    }

     void LateUpdate()
    {
        if (speed > 0)
            faceRight = true;

        else if (speed < 0)
            faceRight = false;

        if (((faceRight) && (localScale.x < 0)) || ((!faceRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;
    }
}
