using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotProductionManager : MonoBehaviour
{
    public static RobotProductionManager instance;

    private RobotPartCard _selectedPart;

    Dictionary<Robot.RobotTeam, RobotMovement> selectedMovement;
    Dictionary<Robot.RobotTeam, RobotDamager> selectedDamager;

    [SerializeField] List<GameObject> lanes;

    Dictionary<Robot.RobotTeam, int> cursorPositions;

    Dictionary<Robot.RobotTeam, Robot> curRobots;

    void Awake ()
    {
        instance = this;

        selectedMovement = new Dictionary<Robot.RobotTeam, RobotMovement>();
        selectedDamager = new Dictionary<Robot.RobotTeam, RobotDamager>();

        cursorPositions = new Dictionary<Robot.RobotTeam, int>();
        cursorPositions.Add(Robot.RobotTeam.Left, 0);
        cursorPositions.Add(Robot.RobotTeam.Right, 0);

        curRobots = new Dictionary<Robot.RobotTeam, Robot>();
        curRobots.Add(Robot.RobotTeam.Left, null);
        curRobots.Add(Robot.RobotTeam.Right, null);
    }

    public void SelectPart (Robot.RobotTeam team, RobotPartCard p_part)
    {
        if (_selectedPart == null)
        {
            p_part.Select();
            _selectedPart = p_part;
        }
        else if (_selectedPart == p_part)
        {
            p_part.Deselect();
            _selectedPart = null;
        }
        else 
        {
            CompareParts(team, p_part, _selectedPart);
            _selectedPart = null;
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
            curRobots[team] = Robot.SpawnRobot(rm, rd, robotPos, team);

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
        cursorPositions[team] = (cursorPositions[team] + lanes.Count - 1) % lanes.Count;
        UpdateRobotPositions();
    }

    void CursorDown(Robot.RobotTeam team)
    {
        cursorPositions[team] = (cursorPositions[team] + lanes.Count + 1) % lanes.Count;
        UpdateRobotPositions();
    }

    void UpdateRobotPositions()
    {
        UpdateRobotPosition(Robot.RobotTeam.Left);
        UpdateRobotPosition(Robot.RobotTeam.Right);
    }

    void UpdateRobotPosition(Robot.RobotTeam team)
    {
        Robot curRobot = curRobots[team];
        if (curRobot != null)
        {
            curRobot.transform.position = GetLaneStartPosition(team);
        }
    }

    Vector2 GetLaneStartPosition(Robot.RobotTeam team)
    {
        return (team == Robot.RobotTeam.Left ? Vector2.left : Vector2.right) * 5 + lanes[cursorPositions[team]].transform.position.y * Vector2.up;
    }

    private void ReleaseRobot(Robot.RobotTeam team)
    {
        if (curRobots[team] == null) return;

        curRobots[team].StartActivity();
        curRobots[team] = null;

        Debug.Log("Set player to part selection: " + team);
    }

    private void OnGUI()
    {
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
