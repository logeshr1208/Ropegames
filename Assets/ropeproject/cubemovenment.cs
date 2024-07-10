using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cubemovenment : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private float zCoord;
    private Vector3 offset;
    
    private void OnMouseDown()
    {
        zCoord = mainCamera.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
   
            transform.position = GetMouseWorldPosition() + offset;

    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;
        return mainCamera.ScreenToWorldPoint(mousePoint);
    }
}
