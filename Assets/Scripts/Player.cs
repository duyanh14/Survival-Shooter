using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private LineRenderer laserLine;
    private float fireTimer;
    public Transform laserOrigin;
    public float gunRange = 50f;
    public float fireRate = 0.2f;
    public float laserDuration = 0.05f;

    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        fireTimer += Time.deltaTime;
        if (Input.GetMouseButtonUp(0) && fireTimer > fireRate)
        {
            laserLine.SetPosition(0, laserOrigin.position);
            Vector3 rayOrigin = Camera.main.ViewportToWorldPoint(new Vector3(0.1f, 0.1f, 0));
            RaycastHit hit;
            
      
            if (Physics.Raycast(rayOrigin, Camera.main.transform.forward, out hit, gunRange))
            {
                laserLine.SetPosition(1, hit.point);
            }
            else
            {
                laserLine.SetPosition(1, rayOrigin + (Camera.main.transform.forward * gunRange));
            }
            
            // transform.LookAt(hit.point);
            // transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
            //

            StartCoroutine(ShootLaser());
        }
    }

    IEnumerator ShootLaser()
    {
        laserLine.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laserLine.enabled = false;
    }
}