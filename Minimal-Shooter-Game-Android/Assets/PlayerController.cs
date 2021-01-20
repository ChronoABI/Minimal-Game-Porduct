using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float pushBackForce;
    [SerializeField]GameObject bullet;
    [SerializeField] float fireRate;
    float nextFireTime;

    void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 moveDirection = mousePos - transform.position;
        moveDirection.Normalize();
        if (Input.GetMouseButton(0)&& nextFireTime<Time.time)
        {
            GameObject instantiatedBullet = Instantiate(bullet, transform.position, transform.rotation);
            GetComponent<Rigidbody2D>().velocity = -moveDirection * pushBackForce * Time.deltaTime;
             nextFireTime = Time.time + fireRate;
        }
    }
}
