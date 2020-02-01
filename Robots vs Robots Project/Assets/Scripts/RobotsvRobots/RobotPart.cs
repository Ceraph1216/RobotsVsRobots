using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class RobotPart : MonoBehaviour
{
    protected Animator myAnim;
    protected Robot myRobot;

    void Awake()
    {
        myRobot = GetComponentInParent<Robot>();
        myAnim = GetComponent<Animator>();
    }

    public virtual void RegisterWithRobot(Robot myRobot)
    {
        this.myRobot = myRobot;
    }


    public void Freeze()
    {
        myAnim.SetTrigger("Freeze");
    }
}
