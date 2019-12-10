using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class playerControler : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    
    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if (General.instance.construcion == true && General.instance.inGame == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    agent.SetDestination(hit.point);
                }
            }

        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Cliker>())
        {
            General.instance.construcion = false;
        }
      
    }

}
