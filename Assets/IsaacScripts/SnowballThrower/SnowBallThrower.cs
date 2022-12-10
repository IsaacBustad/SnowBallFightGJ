// Isaac Busatd
// 12/10/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.InputSystem;

public class SnowBallThrower : MonoBehaviour
{
    // vars
    [SerializeField] protected GameObject snowBall;
    [SerializeField] protected GameObject snowBall2;
    [SerializeField] protected GameObject snowBall3;

    [SerializeField] protected float throwBase = 10f;
    [SerializeField] protected float throwCurPow;


    // methods
    protected virtual void FixedUpdate()
    {

    }

    protected virtual void ThrowSnow1(InputAction.CallbackContext context)
    {
        
        if (context.started)
        {
            throwCurPow = throwBase;
        }
        else if (context.canceled)
        {
            GameObject aSB = Instantiate(snowBall, transform.position, Quaternion.identity);
        }
    }

    protected virtual void ThrowSnow2(InputAction.CallbackContext context)
    {

        if (context.started)
        {
            throwCurPow = throwBase;
        }
        else if (context.canceled)
        {
            GameObject aSB = Instantiate(snowBall, transform.position, Quaternion.identity);
        }
    }

    protected virtual void ThrowSnow3(InputAction.CallbackContext context)
    {

        if (context.started)
        {
            throwCurPow = throwBase;
        }
        else if (context.canceled)
        {
            GameObject aSB = Instantiate(snowBall, transform.position, Quaternion.identity);
        }
    }



    // accessors



}
