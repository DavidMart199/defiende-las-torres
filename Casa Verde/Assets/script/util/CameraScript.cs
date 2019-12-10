using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //Movement
    public float borderMoveSpeed = 1.2f;
    public float screenOffset = 0.1f;
    // ZOOM
    public float zoomSpeed = 4f;
    public Vector2 zoomLimits;

    Camera myCam;
    private void Start()
    {
        myCam = GetComponent<Camera>();
    }

    void Update()
    {
        // Zoom code 
        var zoom = Input.GetAxis("Mouse ScrollWheel");
        myCam.orthographicSize -= zoom * zoomSpeed;
        myCam.orthographicSize = Mathf.Clamp(myCam.orthographicSize,zoomLimits.x, zoomLimits.y);


        // Camera movement per border
        Vector3 Speed = new Vector3();
        if (transform.position.x > -116f)
        {
            if (Input.mousePosition.x < Screen.width * screenOffset)
                Speed.x -= borderMoveSpeed;
        }
        if (transform.position.x < 116f)
        {
            if (Input.mousePosition.x > Screen.width - (Screen.width * screenOffset))
                Speed.x += borderMoveSpeed;
        }
        if (transform.position.z > -230f)
        {
            if (Input.mousePosition.y < Screen.height * screenOffset)
                Speed.z -= borderMoveSpeed;
      
        }
        if (transform.position.z < 18f)
        {
            if (Input.mousePosition.y > Screen.height - (Screen.height * screenOffset))
                Speed.z += borderMoveSpeed;
        }
        transform.position += Speed * Time.deltaTime;
    }

}