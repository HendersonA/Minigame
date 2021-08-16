using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    SpawnCoin spawnCoin;

    void Start()
    {
        spawnCoin = FindObjectOfType<SpawnCoin>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            spawnCoin.CountPoints();
            Destroy(this.gameObject);
        }
    }
}
