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

    protected Camera cam;
    protected Vector3 mPos;

    // methods
    protected virtual void FixedUpdate()
    {

    }

    public virtual void Aim(InputAction.CallbackContext context)
    {
        //Vector3 worldPos = mainCam.ScreenToWorldPoint(Mouse.current.position);
        if(cam == null)
        {
            cam = Camera.main;
        }

        mPos = cam.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }


    public virtual void ThrowSnow1(InputAction.CallbackContext context)
    {

        if (context.started)
        {
            throwCurPow = throwBase;
        }
        else if (context.canceled)
        {

            Vector3 rot = mPos;
            rot.z = transform.position.z;

            
            GameObject aSB = Instantiate(snowBall, transform.position, Quaternion.identity);

            

            aSB.transform.LookAt(rot);
            aSB.GetComponent<Rigidbody2D>().AddForce(transform.forward * throwCurPow, ForceMode2D.Impulse);

        }

            
            
    }

    public virtual void ThrowSnow2(InputAction.CallbackContext context)
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

    public virtual void ThrowSnow3(InputAction.CallbackContext context)
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
