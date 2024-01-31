using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(bulletPrefab, spawn.position, spawn.rotation);
    }

}
