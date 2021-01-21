using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float pushBackForce;
    [SerializeField]GameObject bullet;
    [SerializeField] Transform shootPos;
    [SerializeField] float fireRate;
    [SerializeField] Joystick joystick;
    Rigidbody2D playerRB;

    float nextFireTime;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        playerMoveNShoot();
    }

    void playerMoveNShoot()
    {
        Vector2 moveDirection = new Vector2(joystick.Horizontal, joystick.Vertical);
       // playerRB.AddForce(-moveDirection * pushBackForce * Time.deltaTime,ForceMode2D.Force);
        moveDirection.Normalize();
        if (joystick.Direction != Vector2.zero && nextFireTime < Time.time)
        {
            Instantiate(bullet, shootPos.position, transform.rotation);
            playerRB.velocity = -moveDirection * pushBackForce * Time.deltaTime;
            nextFireTime = Time.time + fireRate;
        }
    }

}
