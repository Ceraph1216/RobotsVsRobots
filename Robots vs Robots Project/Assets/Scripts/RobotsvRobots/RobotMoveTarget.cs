using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class RobotMoveTarget : MonoBehaviour
{
    Collider2D myColl;
    [SerializeField] private Robot.RobotTeam myTeam;

    private void Awake()
    {
        myColl = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("robot")) return;

        Robot robot = collision.GetComponent<Robot>();
        if (robot == null || robot.Team == myTeam) return;

        DamageMyTeam();
        robot.ReduceHealth(robot.Health);
    }

    private void DamageMyTeam()
    {
        RobotProductionManager.TakeDamage(myteam);
    }
}

