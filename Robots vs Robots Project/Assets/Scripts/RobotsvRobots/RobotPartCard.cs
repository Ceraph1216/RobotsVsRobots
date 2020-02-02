using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotPartCard : MonoBehaviour
{
    public PartType partType;

    [SerializeField] string prefabToSpawn;

    private Image _selectionHighlight;

    private GameObjectPool partPool;

    void Awake ()
    {
        _selectionHighlight = GetComponent<Image>();
        partPool = PrefabManager.instance.ObjectPool(prefabToSpawn);
    }

    public void OnClick ()
    {
        Robot.RobotTeam team = Robot.RobotTeam.Left;
       RobotProductionManager.instance.SelectPart(team, this);
    }

    public void Select ()
    {
        _selectionHighlight.enabled = true;
    }

    public void Deselect ()
    {
        _selectionHighlight.enabled = false;
    }

    public void OnMatch ()
    {
        Deselect();
        gameObject.SetActive(false); // TODO: use object pooling to unspawn
    }

    public RobotPart SpawnPart()
    {
        return partPool.Spawn().GetComponentInChildren<RobotPart>();
    }
}

public enum PartType
{
    Top,
    Bottom
}
