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


    public RobotPlayer()
    {
        recentPRNGResults = new List<int>();
    }
}
