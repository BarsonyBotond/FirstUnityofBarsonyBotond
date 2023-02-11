
using UnityEngine;

class Follower : MonoBehaviour
{


    [SerializeField] float speed = 3.15799301f;

    [SerializeField] Transform target;

    void Update()
    {





        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        Vector3 direction = targetPosition - selfPosition;
        direction.Normalize();
        Vector3 velocity = direction * speed;

        transform.position += velocity * Time.deltaTime;








    }

}
