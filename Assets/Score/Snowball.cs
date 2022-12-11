// written by Grady Shupe
// 12/10/2022
using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Snowball : MonoBehaviour
{
    //public PlayerScore pS;
    //public int playerLayer;
    [SerializeField] protected float damage = 10;
    public SoundManager soundManager;
    public int Damage { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        if (collision.gameObject.layer == 10) 
        {
            Debug.Log("layer");
            collision.gameObject.GetComponent<Health>().TakeDammage(damage);
            Debug.Log("damage");
            soundManager.SnowBalLSoundEffect();
            Destroy(gameObject);
        }
        soundManager.SnowBalLSoundEffect();
        Destroy(gameObject);

        /*if(collision.gameObject.layer == 9 || collision.gameObject.layer == 10 && collision.gameObject.layer != playerLayer)
        {
            IncreaseScore();
        }
        Debug.Log("collide");*//*
        if (collision.gameObject.layer == isPlayer)
        {
            IncreaseScore(collision.gameObject.GetComponent<PlayerScore>());
        }        
        */
    }

    /*protected void IncreaseScore()
    {
        pS.AddScore(Damage);        
    }       */ 


    // accessors


}
