
using UnityEngine;

public class atobhomework : MonoBehaviour

{
    [SerializeField] Vector3 a;
    [SerializeField] Vector3 b;
    Vector3 DirectionAtoB(Vector3 a, Vector3 b)
    {


        return (b - a).normalized;
    }

    private void OnDrawnGizmosSelected() //csak akkor látszik ha ki van jelölve
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(a, 0.1f);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(b, 0.1f);
        Vector3 c = a + DirectionAtoB(a, b);

        Gizmos.DrawLine(a, b);

    }

    //másikházi:
    //stepjumper (https://codeshare.io/mpbLv4)
    /* using UnityEngine;

class DirectionVectorCreator : MonoBehaviour
{
    [SerializeField] Vector3 point1, point2;

    Vector3 DirectionFromAToB(Vector3 a, Vector3 b) 
    {
        return (b - a).normalized;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(point1, 0.1f);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(point2, 0.1f);

        Vector3 dir = DirectionFromAToB(point1, point2);

        Vector3 c = point1 + dir;

        Gizmos.DrawLine(point1, c);
    }
} 
    //onvalidate lefut mindig, csak fejlesztõi eszköz
    [SerializeField] int stepcount;

    [SerializeField] Vector2 Step;
    private void OnValidate()
    {

        Vector2 v = b - a;
        float length = v.magnitude;
        stepcount = Mathf.CeilToInt(lenght)
            //fölkerekít
            Step = v / stepcount;


    } */








}


