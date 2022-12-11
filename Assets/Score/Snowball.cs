// written by Grady Shupe
// 12/10/2022
using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Snowball : MonoBehaviour
{
    
    [SerializeField] protected int damage = 1;
    public int Damage { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide");/*
        if (collision.gameObject.layer == isPlayer)
        {
            IncreaseScore(collision.gameObject.GetComponent<PlayerScore>());
        }        
        */
    }

    protected void IncreaseScore(Score aScore)
    {
        aScore.AddScore(Damage);        
    }        
}
