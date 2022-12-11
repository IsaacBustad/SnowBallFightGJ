// written by Grady Shupe
// 12/10/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerScore")]

public class PlayerScore : Score
{
    // Start is called before the first frame update
    protected void Start()
    {
        maxScore = 10;
        curScore = maxScore;
    }
    public override void AddScore(int aDamage)
    {
        curScore += aDamage;
    }

    protected void WinScore()
    {
        if (curScore >= maxScore)
        {

        }
    }
    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}
