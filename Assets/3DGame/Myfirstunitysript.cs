
using UnityEngine;

public class Myfirstunitysript : MonoBehaviour
{
    void Start()
    {

        Debug.Log("Hello!");
        Debug.Log($"Hello {name}!");
        Vector2 v1 = new Vector2(2, 4);
        float x = v1.x;
        float y = v1.y;
        v1 = v1 * 3;
        Debug.Log(v1.x);
        Vector2 v2 = new Vector2(4, 9);
        Vector2 v3 = new Vector2(-4, 16);
        v3 = v1 + v2; //10, 21
        Debug.Log(v3);

        Vector3 va = new Vector3(1.426f, 0.8995f, 1);


        Vector3 zero = new Vector3(0, 0, 0);

        // Vector3 zero2 = new Vector3.zero;

        Vector3 up1 = new Vector3(0, 1, 0);
        Vector3 up0_2 = up1 / 2;
        Vector3 forward = Vector3.forward;
        Vector3 left = Vector3.left;
        Vector3 vaNorm = va.normalized;
        va = vaNorm;
        //vagy
        va.Normalize();
        float mag = va.magnitude;
        float distance = (va - forward).magnitude;
        float distance2 = Vector2.Distance(va, v1);








    }









    void Update()
    {

    }






}