using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
   [SerializeField] GameObject bulletItem;
   [SerializeField] float fireRate;
    float nextFireTime;

    void Update()
    {
        
        if (Input.GetMouseButton(0) && nextFireTime<Time.time)
        {
            Instantiate(bulletItem, transform.position, transform.rotation);
            nextFireTime = fireRate + Time.time;
        }
    }
}
