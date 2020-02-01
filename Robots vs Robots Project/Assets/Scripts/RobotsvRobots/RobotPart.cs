using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotPart : MonoBehaviour
{
    public PartType partType;

    private Image _selectionHighlight;

    void Awake ()
    {
        _selectionHighlight = GetComponent<Image>();
    }

    public void OnClick ()
    {
       RobotProductionManager.instance.SelectPart(this);
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
}

public enum PartType
{
    Top,
    Bottom
}
