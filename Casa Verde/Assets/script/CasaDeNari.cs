using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaDeNari : MonoBehaviour
{
    public float life = 100;
    public GameObject miniun,cambitas;
    void Start()
    {
        
    }
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
     cambitas.SetActive(true);
    }

    public void GeneradorDeMin () 
    {
        float costoMiniun = 40 ; 
        if (General.instance.oro >= costoMiniun)
        {
            GameObject myMiniun;
            myMiniun = Instantiate(miniun,transform.position,Quaternion.identity);
            General.instance.oro -= 40;
            costoMiniun += 40;
        }
    }

    public  void  Cerrarcanvas()
    {
      cambitas.SetActive(false);
    }
    
    private void GameOver()
    {
        if (life <= 0)
        {
            General.instance.inGame = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FARC>())
        {
            life -= 10;
        }
    }

}
