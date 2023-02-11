using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sript001 : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {



        Vector3 direction = GetInputDirection();
        Transform t = transform;
        Vector3 pos = t.position;
        t.position = pos;
        Vector3 velocity = direction * speed;
        pos += direction * Time.deltaTime;



        Quaternion rot = t.rotation;
        if (direction != Vector3.zero)
            t.rotation = Quaternion.LookRotation(direction);
        /*
         Transform t= transform;
        Vector3 pos = t.position;
        t.position = pos;
        Vector3 velocity = new Vector3(1, 0, 0);
         */

    }




    private static Vector3 GetInputDirection()
    {
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow); //van getkeydown és getkeyup is CSAK egyszeri lenyom ez nyomvatart
        float x = 0;
        float z = 0;
        if (right && left)
            x = 0;
        else if (left)
            x = -1;
        else if (right)
            x = 1;

        if (up && down)
            z = 0;
        else if (down)
            z = -1;
        else if (up)
            z = 1;

        Vector3 direction = new Vector3(x, 0, z);
        direction.Normalize();
        return direction;
    }
}
