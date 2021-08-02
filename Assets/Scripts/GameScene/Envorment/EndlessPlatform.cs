using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessPlatform : MonoBehaviour
{
    public Transform teleportPart;
    public Transform teleportPoint;
    Vector2 pos;

    public bool isItTeleported;
    public EndlessPlatform nextPart;
    private void Update()
    {
        if (nextPart.isItTeleported == true)
        {
            isItTeleported = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isItTeleported == false)
        {
            Debug.Log(isItTeleported);
            isItTeleported = true;
            pos = new Vector2(teleportPart.position.x, teleportPoint.position.y);
            teleportPart.position = pos;
            EnemySpawner.Instance.SpawnObject();
        }
    }


}
