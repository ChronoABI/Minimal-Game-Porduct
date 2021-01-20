using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]Transform target;
    [SerializeField] float speed;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    void Update()
    {
        if (target!=null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }

}
