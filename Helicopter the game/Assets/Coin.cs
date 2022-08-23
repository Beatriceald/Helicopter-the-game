using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject DieEffectPrefab;

    public void Die()
    {
        Instantiate(DieEffectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
