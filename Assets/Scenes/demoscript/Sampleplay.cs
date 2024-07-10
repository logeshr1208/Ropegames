using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Sampleplay : MonoBehaviour
{

    private Vector3 offset;
    private float zCoord;
    public Camera mainCamera;
    public Transform targetobject;
    public bool forward=false;
    public bool mousedrags;
    public float speed;
    private void Start()
    {
        mousedrags = true;
        
    }
    private void Update()
    {
     
     
    }

    private Vector3 GetMouseWorldPosition()
    {     
        Vector3 mousePoint = Input.mousePosition;     
        mousePoint.z = zCoord;
        return mainCamera.ScreenToWorldPoint(mousePoint);
    }
    private void OnMouseDown()
    {
        zCoord = mainCamera.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        if (mousedrags == true)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
       
    }
    
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "trigger")
        {
            mousedrags = false;
            target();
        }

    }
    void target()
    {    
        transform.position = targetobject.position;
    }
  
}




