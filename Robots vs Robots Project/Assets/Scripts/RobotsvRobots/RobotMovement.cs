using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class RobotMovement : RobotPart
{
    [SerializeField] bool isMoving;
    [SerializeField] float moveSpeed;
  

    private void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    public void StartAttacking()
    {
        myAnim.SetTrigger("StartAttacking");
    }

    public void StartMoving()
    {
        if (myRobot.IsDying) return;
        myAnim.SetTrigger("StartMoving");
        myRobot.Damager.StartMoving();

        isMoving = true;
        float absoluteMoveSpeed = myRobot.Team == Robot.RobotTeam.Left ? moveSpeed : -moveSpeed;
        myRobot.Rb2d.velocity = Vector2.right * absoluteMoveSpeed;
    }

    public void StopMoving()
    {
        isMoving = false;
        myRobot.Rb2d.velocity = Vector2.zero;
    }

    public override void Freeze()
    {
        base.Freeze();
        StopMoving();
    }
}
