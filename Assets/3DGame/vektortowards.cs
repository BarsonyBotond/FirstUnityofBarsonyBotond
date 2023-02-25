using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class vektortowards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 nextposition = Vector3.MoveTowards();

        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        Vector3 direction = targetPosition - selfPosition;
        direction.Normalize();
        Vector3 velocity = direction * speed;
        transform.position = Vector3.MoveTowards(selfPosition, targetposition, speed * Time.deltaTime);
        if (direction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction); 

        //transform.position += velocity * Time.deltaTime;
    }
}
*/