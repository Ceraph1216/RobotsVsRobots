using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RobotMovement))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(RobotDamage))]
public class Robot : MonoBehaviour
{
    public int health;
    public int maxHealth;

    RobotDamage myRobotDamage;

    public bool isDying;

    [System.Serializable]
    public enum RobotTeam
    {
        Left,
        Right
    }

    public RobotTeam team;

    public void Awake()
    {
        health = maxHealth;
        myRobotDamage = GetComponent<RobotDamage>();
    }

    public void ReduceHealth(int reduceAmount)
    {
        Debug.Log("robot of type: "+ myRobotDamage.myDamageType + " losing health by: " + reduceAmount);
        this.health = Mathf.Max(0, health - reduceAmount);


        if (this.health == 0)
        {
            isDying = true;
            StartCoroutine(DelayDeath());
        }
    }

    private IEnumerator DelayDeath()
    {
        yield return new WaitForSeconds(0.1f);
        
        Destroy(gameObject);
    }
}
