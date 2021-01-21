using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSystem : MonoBehaviour
{
    [SerializeReference] string Target;
    [SerializeField] bool canDestroy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Target))
        {
            Debug.Log("Collided");
            Destroy(other.gameObject);
            if (canDestroy)
            {
                Destroy(gameObject);
            }
           
        }   
    }
}
