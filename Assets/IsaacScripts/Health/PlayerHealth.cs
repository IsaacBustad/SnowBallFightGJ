using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{


    protected GameObject snowmanPartA;
    protected GameObject snowmanPartB;
    protected GameObject snowmanPartC;


    protected void ShowSnowman()
    {
        if (curHealth / maxHealth >= maxHealth * 0.25)
        {
            // set first part layer active
            snowmanPartA.SetActive(true);

        }
        else if (
            curHealth / maxHealth <= maxHealth * 0.5)
        {
            // set first part layer active            
            snowmanPartA.SetActive(true);
            // set second part layer active
            snowmanPartB.SetActive(false);
        }
        else if (curHealth / maxHealth <= maxHealth * 0.75)
        {
            // set first part layer active
            snowmanPartA.SetActive(true);
            // set second part layer active
            snowmanPartB.SetActive(true);
            // set third part layer active            
            snowmanPartC.SetActive(false);
        }

    }

    public override void TakeDammage(float aDammage)
    {
        curHealth -= aDammage;
        if (curHealth <= 0)
        {
            EndAct();
        }
        ShowSnowman();
    }
    
    protected override void EndAct()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
