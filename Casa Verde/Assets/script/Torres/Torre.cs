using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    float vida = 100;
    float gerrilleroDistance;
    float tanquetaDistance;
    float burroDistance;
    public Vector3 direccion;
    public float distance = 99999;//distancia a la que esta el heroe
    public float distance1 = 99999;//distancia a la que esta el heroe
    public float distance2 = 99999;//distancia a la que esta el heroe

    public GameObject balaIntance;

    void Start()
    {
        
    }
    void Update()
    {
        distance = (General.instance.enemigoUno.transform.position - transform.position).magnitude;
        distance1 = (General.instance.enemigoDos.transform.position - transform.position).magnitude;
        distance2 = (General.instance.enemigoTres.transform.position - transform.position).magnitude;

        GameObject gerrilleroSerca = null;
        GameObject tanquetaSerca = null;
        GameObject burroSerca = null; 
        gerrilleroDistance = 6;
        tanquetaDistance = 5;
        burroDistance = 4;

                foreach (var gerrillero in FindObjectsOfType<GerrilleroBase>())
                {
                    float temporaalDistan = (gerrillero.transform.position - transform.position).magnitude;
                    if (temporaalDistan < gerrilleroDistance)
                    {
                        gerrilleroDistance = temporaalDistan;
                        gerrilleroSerca = gerrillero.gameObject;
                    }
                }
                foreach (var tanqueta in FindObjectsOfType<tanqueta>())
                {
                    float temporaalDistan = (tanqueta.transform.position - transform.position).magnitude;
                    if (temporaalDistan < tanquetaDistance)
                    {
                        tanquetaDistance = temporaalDistan;
                        tanquetaSerca = tanqueta.gameObject;
                    }
                }
                foreach (var burro in FindObjectsOfType<burro>())
                {
                    float temporaalDistan = (burro.transform.position - transform.position).magnitude;
                    if (temporaalDistan < burroDistance)
                    {
                        burroDistance = temporaalDistan;
                        burroSerca = burro.gameObject;
                    }
                }
                if (gerrilleroSerca != null)
                    {
                     direccion = Vector3.Normalize(gerrilleroSerca.transform.position - transform.position).normalized;
                    }
                if (tanquetaSerca != null)
                    {
                     direccion = Vector3.Normalize(tanquetaSerca.transform.position - transform.position).normalized;
                    }
                if (burroSerca != null)
                    {
                     direccion = Vector3.Normalize(burroSerca.transform.position - transform.position).normalized;
                    }
    }
       public IEnumerator  Attack()
    {
        while (true)
        {
          
            if (distance <= 6)
            {
                Vector3 direction = (General.instance.enemigoUno.transform.position - transform.position).normalized; 
                balaIntance = Instantiate(General.instance.bala, transform.position, Quaternion.identity);

                yield return new WaitForSeconds(3f);
            }
            if (distance <= 5)
            {
                Vector3 direction = (General.instance.enemigoDos.transform.position - transform.position).normalized; 
                balaIntance = Instantiate(General.instance.bala, transform.position, Quaternion.identity);

                yield return new WaitForSeconds(3f);
            }
            if (distance <=4 )
            {
                Vector3 direction = (General.instance.enemigoTres.transform.position - transform.position).normalized; 
                balaIntance = Instantiate(General.instance.bala, transform.position, Quaternion.identity);

                yield return new WaitForSeconds(3f);
            }
         yield return new WaitForSeconds(3f);
            
        }
     

    }
    public void SpawnBala()
    {
        if (General.instance.inGame == true)
        {
            GameObject myBala;
            myBala = Instantiate(General.instance.bala, transform.position, Quaternion.identity);
            myBala.transform.position += direccion * 0.1f;
        }
    }
    private void Dei ()
    {
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FARC>())
        {
            vida -= 100;
        }
    }
}
