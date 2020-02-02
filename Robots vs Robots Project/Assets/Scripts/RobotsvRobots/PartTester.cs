using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTester : MonoBehaviour
{
    const string fastMovementPartString = "FastMovement";
    GameObjectPool fastMovementPool;
    const string slowMovementPartString = "SlowMovement";
    GameObjectPool slowMovementPool;
    const string meleeDamagertPartString = "MeleeDamager";
    GameObjectPool meleeDamagerPool;
    const string rangedDamagerPartString = "RangedDamager";
    GameObjectPool rangedDamagerPool;

    Dictionary<Robot.RobotTeam, List<RobotMovement>> movementInventory;
    Dictionary<Robot.RobotTeam, List<RobotDamager>> damagerInventory;

    [SerializeField] List<GameObject> lanes;
    int cursorPosition;

    Robot curLeftRobot;
    Robot curRightRobot;

    void Awake()
    {
        fastMovementPool = PrefabManager.instance.ObjectPool(fastMovementPartString);
        slowMovementPool = PrefabManager.instance.ObjectPool(slowMovementPartString);
        meleeDamagerPool = PrefabManager.instance.ObjectPool(meleeDamagertPartString);
        rangedDamagerPool = PrefabManager.instance.ObjectPool(rangedDamagerPartString);

        movementInventory = new Dictionary<Robot.RobotTeam, List<RobotMovement>>();
        movementInventory.Add(Robot.RobotTeam.Left, new List<RobotMovement>());
        movementInventory.Add(Robot.RobotTeam.Right, new List<RobotMovement>());

        damagerInventory = new Dictionary<Robot.RobotTeam, List<RobotDamager>>();
        damagerInventory.Add(Robot.RobotTeam.Left, new List<RobotDamager>());
        damagerInventory.Add(Robot.RobotTeam.Right, new List<RobotDamager>());
    }

    void AddFastMovement(Robot.RobotTeam team)
    {
        RobotMovement rm = fastMovementPool.Spawn().GetComponentInChildren<RobotMovement>();
        rm.name = fastMovementPartString;
        rm.transform.parent.position = 3f * Vector2.down + 2f * (team == Robot.RobotTeam.Left ? Vector2.left : Vector2.right) ;
        movementInventory[team].Add(rm);

        if (movementInventory[team].Count == 1 && damagerInventory[team].Count > 0)
        {
            CraftRobot(team); 
        }
    }

    void AddSlowMovement(Robot.RobotTeam team)
    {
        RobotMovement rm = slowMovementPool.Spawn().GetComponentInChildren<RobotMovement>();
        rm.name = slowMovementPartString;
        rm.transform.parent.position = 3f * Vector2.down + 2f * (team == Robot.RobotTeam.Left ? Vector2.left : Vector2.right);
        movementInventory[team].Add(rm);

        if (movementInventory[team].Count == 1 && damagerInventory[team].Count > 0)
        {
            CraftRobot(team);
        }
    }

    void AddMeleeDamager(Robot.RobotTeam team)
    {
        RobotDamager rd = meleeDamagerPool.Spawn().GetComponentInChildren<RobotDamager>();
        rd.name = meleeDamagertPartString;
        rd.transform.parent.position = 3f * Vector2.down + 2f * (team == Robot.RobotTeam.Left ? Vector2.left : Vector2.right);
        damagerInventory[team].Add(rd);

        if (damagerInventory[team].Count == 1 && movementInventory[team].Count > 0)
        {
            CraftRobot(team);
        }
    }

    void AddRangedDamager(Robot.RobotTeam team)
    {
        RobotDamager rd = rangedDamagerPool.Spawn().GetComponentInChildren<RobotDamager>();
        rd.transform.parent.position = 2f * Vector2.down;
        rd.transform.parent.position = 3f * Vector2.down + 2f * (team == Robot.RobotTeam.Left ? Vector2.left : Vector2.right);
        damagerInventory[team].Add(rd);

        if (damagerInventory[team].Count == 1 && movementInventory[team].Count > 0)
        {
            CraftRobot(team);
        }
    }

    void CraftRobot(Robot.RobotTeam team)
    {
        Vector2 robotPos = GetLaneStartPosition(team);
        RobotMovement m = movementInventory[team][0];
        RobotDamager d = damagerInventory[team][0];

        Robot r = Robot.SpawnRobot(m, d, robotPos, team);

        if (team == Robot.RobotTeam.Left)
        {
            curLeftRobot = r;
        }
        else
        {
            curRightRobot = r;
        }
    }
    
    private void SpawnAsLeft()
    {
        if (curLeftRobot == null) return;

        curLeftRobot.StartActivity();
        curLeftRobot = null;

        SpawnQueueCheck(Robot.RobotTeam.Left);
    }

    private void SpawnAsRight()
    {
        if (curRightRobot == null) return;

        curRightRobot.StartActivity();
        curRightRobot = null;

        SpawnQueueCheck(Robot.RobotTeam.Right);
    }

    private void SpawnQueueCheck(Robot.RobotTeam team)
    {
movementInventory[team].RemoveAt(0);
        damagerInventory[team].RemoveAt(0);

        if (movementInventory[team].Count > 0 && damagerInventory[team].Count > 0)
        {
            CraftRobot(team);
        }
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 140, 160), "Spawn Parts Left");

        if (GUI.Button(new Rect(20, 40, 120, 20), "Fast Movement"))
        {
            AddFastMovement(Robot.RobotTeam.Left);
        }

        if (GUI.Button(new Rect(20, 70, 120, 20), "Slow Movement"))
        {
            AddSlowMovement(Robot.RobotTeam.Left);
        }

        if (GUI.Button(new Rect(20, 100, 120, 20), "Melee Damager"))
        {
            AddMeleeDamager(Robot.RobotTeam.Left);
        }

        if (GUI.Button(new Rect(20, 130, 120, 20), "Ranged Damager"))
        {
            AddRangedDamager(Robot.RobotTeam.Left);
        }

        GUI.Box(new Rect(170, 10, 140, 160), "Spawn Parts Right");

        if (GUI.Button(new Rect(180, 40, 120, 20), "Fast Movement"))
        {
            AddFastMovement(Robot.RobotTeam.Right);
        }

        if (GUI.Button(new Rect(180, 70, 120, 20), "Slow Movement"))
        {
            AddSlowMovement(Robot.RobotTeam.Right);
        }

        if (GUI.Button(new Rect(180, 100, 120, 20), "Melee Damager"))
        {
            AddMeleeDamager(Robot.RobotTeam.Right);
        }

        if (GUI.Button(new Rect(180, 130, 120, 20), "Ranged Damager"))
        {
            AddRangedDamager(Robot.RobotTeam.Right);
        }

        GUI.Box(new Rect(330, 10, 140, 90), "Choose Lane");

        if (GUI.Button(new Rect( 340, 40, 120,20), "lane up"))
        {
            CursorUp();
        }

        if (GUI.Button(new Rect( 340, 70, 120, 20), "lane down"))
        {
            CursorDown();
        }

        GUI.Box(new Rect(480, 10, 120, 90), "Spawns");

        if (GUI.Button(new Rect(490, 40, 100, 20), "Spawn as Left"))
        {
            SpawnAsLeft();
        }

        if (GUI.Button(new Rect(490, 70, 100, 20), "Spawn as Right"))
        {
            SpawnAsRight();
        }
    }

    void CursorUp()
    {
        cursorPosition = (cursorPosition + lanes.Count - 1) % lanes.Count;
        UpdateRobotPositions();
    }

    void CursorDown()
    {
        cursorPosition = (cursorPosition + lanes.Count + 1) % lanes.Count;
        UpdateRobotPositions();
    }

    void UpdateRobotPositions()
    {
        if (curLeftRobot != null)
        {
            curLeftRobot.transform.position = GetLaneStartPosition(Robot.RobotTeam.Left);
        }
        if (curRightRobot != null)
        {
            curRightRobot.transform.position = GetLaneStartPosition(Robot.RobotTeam.Right);
        }
    }

    Vector2 GetLaneStartPosition(Robot.RobotTeam team)
    {
        return (team == Robot.RobotTeam.Left ? Vector2.left : Vector2.right) * 5 + lanes[cursorPosition].transform.position.y * Vector2.up;
    }
}
