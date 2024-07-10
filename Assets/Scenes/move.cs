using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
   

    public GameObject firstobj;
    public Transform target;
    public float speed;
    public string n="dec";
    public string obj = "mov";
    public bool ismove;
    private void Start()
    {
        if (ismove)
        {
            firstobj.transform.position = target.position;
        }
    }
    private void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == n)
        {
            ismove = true;    
            Debug.Log(firstobj.transform.position);
        } 
    }
  
   void MOVE()
    {
       firstobj. transform.position = Vector3.MoveTowards(firstobj.transform.position, target.transform.position, speed *Time.deltaTime);
    }

    
}


/*if (Input.GetMouseButton(0))
        {
            Debug.Log("hi");
            Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("move"))
                {

                    // hit.collider.gameObject.transform.position = target.position;
                    MOVE();


                }
            }
        }*/
