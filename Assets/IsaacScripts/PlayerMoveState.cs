// Isaac Bustad
// 12/8/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMoveState 
{
    // vars
    

    // methods
    public abstract Vector2 CalcMove(Vector2 aV2, float mSpeed);
    public abstract void HasControl(PlayerMoveContext aCon);
    public abstract void NoControl(PlayerMoveContext aCon);


    public virtual void LimitSpeed(Rigidbody2D aRB, float mSpeed)
    {
        Vector2 curSpeed = new Vector2(aRB.velocity.x, aRB.velocity.y);
        if (curSpeed.magnitude > mSpeed)
        {
            Vector2 magSpeed = curSpeed.normalized;
            Vector2 newSpeed = new Vector2(magSpeed.x * mSpeed, curSpeed.y);
            aRB.velocity = newSpeed;
        }
    }


    // accessors
}
