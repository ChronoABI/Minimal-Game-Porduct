using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float destroyTime;
    [SerializeField] string joystickName;
    Joystick joystick;
    Rigidbody2D bulletRB;

    private void Start()
    {
        //All looks good but havesnt tyesteed
        joystick = GameObject.Find(joystickName).GetComponent<Joystick>();
        bulletRB = GetComponent <Rigidbody2D>();
        Vector2 moveDir = new Vector2(joystick.Horizontal,joystick.Vertical);
        moveDir.Normalize();
        bulletRB.velocity = moveDir * speed;
        Destroy(gameObject, destroyTime);
    }
}
