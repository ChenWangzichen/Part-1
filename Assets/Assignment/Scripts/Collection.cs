using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public GameObject collection;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collection.SetActive(false);
    }
}
