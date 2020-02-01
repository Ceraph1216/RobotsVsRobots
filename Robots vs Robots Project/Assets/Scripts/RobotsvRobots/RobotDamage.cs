using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RobotMovement))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Robot))]
public class RobotDamage : MonoBehaviour
{
    Robot myRobot;
    RobotMovement myMovement;

    RobotDamage currentTarget;
    public float attackTime;

    public void Awake()
    {
        currentTarget = null;
        myRobot = GetComponent<Robot>();
        myMovement = GetComponent<RobotMovement>();
    }

    [System.Serializable]
    public enum DamageType{
        Rock=0,
        Paper=1,
        Scissors=2
    }

    public DamageType myDamageType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("0");
        if (! collision.CompareTag("robot")) return;
        Debug.Log("1");
        if (currentTarget != null) return;
        Debug.Log("2");

        RobotDamage otherRD = collision.GetComponent<RobotDamage>();
        if (otherRD == null) return;
        Debug.Log("3");
        if (otherRD.myRobot.isDying || otherRD.myRobot.team == myRobot.team) return;
        Debug.Log("4");

        StartAttacking(otherRD);
    }

    private void StartAttacking(RobotDamage otherRD)
    {

        Debug.Log("robot of type: " + myDamageType + " attacking");
        currentTarget = otherRD;

        myMovement.StopMoving();

        StartCoroutine(DoAttack());
    }

    private IEnumerator DoAttack()
    {
        yield return new WaitForSeconds(attackTime);
        if (currentTarget == null || currentTarget.myRobot.isDying) yield break;

        int damageAgainst = DamageVs(currentTarget);

        currentTarget.myRobot.ReduceHealth(damageAgainst);
        
        if (currentTarget.myRobot.isDying)
        {
            myMovement.StartMoving();
            currentTarget = null;
        }
        else
        {
            yield return DoAttack();
        }
    }

    private int DamageVs(RobotDamage other)
    {
        if ((int)myDamageType == (int)other.myDamageType) return 2; // same
        Debug.Log("my type: " + (int)myDamageType + " other type: " + (int)other.myDamageType);
        if (((int)myDamageType + 1) % 3 == (int)other.myDamageType) return 1; // weak
        Debug.Log("returning 3");
        return 3; // strong
    }
}
