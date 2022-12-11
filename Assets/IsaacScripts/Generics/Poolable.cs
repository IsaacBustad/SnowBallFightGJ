// Isaac Bustad
// 12/9/2022



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolable : MonoBehaviour
{
    // vars
    PoolGeneric<Poolable> pool;

    // methods
    protected virtual void AddToPool()
    {
        pool.AddToPool(this);
        gameObject.SetActive(false);
    }

    protected virtual void ReUse()
    {
        gameObject.SetActive(true);
    }
    // accessors



}
