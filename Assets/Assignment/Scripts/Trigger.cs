using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (spriteRenderer.flipX == false)
        {
            spriteRenderer.flipX = true;
            door1.SetActive(false);
            door2.SetActive(true);
        }
        else if (spriteRenderer.flipX)
        {
            spriteRenderer.flipX = false;
            door1.SetActive(true);
            door2.SetActive(false);
        }
    }

}
