using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject BombPrefab;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if (Random.Range(0,3) == 0)
            {
                Vector3 position = new Vector3(i, Random.Range(-15, 15), 0);
                if (Random.Range(0,3) == 0)
                {
                    Instantiate(BombPrefab, position, Quaternion.identity);
                }
                else
                {
                    Instantiate(CoinPrefab, position, Quaternion.identity);
                }

            }
        }
    }
}
