using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TökéletesPlatésrefil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /*   using UnityEngine;

class PlatformerPlayer : MonoBehaviour
{
    [SerializeField, HideInInspector] Rigidbody2D rb;
    [SerializeField] float speed = 5;
    [SerializeField] float jumpSpeed = 5;
    [SerializeField] int airJumpCount = 1;

    [SerializeField] Vector2 foot = Vector2.down;
    [SerializeField] float footRadius = 0.5f;

    bool grounded = false;
    int currentAirJumpBudget = 0;

    bool jumpInput = false;

    void OnValidate()
    {
        if (rb == null) 
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        if (grounded || currentAirJumpBudget > 0)
        {
            bool jump = Input.GetKeyDown(KeyCode.Space);

            if (jump)
            {
                this.jumpInput = true;
            }
        }
    }


    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed;

        Vector2 velocity = rb.velocity;

        velocity.x = horizontal;

        if (grounded || currentAirJumpBudget > 0)
        {            
            if (jumpInput)
            {
                velocity.y = jumpSpeed;

                if (!grounded)
                    currentAirJumpBudget--;
                jumpInput = false;
            }
        }

        rb.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Vector2 vel = collision.contacts[0].relativeVelocity;
        // if (vel.y > 0) return;

        Vector3 globalFooPoint = transform.TransformPoint(foot);
        bool isAnyPontInFootArea = false;
        foreach (var contact in collision.contacts) 
        {
            float distance = Vector3.Distance(contact.point, globalFooPoint);
            bool isInFootArea = distance <= footRadius;
            if (isInFootArea) 
            {
                isAnyPontInFootArea = true;
                break;
            }
        }

        if (!isAnyPontInFootArea)
            return;

        grounded = true;
        currentAirJumpBudget = airJumpCount;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

    public void RefillAirJump() 
    {
        currentAirJumpBudget = airJumpCount;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Vector3 globalP = transform.TransformPoint(foot);
        Gizmos.DrawWireSphere(globalP, footRadius);
    }
}



using UnityEngine;

class AirJumpRefill : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;
        PlatformerPlayer player = go.GetComponent<PlatformerPlayer>();

        if (player != null) 
        {
            player.RefillAirJump();
        }
    }

} */
}
