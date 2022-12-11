// written by Grady Shupe
// 12/10/2022
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;


public class Snowball : NetworkBehaviour
{
    public PlayerScore pS;
    public int playerLayer;
    protected int damage = 1;
    public int Damage { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnCollision2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 9 || collision.gameObject.layer == 10 && collision.gameObject.layer != playerLayer)
        {
            IncreaseScore();
        }
        Debug.Log("collide");/*
        if (collision.gameObject.layer == isPlayer)
        {
            IncreaseScore(collision.gameObject.GetComponent<PlayerScore>());
        }        
        */
    }

    protected void IncreaseScore()
    {
        pS.AddScore(Damage);        
    }        


    // accessors


}
