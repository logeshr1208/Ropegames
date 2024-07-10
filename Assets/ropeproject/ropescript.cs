using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ropescript : MonoBehaviour

{
    [SerializeField] private Camera mainCamera;
    public GameObject myobj;
    public Transform demo;
    public Transform democube;
    public string obj = "cube1";
    public string obj1 = "hitter";
    public bool isdrag;
    private float zCoord;
    private Vector3 offset;
    void Start()
    {
        isdrag = true;
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
        if (isdrag)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == obj)
        {

              StartCoroutine (stop());
           
            targetpoint();
            
        }

        if (other.gameObject.tag == obj1)
        {
            StartCoroutine(stop());         
            targetpoint1();
        }
    }
    
    IEnumerator stop()
    {
        isdrag = false;
        yield return new WaitForSeconds(3.0f);
        Debug.Log("corotine");
        isdrag = true;

    }

      void targetpoint()
    {
        transform.position = demo.position;
    }
    void targetpoint1()
    {
        
        transform.position = democube.position;
    }
}






/* private void OnMouseDown()
 {
     Debug.Log("down");
     offset = transform.position - MouseWorldposition();      
     
 }

 private void OnMouseDrag()
 {
    transform.position= MouseWorldposition() + offset;
 }

 void  MouseWorldposition()
 {
        *//* // Vector3 mouseposition = Input.mousePosition;

      mouseposition.z = Camera.main.ScreenToWorldPoint(transform.position).z;
      return Camera.main.ScreenToWorldPoint(mouseposition);*//*
        Vector3 mouseposition = Input.mousePosition;
        mouseposition.z= camera.ScreenPointToRay(Input.mousePosition);
        Ray ray=    camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position=raycastHit.point;
        }
     
    }*/

/* Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);


        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }*/

/* screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
      offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
*/

/* void OnMouseDown()
    {
        screenPoint = mainCamera.WorldToScreenPoint(transform.position);
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        offset = transform.position - worldPosition;
    }

    void OnMouseDrag()
    {
        if (isdrag || ismoveing2)
        {

            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition) + offset;


            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                worldPosition.z = hit.point.z;
            }

            transform.position = worldPosition;
        }
    }*/