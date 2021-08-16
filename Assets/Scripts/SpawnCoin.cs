using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;

    public Transform[] spawns;

    public Text textUi;

    private int points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnCoinRandomly();
    }

    void SpawnCoinRandomly(){
        int randomQuantity = Random.Range(1, spawns.Length);

        for (int i = 0; i < randomQuantity; i++)
        {
            int randomPos = Random.Range(0, randomQuantity);
            
            if(spawns[i].transform.childCount == 0)
                Instantiate(coin, spawns[i].transform.position, Quaternion.identity, spawns[i].transform);
        }
    }

    public void CountPoints (){
        points++;
        textUi.text = points.ToString("000");
    }
}
