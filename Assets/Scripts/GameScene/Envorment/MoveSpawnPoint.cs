using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawnPoint : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            speed = speed * -1;
        }
    }
}
