using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPart : MonoBehaviour
{

    protected Robot myRobot;

    void Awake()
    {
        myRobot = GetComponentInParent<Robot>();
    }

    public virtual void RegisterWithRobot(Robot myRobot)
    {
        this.myRobot = myRobot;
    }
}
