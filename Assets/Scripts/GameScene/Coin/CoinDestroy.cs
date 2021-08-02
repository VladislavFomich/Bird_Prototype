using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CountManager.Instance.coinCount += 1;
        Destroy(gameObject);
    }
}
