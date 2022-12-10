// Isaac Bustad
// 10/22/2022
// Added here by Grady Shupe
// 12/10/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Score")]
public abstract class Score : ScriptableObject
{
    // vars
    protected int scorePoints = 0;
    [SerializeField] protected int maxScore = 10;
    protected int curScore = 0;

    public int ScorePoints
    {
        get { return scorePoints; }
        set { if (scorePoints + value < 0) { scorePoints = 0; } else { scorePoints += value; } }
    }

    // functions
    public abstract void AddScore(int aDamage);

    // accessors
    public int MaxScore
    {
        get { return maxScore; }
        set { maxScore = value; }
    }
    public int CurScore
    {
        get { return curScore; }
        set { curScore = value; }
    }
}
