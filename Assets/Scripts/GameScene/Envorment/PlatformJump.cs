using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformJump : MonoBehaviour
{
    private Rigidbody2D rig
        ;
    public float jumpForce;
    public int jumpCount;
    public bool isJump;
    
    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch firstTouch = Input.GetTouch(0);
            if (firstTouch.phase == TouchPhase.Began &&  jumpCount != 0)
            {
                isJump = true;
                jumpCount--;
                Jump();
            }

        }
    }

    private void Jump()
    {
        rig.AddForce(Vector2.down * jumpForce);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
          if (collision.enabled == true)
          {
              isJump = false;
              jumpCount = 2;
          }
        }
    }
}
