using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMoveBack : MonoBehaviour
{
    public float speed;

    private  SpriteRenderer spr;

    private void Start()
    {
        spr = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            speed = speed * -1;
            spr.flipX = !spr.flipX;
        }
    }
}
