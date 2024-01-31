using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Trigger : MonoBehaviour
{
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
        }
        else if (spriteRenderer.flipX)
        {
            spriteRenderer.flipX = false;
        }
    }

}
