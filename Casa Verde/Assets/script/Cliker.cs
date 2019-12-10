using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliker : MonoBehaviour
{
    public GameObject   plataforma,
                        torre,
                        caiMovil,
                        cai,
                        cambitas,
                        blokeUno,
                        blokeDos,
                        blokeTres,
                        blokeCuatro;
        
    
     private void Start()
     {

     }
    void update ()
    {
       
    }

    private void OnTriggerEnter(Collider other) 
    {
      if (other.GetComponent<playerControler>())
      {
          cambitas.SetActive(true);
      }
        
    }
  
    public void ContrucionCAI ()
    {
        if (General.instance.oro >= 10 )
        {
            General.instance.construcion = false;
            General.instance.enConstrucion = true;
            General.instance.oro = General.instance.oro - 10;
            if (General.instance.enConstrucion == true)
                StartCoroutine("ContruccionCai");
        }
    }
    public void ContrucionCAIMovil ()
    {
        if (General.instance.oro >= 20)
        {
            General.instance.enConstrucion = true;
            General.instance.oro = General.instance.oro - 20;
            if (General.instance.enConstrucion == true)
                StartCoroutine("ContruccionCaiMovil");
        }
       
    }
    public void ContrucionTorre()
    {
        if (General.instance.oro >= 30)
        {
            General.instance.enConstrucion = true;
            General.instance.oro = General.instance.oro - 30;

            if (General.instance.enConstrucion == true)
                StartCoroutine("ContruccionTorre");

        }
    }
    IEnumerator ContruccionTorre ()
    {
        General.instance.construcion = false;
        List<GameObject> bloques = new List<GameObject>();
        bloques.Add (Instantiate(blokeUno,transform.position,Quaternion.Euler(0,24,0)));

        foreach (Transform item in plataforma.transform)
        {
            item.gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeDos, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeTres, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeCuatro, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[3].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[2].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[1].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[0].gameObject);

        //crear torre
        GameObject myTorre;
        myTorre = Instantiate(torre,transform.position,Quaternion.Euler(0,24,0));
        myTorre.AddComponent<Torre>();
        yield return new WaitForSeconds(0.75f);
        plataforma.SetActive(false);
        General.instance.construcion = true;

    }
    IEnumerator ContruccionCaiMovil()
    {
        General.instance.construcion = false;

        List<GameObject> bloques = new List<GameObject>();
        bloques.Add(Instantiate(blokeUno, transform.position, Quaternion.Euler(0, 24, 0)));

        foreach (Transform item in plataforma.transform)
        {
            item.gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeDos, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeTres, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeCuatro, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[3].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[2].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[1].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[0].gameObject);

        //crear torre
        GameObject myTorre;
        myTorre = Instantiate(caiMovil, transform.position, Quaternion.Euler(0, 24, 0));
        myTorre.AddComponent<Torre>();
        yield return new WaitForSeconds(0.75f);
        plataforma.SetActive(false);
        General.instance.construcion = true;

    }
    IEnumerator ContruccionCai()
    {
        General.instance.construcion = false;
        List<GameObject> bloques = new List<GameObject>();
        bloques.Add(Instantiate(blokeUno, transform.position, Quaternion.Euler(0, 24, 0)));

        foreach (Transform item in plataforma.transform)
        {
            item.gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeDos, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeTres, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        bloques.Add(Instantiate(blokeCuatro, transform.position, Quaternion.Euler(0, 24, 0)));
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[3].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[2].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[1].gameObject);
        yield return new WaitForSeconds(0.75f);

        Destroy(bloques[0].gameObject);

        //crear torre
        GameObject myTorre;
        myTorre = Instantiate(cai, transform.position, Quaternion.Euler(0, 24, 0));
        myTorre.AddComponent<Torre>();
        yield return new WaitForSeconds(0.75f);
        plataforma.SetActive(false);
        General.instance.construcion = true;

    }
}
