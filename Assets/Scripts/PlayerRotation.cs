using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Rigidbody rb;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    void Update() {
        if (Camera.current == null)
        {
            return;
        }
      
        // Ray ray = Camera.current.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;
        // if (Physics.Raycast(ray, out hit))
        // {
        //     transform.LookAt(hit.point);
        //     transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
        // }
    }

}