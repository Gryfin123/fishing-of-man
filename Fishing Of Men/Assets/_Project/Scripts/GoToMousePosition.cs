using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMousePosition : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _followSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        Debug.Log(targetPosition.x + " | " + targetPosition.y);

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _followSpeed * Time.deltaTime);
    }
}
