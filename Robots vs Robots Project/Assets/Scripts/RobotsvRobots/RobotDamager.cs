using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class RobotDamager : RobotPart
{
    [SerializeField] Robot currentTarget;
    [SerializeField] float attackTime;

    [SerializeField] List<Robot> targetList;

    Collider2D myCollider;

    void Start()
    {
        currentTarget = null;
        targetList = new List<Robot>();
        myCollider = GetComponent<Collider2D>();

        if (myRobot == null)
        {
            myCollider.enabled = false;
        }
    }

    [System.Serializable]
    public enum DamageType{
        Rock=0,
        Paper=1,
        Scissors=2
    }

    public DamageType myDamageType;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (! collision.CompareTag("robot")) return;

        Robot otherRobot = collision.GetComponent<Robot>();
        if (otherRobot == null) return;
        if (otherRobot.IsDying || otherRobot.Team == myRobot.Team) return;
        if (currentTarget != null)
        {
            if (!targetList.Contains(currentTarget)) targetList.Add(otherRobot);
            return;
        }
        else
        {
            StartAttacking(otherRobot);
        }
            
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        OnTriggerEnter2D(collision);
    }

    void StartAttacking(Robot otherRD)
    {

        Debug.Log("robot of type: " + myDamageType + " attacking");
        currentTarget = otherRD;

        myRobot.Movement.StopMoving();

        StartCoroutine(DoAttack());
    }

    IEnumerator DoAttack()
    {
        yield return new WaitForSeconds(attackTime);
        if (currentTarget == null || currentTarget.IsDying)
        {
            Retarget();
            yield break;
        }

        int damageAgainst = DamageVs(currentTarget);

        currentTarget.ReduceHealth(damageAgainst);
        
        if (currentTarget.IsDying)
        {
            Retarget();
        }
        else 
        {
            yield return null;
            if (!myRobot.IsDying) yield return DoAttack();
        }
    }

    void Retarget()
    {
        while (targetList.Count > 0)
        {
            Robot candidateRobot = targetList[0];
            if (candidateRobot == null | candidateRobot.IsDying)
            {
                targetList.RemoveAt(0);
            }
            else
            {
                StartAttacking(candidateRobot);
                return;
            }
        }

        myRobot.Movement.StartMoving();
        currentTarget = null;
    }

    protected virtual int DamageVs(Robot other)
    {

        /*
        if ((int)myDamageType == (int)other.myDamageType) return 2; // same
        Debug.Log("my type: " + (int)myDamageType + " other type: " + (int)other.myDamageType);
        if (((int)myDamageType + 1) % 3 == (int)other.myDamageType) return 1; // weak
        Debug.Log("returning 3");
        return 3; // strong
        */

        return 2;
    }

    public override void RegisterWithRobot(Robot r)
    {
        base.RegisterWithRobot(r);
        myCollider.enabled = true;
    }
}
