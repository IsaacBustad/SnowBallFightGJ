using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] protected float timeBetween = 10;
    protected float sinceLast = 0;

    // methods
    protected virtual void FixedUpdate()
    {
        sinceLast += Time.fixedDeltaTime;
        if(sinceLast >= timeBetween)
        {
            SpawnerEnemy();
        }
    }
    public void SpawnerEnemy()
    {
        GameObject aEnem = Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
