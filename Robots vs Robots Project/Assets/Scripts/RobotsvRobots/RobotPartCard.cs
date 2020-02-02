using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotPartCard : MonoBehaviour
{
    private PartType _partType;
    public PartType partType { get { return _partType; } private set { _partType = value; } }
    public Robot.RobotTeam team;

    private string prefabToSpawn;

    //private Image _selectionHighlight;
    private Image _cardImage;
    private EasyTween _tween;


    private bool _isAvailable;
    public bool isAvailable { get { return _isAvailable; } private set {_isAvailable = value; } }

    void Awake ()
    {
        //_selectionHighlight = GetComponent<Image>();
        _cardImage = GetComponentInChildren<Image>();
        _tween = GetComponentInChildren<EasyTween>();
    }

    void OnEnable ()
    {
        isAvailable = true;
    }

    public void Populate (Sprite p_icon, string p_partSpawn, PartType p_partType)
    {
        _cardImage.sprite = p_icon;
        _cardImage.enabled = true;
        prefabToSpawn = p_partSpawn;
        partType = p_partType;
        isAvailable = false;
        _tween.OpenCloseObjectAnimation();
    }

    public void OnClick ()
    {
        if (isAvailable)
        {
            return;
        }

       RobotProductionManager.instance.SelectPart(team, this);
    }

    public void Select ()
    {
        Color l_newColor = _cardImage.color;
        l_newColor.a = 0.5f;
        _cardImage.color = l_newColor;
    }

    public void Deselect ()
    {
        Color l_newColor = _cardImage.color;
        l_newColor.a = 1f;
        _cardImage.color = l_newColor;
    }

    public void OnMatch ()
    {
        Deselect();
        isAvailable = true;
        _tween.OpenCloseObjectAnimation();
        _cardImage.enabled = false;
        //gameObject.SetActive(false); // TODO: use object pooling to unspawn
    }

    public RobotPart SpawnPart()
    {
        return PrefabManager.instance.ObjectPool(prefabToSpawn).Spawn().GetComponentInChildren<RobotPart>();
    }
}

public enum PartType
{
    Top,
    Bottom
}
