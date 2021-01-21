using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRing : MonoBehaviour
{
    [SerializeReference] Joystick joystick;
    [SerializeField] float offset;

    void Update()
    {
        Vector3 lookDirection = new Vector2(joystick.Horizontal,joystick.Vertical);
        float direction = Mathf.Atan2(joystick.Vertical, joystick.Horizontal)* Mathf.Rad2Deg; 
        
        lookDirection.Normalize();
        transform.rotation = Quaternion.Euler(0, 0, direction+offset);
    }
}
