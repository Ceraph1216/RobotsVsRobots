﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AssetBundleManifest : MonoBehaviour
{
	public static string[] bundleNames = 
	{
		"Effects",
		"Molecules",
		"Snake",
		"UI",
        "RobotsVsRobots"
	};

	public static string[][] assetNames = 
	new string[][]
   	{
		new string []
		{
			"scoreEffect"
		},
		new string[]
		{
			"CO2",
			"Glucose",
			"H2O",
			"Light",
			"Wrong"
		},
		new string[]
		{
			"Follower",
			"Pickup"
		},
		new string[]
		{
			"Answer",
			"MatchCard"
		},
        new string[]
        {
            "FastMovement",
            "SlowMovement",
            "MeleeDamager",
            "RangedDamager",
            "RobotEntity"
        }
    };
}