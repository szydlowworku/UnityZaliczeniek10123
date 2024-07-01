using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CollectibleScript player = collision.gameObject.GetComponent<CollectibleScript>();
            if (player != null)
            {
                player.AddCollectible(value);
            }

            Destroy(gameObject);
        }
    }
}