using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetotarget : MonoBehaviour
{
    Camera maincamera;

    public GameObject firstobj;
    public Transform target;
    public float speed;
    private void Start()
    {
        maincamera = Camera.main;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("hi");
            Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("move"))
                {
                    // MoveObject(hit.collider.gameObject);
                    MOVE();
                    MOVE();
                }
            }
        }
        //MOVE();

    }



    void MoveObject(GameObject clickedObject)
    {

        //clickedObject.transform.position = target.position;
        clickedObject.transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);


    }
    void MOVE()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
