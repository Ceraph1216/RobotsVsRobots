using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class RobotPart : MonoBehaviour
{
    protected Animator myAnim;
    protected Robot myRobot;

    protected virtual void Awake()
    {
        myRobot = GetComponentInParent<Robot>();
        myAnim = GetComponent<Animator>();
    }

    public virtual void RegisterWithRobot(Robot myRobot)
    {
        this.myRobot = myRobot;
    }


    public virtual void Freeze()
    {
        myAnim.SetTrigger("Freeze");
        myAnim.ResetTrigger("StartAttacking");
        myAnim.ResetTrigger("StartMoving");
    }

    public void SetHasTarget(bool hasTarget)
    {
        myAnim.SetBool("hasTarget", hasTarget);

        if (!hasTarget)
        {
            myAnim.ResetTrigger("StartAttacking");
        }
    }

    public void SetIsDying(bool isDying)
    {
        myAnim.SetBool("isDying", isDying);
        myAnim.ResetTrigger("StartAttacking");
        myAnim.ResetTrigger("StartMoving");
    }
}
