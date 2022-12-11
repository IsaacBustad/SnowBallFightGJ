// written by Grady Shupe
// 12/10/2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Snowman : NetworkBehaviour
{
    [SerializeField]protected PlayerScore pScore;
    protected GameObject snowmanPartA;
    protected GameObject snowmanPartB;
    protected GameObject snowmanPartC;

    protected void ShowSnowman()
    {
        if (pScore.CurScore / pScore.MaxScore >= pScore.MaxScore * 0.25)
        {
            // set first part layer active
            SnowmanPartA.SetActive(true);
            
        }
        else if (pScore.CurScore / pScore.MaxScore >= pScore.MaxScore * 0.25 && 
            pScore.CurScore / pScore.MaxScore >= pScore.MaxScore * 0.5)
        {
            // set first part layer active            
            SnowmanPartA.SetActive(true);
            // set second part layer active
            SnowmanPartB.SetActive(true);
        }
        else if (pScore.CurScore / pScore.MaxScore >= pScore.MaxScore * 0.25 && 
            pScore.CurScore / pScore.MaxScore >= pScore.MaxScore * 0.5 && 
            pScore.CurScore / pScore.MaxScore >= pScore.MaxScore * 0.75)
        {
            // set first part layer active
            SnowmanPartA.SetActive(true);
            // set second part layer active
            SnowmanPartB.SetActive(true);
            // set third part layer active            
            SnowmanPartC.SetActive(true);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        PScore.playerSnowman = this;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
    // accessors
    public PlayerScore PScore
    {
        get { return pScore; }
        set { pScore = value; }
    }
    public GameObject SnowmanPartA
    {
        get { return snowmanPartA; }
        set { snowmanPartA = value; }
    }
    public GameObject SnowmanPartB
    {
        get { return snowmanPartB; }
        set { snowmanPartB = value; }
    }
    public GameObject SnowmanPartC
    {
        get { return snowmanPartC; }
        set { snowmanPartC = value; }
    }
}
