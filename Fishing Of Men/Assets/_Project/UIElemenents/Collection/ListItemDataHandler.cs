using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ListItemDataHandler : MonoBehaviour
{
    [Header("Source")]
    [SerializeField] private soCollectionItemData _collectionItemData;

    [Header("References")]
    [SerializeField] private Image _refImage;
    [SerializeField] private TMP_Text _refName;

    public soCollectionItemData CollectionItemData{
        get{ return _collectionItemData; }
        set{ _collectionItemData = value; } 
    }

    void Update()
    {
        if (_collectionItemData != null)
        {
            if (_collectionItemData.IsFound)
            {
                _refImage.sprite = _collectionItemData.ItemData.Sprite;
                _refImage.color = new Color(1, 1, 1, 1);
                _refName.text = _collectionItemData.ItemData.Name;
            }
            else
            {
                _refImage.sprite = _collectionItemData.ItemData.Sprite;
                _refImage.color = new Color(0, 0, 0, 1);
                _refName.text = "???";
            }
        }
    }

}
