using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPlayer : ScriptableObject
{

    public RobotMovement selectedMovement;
    public RobotDamager selectedDamager;

    public int cursorPosition;

    public Robot curRobot;

    public List<int> recentPRNGResults;

    public int health;


    public RobotPlayer()
    {
        recentPRNGResults = new List<int>();
    }
}
