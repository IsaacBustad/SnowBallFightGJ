using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float maxHealth = 100f;
    [SerializeField] protected float curHealth;


    // functions

    public virtual void TakeDammage(float aDammage)
    {
        curHealth -= aDammage;
        if(curHealth <= 0)
        {
            EndAct();
        }
    }

    protected virtual void EndAct()
    {
        Destroy(gameObject);
    }
}
