
using UnityEngine;

public class explosion : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] Transform cursor3D;
    private void OnValidate()
    {
        camera = Camera.main;
    }
    private void Update()
    {
        Vector3 v = Input.mousePosition;
        Ray ray = camera.ScreenPointToRay(v);
        bool DoHit = Physics.Raycast(ray, out RaycastHit hit);
        if (DoHit)
            Debug.Log(hit.collider.name);
        cursor3D.position = hit.point;
    }

}
