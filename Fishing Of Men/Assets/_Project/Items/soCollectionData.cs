using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CollectionData")]
public class soCollectionData : ScriptableObject, IEnumerable
{
    public soCollectionItemData[] _collectionItems;

    // Allows for looping through _collectionItems, without envoking it directly.
    public IEnumerator GetEnumerator()
    {
        return _collectionItems.GetEnumerator();
    }
}
