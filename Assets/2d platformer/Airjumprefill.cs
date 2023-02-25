
using UnityEngine;

public class Airjumprefill : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        PlatformerPlayer player = go.GetComponent<PlatformerPlayer>();
        if (player != null)
        {
            player.RefillAirJump();
        }
    }




}
