
using UnityEngine;

public class autorottor : MonoBehaviour
{


    [SerializeField] float angularSpeed = 180;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0);
    }
}
