using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FARC : MonoBehaviour
{
    public NavMeshAgent agente;
    public float torreDistance;
    public float miniunDistance;
    public float vidaEnemigo = 100; 
    void Start()
    {
          agente.SetDestination(GameObject.Find("Casa").transform.position);
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.GetComponent<CasaDeNari>())
        {
            Destroy(gameObject);
        }
    }
}
