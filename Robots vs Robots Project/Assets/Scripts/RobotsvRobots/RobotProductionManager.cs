﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotProductionManager : MonoBehaviour
{
    public static RobotProductionManager instance;

    [SerializeField] private float spawnTime;
    [SerializeField] private PartSpawn[] possibleSpawns;
    [SerializeField] private RobotPartCard[] cardGridP1;
    [SerializeField] private RobotPartCard[] cardGridP2;

    private RobotPartCard _selectedPartP1;
    private RobotPartCard _selectedPartP2;
    private float _currentSpawnTimeP1;
    private float _currentSpawnTimeP2;

    [SerializeField] List<GameObject> lanes;

    [SerializeField] float leftSpawnX;
    [SerializeField] float rightSpawnX;

    [SerializeField] Dictionary<Robot.RobotTeam, RobotPlayer> players;

    void Awake ()
    {
        instance = this;

        players = new Dictionary<Robot.RobotTeam, RobotPlayer>();
        players.Add(Robot.RobotTeam.Left, new RobotPlayer());
        players.Add(Robot.RobotTeam.Right, new RobotPlayer());
    }

    void Update ()
    {
        if (_currentSpawnTimeP1 >= spawnTime)
        {
            if (SpawnCard(cardGridP1))
            {
                _currentSpawnTimeP1 = 0;
            }
        }

        if (_currentSpawnTimeP2 >= spawnTime)
        {
            if (SpawnCard(cardGridP2))
            {
                _currentSpawnTimeP2 = 0;
            }
        }

        _currentSpawnTimeP1 += Time.deltaTime;
        _currentSpawnTimeP2 += Time.deltaTime;
    }

    private bool SpawnCard (RobotPartCard[] cardGrid)
    {
        for (int i = 0; i < cardGrid.Length; i++)
        {
            RobotPartCard l_currentCard = cardGrid[i];
            if (l_currentCard.isAvailable)
            {
                PartSpawn l_randomSpawn = possibleSpawns[(int)GetPRNGPartNumber(Robot.RobotTeam.Left)];
                l_currentCard.Populate(l_randomSpawn.partIcon, l_randomSpawn.prefabToSpawn, l_randomSpawn.partType);
                return true;
            }
        }
        return false;
    }

    public void SelectPart (Robot.RobotTeam team, RobotPartCard p_part)
    {
        if (team == Robot.RobotTeam.Left)
        {
            if (_selectedPartP1 == null)
            {
                p_part.Select();
                _selectedPartP1 = p_part;
            }
            else if (_selectedPartP1 == p_part)
            {
                p_part.Deselect();
                _selectedPartP1 = null;
            }
            else 
            {
                CompareParts(team, p_part, _selectedPartP1);
                _selectedPartP1 = null;
            }
        } else 
        {
            if (_selectedPartP2 == null)
            {
                p_part.Select();
                _selectedPartP2 = p_part;
            }
            else if (_selectedPartP2 == p_part)
            {
                p_part.Deselect();
                _selectedPartP2 = null;
            }
            else 
            {
                CompareParts(team, p_part, _selectedPartP2);
                _selectedPartP2 = null;
            }
        }
        
    }

    private void CompareParts (Robot.RobotTeam team, RobotPartCard p_part1, RobotPartCard p_part2)
    {
        if (p_part1.partType != p_part2.partType)
        {
            Debug.Log("That's a bingo!");

            RobotPart part1 = p_part1.SpawnPart();
            RobotPart part2 = p_part2.SpawnPart();

            RobotDamager rd = part1 as RobotDamager;
            RobotMovement rm;

            if (rd == null)
            {
                rd = part2 as RobotDamager;
                rm = part1 as RobotMovement;
            }
            else
            {
                rm = part2 as RobotMovement;
            }


            Vector2 robotPos = GetLaneStartPosition(team);
            players[team].curRobot = Robot.SpawnRobot(rm, rd, robotPos, team);

            p_part1.OnMatch();
            p_part2.OnMatch();
        }
        else 
        {
            Debug.Log("Those parts are the same type, try again");
            p_part1.Deselect();
            p_part2.Deselect();
        }

    }

    void CursorUp(Robot.RobotTeam team)
    {
        players[team].cursorPosition = (players[team].cursorPosition + lanes.Count - 1) % lanes.Count;
        UpdateRobotPositions();
    }

    void CursorDown(Robot.RobotTeam team)
    {
        players[team].cursorPosition = (players[team].cursorPosition + lanes.Count + 1) % lanes.Count;
        UpdateRobotPositions();
    }

    void UpdateRobotPositions()
    {
        UpdateRobotPosition(Robot.RobotTeam.Left);
        UpdateRobotPosition(Robot.RobotTeam.Right);
    }

    void UpdateRobotPosition(Robot.RobotTeam team)
    {
        Robot curRobot = players[team].curRobot;
        if (curRobot != null)
        {
            curRobot.transform.position = GetLaneStartPosition(team);
        }
    }

    Vector2 GetLaneStartPosition(Robot.RobotTeam team)
    {
        return new Vector2(team == Robot.RobotTeam.Left ? leftSpawnX : rightSpawnX, lanes[players[team].cursorPosition].transform.position.y);
    }

    private void ReleaseRobot(Robot.RobotTeam team)
    {
        if (players[team].curRobot == null) return;

        players[team].curRobot.StartActivity();
        players[team].curRobot = null;

        Debug.Log("Set player to part selection: " + team);
    }

    public float GetPRNGPartNumber(Robot.RobotTeam team)
    {
        int range = 4;
        int recentCount = 4;

        List<int> recents = players[team].recentPRNGResults;

        int result;

        if (recents.Count == recentCount)
        {
            List<int> candidates = new List<int>();
            for (int i = 0; i < range; i++)
            {
                if (!recents.Contains(i))
                {
                    candidates.Add(i);
                }
            }

            if (candidates.Count > 0)
            {
                result = candidates[Random.Range(0, candidates.Count)];
            }
            else
            {
                result = Random.Range(0, range);
            }
     
        }
        else
        {
            result = Random.Range(0, range);
        }

        recents.Add(result);
        if (recents.Count > recentCount) recents.RemoveAt(0);
         Debug.Log("PRNG result: " + result);
        return result;
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(180, 10, 140, 90), "PRNG testing");
        if (GUI.Button(new Rect(190, 40, 120, 20), "Get sample Left"))
        {
            Debug.Log("PRNG result: " + GetPRNGPartNumber(Robot.RobotTeam.Left));
        }
        if (GUI.Button(new Rect(190, 70, 120, 20), "Get sample Right"))
        {
            Debug.Log("PRNG result: " + GetPRNGPartNumber(Robot.RobotTeam.Right));
        }

        GUI.Box(new Rect(330, 10, 140, 90), "Choose Left's Lane");

        if (GUI.Button(new Rect(340, 40, 120, 20), "lane up"))
        {
            CursorUp(Robot.RobotTeam.Left);
        }

        if (GUI.Button(new Rect(340, 70, 120, 20), "lane down"))
        {
            CursorDown(Robot.RobotTeam.Left);
        }

        GUI.Box(new Rect(480, 10, 140, 90), "Choose Right's Lane");

        if (GUI.Button(new Rect(490, 40, 120, 20), "lane up"))
        {
            CursorUp(Robot.RobotTeam.Right);
        }

        if (GUI.Button(new Rect(490, 70, 120, 20), "lane down"))
        {
            CursorDown(Robot.RobotTeam.Right);
        }

        GUI.Box(new Rect(630, 10, 120, 90), "Spawns");

        if (GUI.Button(new Rect(640, 40, 100, 20), "Spawn as Left"))
        {
            ReleaseRobot(Robot.RobotTeam.Left);
        }

        if (GUI.Button(new Rect(640, 70, 100, 20), "Spawn as Right"))
        {
            ReleaseRobot(Robot.RobotTeam.Right);
        }
    }
}

[System.Serializable]
public class PartSpawn
{
    public string prefabToSpawn;
    public Sprite partIcon;
    public PartType partType;
}