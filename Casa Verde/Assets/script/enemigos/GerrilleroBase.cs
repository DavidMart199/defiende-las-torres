using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GerrilleroBase : FARC
{   
    Vector3 direction;
    private void Update() 
    {
        GameObject torreSerca = null;
        GameObject miniunSerca = null;
        torreDistance = 6;
        miniunDistance = 5;
        foreach (var torre in FindObjectsOfType<Torre>())
        {
            float temporalDistan = (torre.transform.position - transform.position).magnitude;
            if (temporalDistan < torreDistance )
            {
                torreDistance = temporalDistan;
                torreSerca = torre.gameObject;
            }
        }
        foreach (var miniun in FindObjectsOfType<playerControler>())
        {
            float temporalDistan = (miniun.transform.position - transform.position).magnitude;
            if (temporalDistan < miniunDistance)
            {
                miniunDistance = temporalDistan;
                miniunSerca = miniun.gameObject; 
            }
        }
        if (torreSerca != null)
        {
            torreDistance = (torreSerca.transform.position - transform.position).magnitude;
            Vector3 gerrilleroDirection = (torreSerca.transform.position - transform.position).normalized;
            transform.position += (gerrilleroDirection * 2f * Time.deltaTime);
        }
        else if (miniunSerca != null )
        {
            direction = Vector3.Normalize(miniunSerca.transform.position - transform.position).normalized;
            transform.position += direction * 0.1f; 
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.GetComponent<CasaDeNari>())
        {
            Destroy(gameObject);
        }
    }
}
