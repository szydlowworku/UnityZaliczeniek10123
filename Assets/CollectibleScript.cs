
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    private int collectiblesCount = 0;

    public void AddCollectible(int value)
    {
        collectiblesCount += value;
        Debug.Log("Collectibles: " + collectiblesCount);
    }

    void Update()
    {
        Debug.Log(collectiblesCount);
    }

    public int CollectiblesCount()
    {
        return collectiblesCount;
    }
}
