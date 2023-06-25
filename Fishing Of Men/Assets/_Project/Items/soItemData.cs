using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemData")]
public class soItemData : ScriptableObject
{
    public delegate void EmptyDelegate();

    public event EmptyDelegate OnItemFound;

    [SerializeField] private Sprite _sprite;
    [SerializeField] private string _name;
    [SerializeField] private bool _found;

    public Sprite Sprite{
        get { return _sprite; }
    }
    public string Name{
        get { return _name; }
    }
    public bool IsFound{
        get { return _found; }
    }


    public void ItemFound()
    {
        OnItemFound();
    }
}
