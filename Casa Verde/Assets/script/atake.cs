using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atake : MonoBehaviour
{
    public float distance = 99999;//distancia a la que esta el heroe

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public IEnumerator  Attack()
    {
        
     
        yield return new WaitForSeconds(3f);

    }
}
