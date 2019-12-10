using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Vector3 dir;
    public void SetDirAndShot(Vector3 _dir)
    {
        dir = _dir;
        transform.LookAt(dir);//siempre estara mirando a la posicion del heroe
        GetComponent<Rigidbody>().AddForce(dir * 20);//se le hace un addforce al rayo en la direccion del heroe
    }



}
