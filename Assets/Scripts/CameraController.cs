using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    
    public GameObject player;
    public float cameraDistance = 10.0f;

    void Update()
    {
        transform.position = player.transform.position - player.transform.forward * cameraDistance;
        transform.LookAt (player.transform.position);
        transform.position = new Vector3 (transform.position.x, transform.position.y + 5, 0);
        
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        yaw = Mathf.Clamp(yaw, -90f, 90f);
        pitch = Mathf.Clamp(pitch, -60f, 90f);
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
