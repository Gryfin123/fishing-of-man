using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    [SerializeField] private soCollectionData _collectionData;
    [SerializeField] private GameObject _prefCollectionElement;
    [SerializeField] private GameObject _targetContainer;

    public void UpdateCollection()
    {
        // Destroy all current elements in Panel
        while (_targetContainer.transform.childCount > 0) {
            DestroyImmediate(_targetContainer.transform.GetChild(0).gameObject);
        }

        foreach(soCollectionItemData currData in _collectionData)
        {
            Debug.Log("Found: " + currData.ItemData.Name);
            GameObject newListElement = Instantiate(_prefCollectionElement, new Vector3(), new Quaternion());
            newListElement.GetComponent<ListItemDataHandler>().CollectionItemData = currData;
            newListElement.transform.SetParent(_targetContainer.transform, false);
        }
    }
}
