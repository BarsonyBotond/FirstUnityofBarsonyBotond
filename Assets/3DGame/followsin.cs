
/*using UnityEngine;


//www.mixamo.com, animációk
[SerializeField] float speed = 3.15799301f;
[SerializeField]  float sineAmp;
[SerializeField] Transform target;
[SerializeField]
public class followsin : MonoBehaviour
{




    void Update()
    {


        void Update()
        {




            Vector3 selfPosition = transform.position;
            Vector3 targetPosition = target.position;


            Vector3 direction = targetPosition - selfPosition;
            direction.Normalize();
            Vector3 velocity = direction * speed;
            transform.position += velocity * Time.deltaTime;

            transform.position += velocity * Time.deltaTime;
            float sine = Mathf.Sin(Time.time);
            sine *= sineAmp;
            sine += 1;
            direction *= sine;




















        }
    }
}
*/