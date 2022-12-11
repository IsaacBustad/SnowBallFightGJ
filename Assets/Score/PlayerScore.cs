// written by Grady Shupe
// 12/10/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScore : Score
{
    public Snowman playerSnowman;
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
