using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovement : MonoBehaviour
{
    public GameObject Zozo;
    public GameObject brick;

    [SerializeField]
    public SpriteRenderer sprite;

    private Vector3 direction;

    public Vector2 velocity;
    bool jump;
    private bool isGrounded = true;
    private bool isMoving;
    private float horizontal;
    private float vertical;
    private float speed = 4f;
    private Animator animator;

    void Awake()
    {
        // player_0 = GameObject.FindWithTag("Player");
        // brick = GameObject.FindWithTag("Player");
        //direction = (new Vector3(Random.Range(-1.0f, 1.0f), 0.0f, Random.Range(-1.0f, 1.0f))).normalized;
        this.animator = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        this.horizontal = CrossPlatformInputManager.GetAxis("Horizontal");

        MovingCharacter();
        Jump();
        // this.brick.transform.position += direction * speed * Time.deltaTime;
        //#if UNITY_ANDROID
        //        horizontalMovement = CrossPlatformInputManager.GetAxis("Horizontal");
        //        verticalMovement = CrossPlatformInputManager.GetAxis("Vertical");

        //#endif
    }
    private void MovingCharacter()
    {

        if (horizontal > 0)
        {
            this.animator.Play("WalkingRight");
            this.transform.Translate(new Vector2(this.horizontal * this.speed * Time.deltaTime, 0f));

        }
       if (horizontal == 0)
        {
            this.animator.SetTrigger("Idle");
            
        }

       if (horizontal < 0)
        {
            this.animator.Play("WalkingLeft");
            this.transform.Translate(new Vector2(this.horizontal * this.speed * Time.deltaTime, 0f));
        }

    }

    void Jump()
    {
        jump = false;
        if (!jump)
        {
            if (CrossPlatformInputManager.GetButton("Jump"))
            {
                jump = true;
                transform.Translate(Vector3.up * 15 * Time.deltaTime);
            }
        }
    }
}
