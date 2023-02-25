/*
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

} */
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform target;
    [SerializeField] float sineAmp = 0.1f;
    [SerializeField] float sinefreqMultiplier = 5;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        transform.position =
            Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);
    }
}