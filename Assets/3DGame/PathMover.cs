/*
using UnityEngine;

public class PathMover : MonoBehaviour
{

    [SerializeField] Vector3 target;
    [SerializeField] Transform start, end;
    [SerializeField] float speed;
    [SerializeField, Range(0, 1)] float startposition;
    private void OnValidate()
    {
        transform.position = Vector3.Lerp(start.position, end.position, startposition);
    }
    Transform nextTarget;
    void Start()
    {

    }
    nextTarget = end;

    void OndDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(start.position, 2.30023f);
        Gizmos.DrawSphere(end.position, 2.30023f);
        Gizmos.DrawLine(start.position, end.position);
        // void OwnDrawnGizmos()
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, end.position, speed * Time.deltaTime);

        if (transform.position == target)
        {
            if (nextTarget == start)
                nextTarget = end;
            else

                nextTarget = start;



        }
        {

        }
    }
}mbox */

// Color c= Color.Lerp(0,0,0); saját szín, lehet más szín is keverni