using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // vars
    [SerializeField] protected float dammage = 10f;
    [SerializeField] protected float movespeed = 5;

    // methods
    protected void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.fixedDeltaTime * movespeed);
    }
    protected void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth pH = collision.gameObject.GetComponent<PlayerHealth>();
        if (pH != null)
        {
            pH.TakeDammage(dammage);
        }
    }


    // accessors
}
