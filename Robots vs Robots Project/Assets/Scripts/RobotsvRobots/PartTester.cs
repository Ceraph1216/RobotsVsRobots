using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTester : MonoBehaviour
{
    string fastMovementPartString = "FastMovement";
    GameObjectPool fastMovementPool;
    string slowMovementPartString = "SlowMovement";
    GameObjectPool slowMovementPool;
    string meleeDamagertPartString = "MeleeDamager";
    GameObjectPool meleeDamagerPool;
    string rangedDamagerPartString = "RangedDamager";
    GameObjectPool rangedDamagerPool;

    List<RobotMovement> movementInventory;
    List<RobotDamager> damagerInventory;

    void Awake()
    {
        fastMovementPool = PrefabManager.instance.ObjectPool(fastMovementPartString);
        slowMovementPool = PrefabManager.instance.ObjectPool(slowMovementPartString);
        meleeDamagerPool = PrefabManager.instance.ObjectPool(meleeDamagertPartString);
        rangedDamagerPool = PrefabManager.instance.ObjectPool(rangedDamagerPartString);

        movementInventory = new List<RobotMovement>();
        damagerInventory = new List<RobotDamager>();
    }

    void AddFastMovement()
    {
        movementInventory.Add(fastMovementPool.Spawn().GetComponentInChildren<RobotMovement>());
    }

    void AddSlowMovement()
    {
        movementInventory.Add(slowMovementPool.Spawn().GetComponentInChildren<RobotMovement>());
    }

    void AddMeleeDamager()
    {
        damagerInventory.Add(meleeDamagerPool.Spawn().GetComponentInChildren<RobotDamager>());
    }

    void AddRangedDamager()
    {
        damagerInventory.Add(rangedDamagerPool.Spawn().GetComponentInChildren<RobotDamager>());
    }

    void Spawn(Robot.RobotTeam team)
    {
        if (movementInventory.Count == 0 || damagerInventory.Count == 0) return;

        GameObject go = new GameObject();
        go.transform.position = (team == Robot.RobotTeam.Left ? Vector2.left : Vector2.right) * 5;
        go.AddComponent<BoxCollider2D>();
        Robot r = go.AddComponent<Robot>();
        r.Team = team;

        RobotMovement m = movementInventory[0];
        movementInventory.RemoveAt(0);
        m.transform.parent.SetParent(go.transform, false);

        RobotDamager d = damagerInventory[0];
        damagerInventory.RemoveAt(0);
        d.transform.parent.SetParent(go.transform, false);

        r.BeginPlay();
    }

    private void SpawnAsLeft()
    {
        Spawn(Robot.RobotTeam.Left);
    }

    private void SpawnAsRight()
    {
        Spawn(Robot.RobotTeam.Right);
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 140, 160), "Spawn Parts");

        if (GUI.Button(new Rect(20, 40, 120, 20), "Fast Movement"))
        {
            AddFastMovement();
        }

        if (GUI.Button(new Rect(20, 70, 120, 20), "Slow Movement"))
        {
            AddSlowMovement();
        }

        if (GUI.Button(new Rect(20, 100, 120, 20), "Melee Damager"))
        {
            AddMeleeDamager();
        }

        if (GUI.Button(new Rect(20, 130, 120, 20), "Ranged Damager"))
        {
            AddRangedDamager();
        }

        GUI.Box(new Rect(160, 10, 120, 90), "Make Robot");

        if (GUI.Button(new Rect(170, 40, 100, 20), "Spawn as Left"))
        {
            SpawnAsLeft();
        }

        if (GUI.Button(new Rect(170, 70, 100, 20), "Spawn as Right"))
        {
            SpawnAsRight();
        }
    }
}
