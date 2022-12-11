// Isaac Bustad
// 12/9/2022


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNoControlS : PlayerMoveState
{
    // vars


    // methods
    public override Vector2 CalcMove(Vector2 aV2, float mSpeed)
    {
        return Vector2.zero;
    }

    public override void HasControl(PlayerMoveContext aCon)
    {
        aCon.PC = aCon.HC;
    }
    public override void NoControl(PlayerMoveContext aCon)
    {

    }

    // accessors



}
