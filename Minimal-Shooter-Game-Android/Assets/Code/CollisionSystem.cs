using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSystem : MonoBehaviour
{
    [SerializeReference] string Target;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Target))
        {
            Debug.Log("Collided");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }   
    }
}
