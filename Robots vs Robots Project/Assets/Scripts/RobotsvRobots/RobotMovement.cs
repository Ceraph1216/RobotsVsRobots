using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RobotDamage))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Robot))]
public class RobotMovement : MonoBehaviour
{
    public Robot myRobot;
    public Rigidbody2D rb2d;

    public bool isMoving;
    public float moveSpeed;

    private void Awake()
    {
        myRobot = GetComponent<Robot>();
        rb2d = GetComponent<Rigidbody2D>();

        StartMoving();
    }

    public void StartMoving()
    {
        float absoluteMoveSpeed = myRobot.team == Robot.RobotTeam.Left ? moveSpeed : -moveSpeed;
        rb2d.velocity = Vector2.right * absoluteMoveSpeed;
    }

    public void StopMoving()
    {
        rb2d.velocity = Vector2.zero;
    }
}
