using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    float incremento = 30;
    float tiempoDeEspera = 10;
    void Start()
    {
        StartCoroutine("Spawns");
    }

    void Update()
    {
        General.instance.myTime += Time.deltaTime * 1;
    }
    private void Dificultad ()
    {
        if (General.instance.myTime <= tiempoDeEspera)
        {
            incremento -= 0.5f;
            tiempoDeEspera += 10;

        }
    }
    IEnumerator Spawns()
    {
        while (General.instance.inGame)
        {
            GameObject enemy;
            int rnd = Random.Range(0,4);
            switch(rnd)
            {
                case 0:
                    enemy = Instantiate(General.instance.enemigoUno, transform.position, Quaternion.identity);
                    break;
                case 1:
                    enemy = Instantiate(General.instance.enemigoDos, transform.position, Quaternion.identity);
                    break;
                case 2:
                    enemy = Instantiate(General.instance.enemigoTres, transform.position, Quaternion.identity);
                    break;
                case 3:
                    //...
                    break;
            }
            
            yield return new WaitForSeconds(incremento);
        }
    }
}
