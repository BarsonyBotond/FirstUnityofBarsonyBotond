
using UnityEngine;

public class colorchanger : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] Color color1, color2;
    [SerializeField] float frequncy;


    void Start()
    {

    }

    void Update()
    {
        float t = Mathf.Sin(Time.time * 2 * Mathf.PI * frequncy);


        t += 1;
        t /= 2;


        Color c;
        c = Color.Lerp(color1, color2, t);

        light.color = c;

    }

}
