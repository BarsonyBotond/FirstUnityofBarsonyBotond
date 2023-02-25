
using UnityEngine; /*

public class Platformerplayer : MonoBehaviour
{
    [SerializeField, HideInInspector] Rigidbody2D rb; //HideInInspector  nem látja a gamedisigner
    [SerializeField] float speed = 5;
    [SerializeField] float jumpSpeed = 5;
    bool grounded = false;
    [SerializeField]  int JumpCount=1;
    int CurrectAirJumpBucket = 0;
    private void OnValidate()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>(); //FindObjectOfType összes olyan típúst megtalálja
        /*  GameObject go = GameObject.Find("player"); //string alapú keresés nem szerencsés!
          Follower f = go.GetComponent<Follower>();  rb.mass=2;*/



/* }

  void Update()
  {
      float horizontal = Input.GetAxis("Horizontal");
      {
          rb.velocity = new Vector2(horizontal, rb.velocity.y);
          horizontal = horizontal * speed;

          bool jump = Input.GetKeyDown(KeyCode.Space);
          if (jump)
          {
              rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
          }
      }

      void OnCollisonEnter2D(Collision2D collison)
      {
          grounded = false;
      }
      void OnCollisonExit2D(Collision2D collison)
      {
          grounded = false;
      }

      if(grounded || CurrectAirJumpBucket >0) 
      {
          bool jump = Input.GetKeyDown(KeyCode.Space);
          if(jump)
          {
              velocity.y= jumpSpeed;
              if (!grounded)
                  CurrectAirJumpBucket = CurrectAirJumpBucket - 1;
          }
      }



  } 




} */
// optimális /* using UnityEngine;

/*
{
    [SerializeField, HideInInspector] Rigidbody2D rb;
    [SerializeField] float speed = 5;
    [SerializeField] float jumpSpeed = 5;

    void OnValidate()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed;

        Vector2 velocity = rb.velocity;

        velocity.x = horizontal;

        bool jump = Input.GetKeyDown(KeyCode.Space);

        if (jump)
        {
            velocity.y = jumpSpeed;
        }


        rb.velocity = velocity;
    }



} */


class PlatformerPlayer : MonoBehaviour
{
    [SerializeField, HideInInspector] Rigidbody2D rb;
    [SerializeField] float speed = 5;
    [SerializeField] float jumpSpeed = 5;
    [SerializeField] int airJumpCount = 1;
    [SerializeField] Vector2 foot = Vector2.down;
    [SerializeField] float radius = 0.5f;
    bool grounded = false;
    int currentAirJumpBudget = 0;
    bool jump = false;
    private void Update()
    {

        bool jump = Input.GetKeyDown(KeyCode.Space);
        if (jump)
            this.jump = true;
    }
    void OnValidate()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void FixedUpdate() //ugyanannyiszor fut le mint
    {
        float horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed;

        Vector2 velocity = rb.velocity;

        velocity.x = horizontal;

        if (grounded || currentAirJumpBudget > 0)
        {
            //bool jump = Input.GetKeyDown(KeyCode.Space);

            if (jump)
            {
                velocity.y = jumpSpeed;

                if (!grounded)
                    currentAirJumpBudget--;
                jump = false;
            }
        }


        rb.velocity = velocity;
    }
    public void RefillAirJump()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //  Vector2 vel =collision.contacts[0].relativeVelocity;
        // if (vel.y>0)
        //  return;
        Vector3 globalFootPonint = transform.TransformPoint(foot);

        bool InFoot = false;
        foreach (var contact in collision.contacts)
        {
            float distance = Vector3.Distance(contact.point, globalFootPonint);
            bool isInFootArea = distance <= radius;
            grounded = true;
            currentAirJumpBudget = airJumpCount;

        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
    //public void RefillAirJump();

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Vector3 globalP = transform.TransformPoint(foot);
        Gizmos.DrawWireSphere(globalP, radius);
    }





}
//jó kód:
/* using UnityEngine;

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

    void OnValidate()
    {
        if (rb == null) 
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed;

        Vector2 velocity = rb.velocity;

        velocity.x = horizontal;

        if (grounded || currentAirJumpBudget > 0)
        {
            bool jump = Input.GetKeyDown(KeyCode.Space);

            if (jump)
            {
                velocity.y = jumpSpeed;

                if (!grounded)
                    currentAirJumpBudget--;
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

}*/


















