using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(ParticleSystem))]
public class Robot : MonoBehaviour
{
    [SerializeField] int health;
    public int Health { get { return health; } private set { health = value; } }

    [SerializeField] float deathDelay;


    [SerializeField] int maxHealth;

    Rigidbody2D rb2d;
    public Rigidbody2D Rb2d { get { return rb2d; } private set { rb2d = value; } }

    Collider2D myColl;

    ParticleSystem particles;

    [SerializeField] RobotDamager myDamager;
    public RobotDamager Damager { get { return myDamager; } private set { myDamager = value; } }

    [SerializeField] RobotMovement myMovement;
    public RobotMovement Movement { get { return myMovement; } private set { myMovement = value; } }

    [SerializeField] bool isDying;
    public bool IsDying { get { return isDying; } private set { isDying = value; SetIsDying(value); } }

    [SerializeField] bool canDealDamage;
    public bool CanDealDamage { get { return canDealDamage; } private set { canDealDamage = value; } }


    [System.Serializable]
    public enum RobotTeam
    {
        Left,
        Right
    }

    [SerializeField] RobotTeam team;
    public RobotTeam Team { get { return team; } set { team = value; } }


    const string robotEntityString = "RobotEntity";
    static GameObjectPool robotEntityPool;
    

    public void BeginPlay()
    {
        health = maxHealth;
        isDying = false;
        CanDealDamage = false;

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0f;

        particles = GetComponent<ParticleSystem>();


        myColl = GetComponent<Collider2D>();
        myColl.isTrigger = true;
        myColl.enabled = false;

        tag = "robot";

        myDamager = GetComponentInChildren<RobotDamager>();
        myDamager.RegisterWithRobot(this);

        myMovement = GetComponentInChildren<RobotMovement>();
        myMovement.RegisterWithRobot(this);

        if (team == RobotTeam.Left) transform.rotation = Quaternion.LookRotation(Vector3.back);
    }

    public void StartActivity()
    {
        canDealDamage = true;
        myColl.enabled = true;
        StartMoving();
    }

    public void ReduceHealth(int reduceAmount)
    {
        Debug.Log("robot of type: "+ myDamager.myDamageType + " losing health by: " + reduceAmount);
        this.health = Mathf.Max(0, health - reduceAmount);


        if (this.health == 0)
        {
            StartCoroutine(DelayDeath());
        }
    }

    private IEnumerator DelayDeath()
    {
        isDying = true;
        particles.Play();

        myMovement.Freeze();
        myDamager.Freeze();

        yield return null;
        yield return null;


        canDealDamage = false;
        yield return new WaitForSeconds(deathDelay);

        FreeParts();

        robotEntityPool.Unspawn(gameObject);
    }

    private void FreeParts()
    {
        myDamager.ClearTargeting();
        myDamager.transform.parent.SetParent(null);
        PrefabManager.instance.ObjectPool(myDamager.name).Unspawn(myDamager.transform.parent.gameObject);

        myMovement.transform.parent.SetParent(null);
        PrefabManager.instance.ObjectPool(myMovement.name).Unspawn(myMovement.transform.parent.gameObject);
    }

    public static Robot SpawnRobot(RobotMovement rm, RobotDamager rd, Vector3 position, RobotTeam team)
    {
        if (robotEntityPool == null) robotEntityPool = PrefabManager.instance.ObjectPool(robotEntityString);
        GameObject robotGO = robotEntityPool.Spawn();

        Robot r = robotGO.GetComponent<Robot>();
        r.transform.position = position;
        r.Team = team;

        rm.transform.parent.position = Vector2.zero;
        rm.transform.parent.SetParent(robotGO.transform, false);

        rd.transform.parent.position = Vector2.zero;
        rd.transform.parent.SetParent(robotGO.transform, false);

        r.BeginPlay();
        return r;
    }

    public void SetHasTarget(bool hasTarget)
    {
        myDamager.SetHasTarget(hasTarget);
        myMovement.SetHasTarget(hasTarget);
    }

    public void SetIsDying(bool isDying)
    {
        myDamager.SetIsDying(isDying);
        myMovement.SetIsDying(isDying);
    }

    public void StartMoving()
    {
        myMovement.StartMoving();
    }
}
