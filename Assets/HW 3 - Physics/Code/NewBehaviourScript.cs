using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;
    
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Debug.Log("The player has gone through the trigger");
            collision.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0.0f, 1.0f)), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            //collision.GetComponent<spriteRenderer>().color = new Color(1.of, 0.0f, 0.0f);
        }
    }