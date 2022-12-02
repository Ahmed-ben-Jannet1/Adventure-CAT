
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public float movespeed;
    public float climbspeed;
    public float Jumpforce;
    public Rigidbody2D rb;
    public CapsuleCollider2D playerCollider;
    private Vector3 velocity = Vector3.zero;
    public bool isJumping = false;
    public bool onground;
    [HideInInspector]
    public bool isCliming;


    public Transform groundcheck;
    public float groundcheckraduis;
    public LayerMask collisionlayers;


    public Animator animator;

    public SpriteRenderer spriterenderer;


    private float horizontalMovement;
    private float verticalMovement;
    //tasli7 mtaa jump sa3at tenzel espace doesn't work

    public static movementplayer instance;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("il ya plus d'instance de movementplayer dans la scène");
            return;
        }
        instance = this;
    }
    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        verticalMovement = Input.GetAxis("Vertical") * climbspeed * Time.deltaTime;



        if (Input.GetButtonDown("Jump") && onground)
        {
            SoundManager.playSound("jump");
            isJumping = true;
        }

        //flip t3ayet lel fonction
        flip(rb.velocity.x);

        float charvelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("speed", charvelocity);
        
    }



    void FixedUpdate()
    {
        onground = Physics2D.OverlapCircle(groundcheck.position, groundcheckraduis, collisionlayers);
        animator.SetBool("jump", !onground);
        moveplayer(horizontalMovement, verticalMovement);
    }

    void moveplayer(float _horizontalMovement, float _verticalMovement)
    {

        if (!isCliming)
        {
            Vector3 targetvel = new Vector2(_horizontalMovement, rb.velocity.y);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetvel, ref velocity, .05f);

            if (isJumping)
            {
                rb.AddForce(new Vector2(0f, Jumpforce));
                isJumping = false;
                
            }
        }
        else
        {
            //déplacement vertical
            Vector3 targetvel = new Vector2(0, _verticalMovement);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetvel, ref velocity, .05f);
        }
    }
    //el flip
    void flip(float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriterenderer.flipX = false;
        }
        else if (_velocity < -0.1f)
        {
            spriterenderer.flipX = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundcheck.position, groundcheckraduis);
    }
}

