using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class General : MonoBehaviour
{
    public static General instance;

    public bool inGame = true;
    public bool construcion = true;
    public bool enConstrucion = false;
    public float oro = 1f;
    public float myTime = 1f;
    public Text textOro,gameOver;
    public GameObject bala,enemigoUno,enemigoDos,enemigoTres;
    private void Awake()
    {
      if (instance == null)
      {
          instance = this; 
      }
      else
      {
          Destroy(this);
      }
    }
    void Start()
    {

    }
    void Update()
    {
     GeneradorDeOro();
     GameOver();
    }
    public void GeneradorDeOro()
    {
        if (inGame == true)
        {
            oro += Time.deltaTime * 10000;
            textOro.text = "Oro " + oro.ToString("f0");
        }
       
    }
    public void GameOver ()
    {
        if (inGame == false)
        {
            gameOver.text = "Perdistes";
        }
    }
}
