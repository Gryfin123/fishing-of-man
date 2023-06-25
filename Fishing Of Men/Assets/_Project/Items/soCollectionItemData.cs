using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CollectionItemData")]
public class soCollectionItemData : ScriptableObject
{
    [SerializeField] private soItemData _itemData;
    [SerializeField] private bool _visited = false; // Visited detects if item has been viewed in the collection since player has found it.

    public bool IsFound{
        get { return _itemData.IsFound; }
    }
    public bool IsVisited{
        get { return _visited; }
    }
    public soItemData ItemData{
        get { return _itemData; }
    }

    public void OnItemVisited()
    {
        if (_itemData.IsFound)
        {
            _visited = true;
        }
    }

}
