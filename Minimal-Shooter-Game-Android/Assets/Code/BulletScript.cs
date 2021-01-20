using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField]float speed;
    [SerializeField] float destroyTime;
    Rigidbody2D bulletRB;
    private Vector3 mousePos;
    // Update is called once per frame
    private void Start()
    {
        bulletRB = GetComponent <Rigidbody2D>();
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 moveDir = mousePos - transform.position;
        moveDir.Normalize();
        bulletRB.velocity = moveDir * speed;
        Destroy(gameObject, destroyTime);
    }
}
