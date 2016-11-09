using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public GameObject Zozo;
    public GameObject brick;

    public static int score = 0;
    public static int highscore = 0;
    public Text text;


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
        
        score = PlayerPrefs.GetInt("score");
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

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == brick.name)
        {
            score += 10;
            PlayerPrefs.SetInt("score",score);
            PlayerPrefs.Save();
            text.text = "score: " + score;
        }
    }
}
