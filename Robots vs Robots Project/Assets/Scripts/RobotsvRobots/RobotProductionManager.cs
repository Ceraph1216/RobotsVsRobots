using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotProductionManager : MonoBehaviour
{
    public static RobotProductionManager instance;

    private RobotPartCard _selectedPart;

    void Awake ()
    {
        instance = this;
    }

    public void SelectPart (RobotPartCard p_part)
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
            CompareParts(p_part, _selectedPart);
            _selectedPart = null;
        }
    }

    private void CompareParts (RobotPartCard p_part1, RobotPartCard p_part2)
    {
        if (p_part1.partType != p_part2.partType)
        {
            Debug.Log("That's a bingo!");
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
}
