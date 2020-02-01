using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : RobotPart
{
    [SerializeField] bool isMoving;
    [SerializeField] float moveSpeed;

    private void Start()
    {
        if (myRobot != null)
        {
            StartMoving();
        }
    }

    public void StartMoving()
    {
        isMoving = true;
        float absoluteMoveSpeed = myRobot.Team == Robot.RobotTeam.Left ? moveSpeed : -moveSpeed;
        myRobot.Rb2d.velocity = Vector2.right * absoluteMoveSpeed;
    }

    public void StopMoving()
    {
        isMoving = false;
        myRobot.Rb2d.velocity = Vector2.zero;
    }

    public override void RegisterWithRobot(Robot r)
    {
        base.RegisterWithRobot(r);
        StartMoving();
    }
}
