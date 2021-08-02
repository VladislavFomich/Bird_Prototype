using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPlatfotmCount : MonoBehaviour
{
    private int idPlatform;
     private void OnCollisionEnter2D(Collision2D collision)        {
         if (collision.enabled == true)
         {
            int newId = collision.collider.gameObject.GetInstanceID();
            if (newId != idPlatform)
            {
                idPlatform = newId;
                CountManager.Instance.platformCount += 1;
            }
         }
    }

}
