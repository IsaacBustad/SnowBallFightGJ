using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // vars
    [SerializeField] protected float dammage = 10f;


    // methods
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            collision.gameObject.GetComponent<Health>().TakeDammage(dammage);
        }
    }


    // accessors
}
