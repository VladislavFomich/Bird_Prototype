using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEnemy : MonoBehaviour
{
    public  GenerateColliders generateColliders;
    public float speed;

    private void Start()
    {
        generateColliders = CountManager.Instance.generate;
        speed = Random.Range(0.1f, 1.5f);
    }
    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RightEdge")
        {
            Vector2 pos = new Vector2(generateColliders.lefttX, transform.position.y);
            gameObject.transform.position = pos;
        } 
    }    
}
