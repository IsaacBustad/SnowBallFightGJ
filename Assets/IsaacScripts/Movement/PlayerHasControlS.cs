// Isaac Bustad
// 12/9/2022


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHasControlS : PlayerMoveState
{
    // vars


    // methods
    

    public override Vector2 CalcMove(Vector2 aV2, float mSpeed)
    {
        return aV2;
        
    }
    public override void HasControl(PlayerMoveContext aCon)
    {
        
    }
    public override void NoControl(PlayerMoveContext aCon)
    {
        aCon.PC = aCon.NC;
    }

    // accessors
}
