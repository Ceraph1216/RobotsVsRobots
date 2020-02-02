using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Animator))]
public class RobotDamager : RobotPart
{
    [SerializeField] Robot currentTarget;
    [SerializeField] int attackDamage;

    [SerializeField] List<Robot> targetList;

    Collider2D myCollider;

    void Start()
    {
        ClearTargeting();
    }

    protected override void Awake()
    {
        base.Awake();

        myAnim = GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>();

    }

    public void ClearTargeting()
    {
        currentTarget = null;
        targetList = new List<Robot>();

        if (myRobot == null)
        {
            myCollider.enabled = false;
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (myRobot.IsDying || !myRobot.CanDealDamage) return;
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
        currentTarget = otherRD;

        myRobot.Movement.StopMoving();

        DoAttack();
    }

    void CompleteAttack()
    {
        StartCoroutine(HandleCompleteAttack());
    }

    void DoAttack()
    {
        myRobot.SetHasTarget(true);
        myAnim.SetTrigger("StartAttacking");
        myRobot.Movement.StartAttacking();
    }

    IEnumerator HandleCompleteAttack()
    {
        if (!myRobot.CanDealDamage)
        {
            myRobot.SetHasTarget(false);
            yield break;
        }

        if (currentTarget == null || currentTarget.IsDying || !currentTarget.gameObject.activeInHierarchy)
        {
            myRobot.SetHasTarget(false);
            myAnim.ResetTrigger("StartAttacking");
            Retarget();
            yield break;
        }

        Debug.Log("not dead yet");

        int damageAgainst = DamageVs(currentTarget);

        currentTarget.ReduceHealth(damageAgainst);

        yield return null;

        if (currentTarget.IsDying || !currentTarget.gameObject.activeInHierarchy || currentTarget.IsDying)
        {
            myRobot.SetHasTarget(false);
            Retarget();
        }
        else 
        {
            if (myRobot.IsDying)
            {
                myRobot.SetHasTarget(false);
                myRobot.SetIsDying(true);
            }
            else
            {

                Debug.Log("not dead yet2");
                DoAttack();
            }
        }
    }

    void Retarget()
    {
        if (myRobot.IsDying)
        {
            myRobot.SetHasTarget(false);
            return;
        }

        while (targetList.Count > 0)
        {
            Robot candidateRobot = targetList[0];
            if (candidateRobot == null || !candidateRobot.gameObject.activeInHierarchy || candidateRobot.IsDying)
            {
                targetList.RemoveAt(0);
            }
            else
            {
                StartAttacking(candidateRobot);
                return;
            }
        }

        myRobot.StartMoving();
        myRobot.SetHasTarget(false);
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

        return attackDamage;
    }

    public override void RegisterWithRobot(Robot r)
    {
        base.RegisterWithRobot(r);
        myCollider.enabled = true;
    }

    public void StartMoving()
    {
        myAnim.SetTrigger("StartMoving");
    }
}
