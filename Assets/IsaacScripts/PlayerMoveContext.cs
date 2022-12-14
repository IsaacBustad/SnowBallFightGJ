// Isaac Bustad
// 12/8/2022

// on character with controler
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveContext : MonoBehaviour
{
    // vars
    protected PlayerMoveState pC = null;
    protected PlayerHasControlS hC = new PlayerHasControlS();
    protected PlayerNoControlS nC = new PlayerNoControlS();

    protected Rigidbody2D rb; 
    [SerializeField] protected float maxMoveSpeed = 10f;
    protected Vector2 moveAmt = new Vector2();
    protected Camera mainCam;

    [SerializeField] SoundManager soundManager;
    [SerializeField] float timeTo = 10f;
    protected float timeSince = 0;

    // methods
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        pC = hC;

        mainCam = Camera.main;
    }

    

    protected virtual void FixedUpdate()
    {
        MovePlayer();
        //Vector3 worldPos = mainCam.ScreenToWorldPoint(Mouse.current.position);
        //Ray ray = mainCam.ScreenPointToRay(Mouse.current.position.ReadValue());
        
        /*if(Physics.Raycast(ray: ray, hitInfo: out RaycastHit hit) && hit.collider)
        {
            Debug.Log("hit");
            Vector2 rot = hit.point - transform.position;
            rot.y = transform.position.y;
            

            transform.LookAt(rot);
        }*/
    }

    protected void MovePlayer()
    {
        moveAmt.y = 0;
        rb.AddForce(moveAmt * 50, ForceMode2D.Force);
        PC.LimitSpeed(rb, maxMoveSpeed);
    }

    public virtual void CalcMove(InputAction.CallbackContext context)
    {        
        Vector2 aV2 = context.ReadValue<Vector2>();

        moveAmt = pC.CalcMove(aV2, maxMoveSpeed);
    }

    public virtual void HasControl()
    {
        pC.HasControl(this);
    }
    public virtual void NoControl()
    {
        pC.HasControl(this);
    }

    protected virtual void LimitSpeed()
    {
        Vector2 curSpeed = new Vector2(rb.velocity.x, rb.velocity.y);
        if(curSpeed.magnitude > .5f)
        {
            
                soundManager.RunSoundEffect();
            
        }
        if (curSpeed.magnitude > maxMoveSpeed)
        {
            if (timeSince >= timeTo)
            {
                soundManager.RunSoundEffect();
            }
            else { timeSince += Time.fixedDeltaTime; }
            Vector2 magSpeed = curSpeed.normalized;
            Vector2 newSpeed = new Vector2(magSpeed.x * maxMoveSpeed, 0f);
            rb.velocity = newSpeed;
        }
        
    }
    // accessors
    public PlayerMoveState PC { get { return pC; } set { pC = value; } }
    public PlayerHasControlS HC { get { return hC; } }
    public PlayerNoControlS NC { get { return nC; } }
}
