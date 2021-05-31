using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Script
{
    public class CharacterController : Creature
    {
        //  [SerializeField] private float speed = 3f;
        //    [SerializeField] private int lives = 5;
        [SerializeField] private SpriteRenderer _sprite;
        [SerializeField] private float jumpForse = 1f;
        public Rigidbody2D rb;
        [SerializeField] private Animator animator;
        private bool top;
        public bool onGround = false;
        public LayerMask Ground;
        public Transform GroundCheck;
        private float GroundCheckRadius;
        public bool faceRight = true;
        [SerializeField] private Transform attackPoint;
        public static CharacterController Instanse { get; set; }
        [SerializeField] private int extalJump = 1;
        [SerializeField] private int monets = 0;
        [SerializeField] private int health = 100;
        [SerializeField] private GameObject  chunksPlacer;


        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public int Monets { get => monets; set => monets = value; }

        void Start()
        {

            rb = GetComponent<Rigidbody2D>();
            _sprite = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();

       

        }
        private void FixedUpdate()
        {

            CheckingGround();

        }
        // Update is called once per frame
        void Update()
        {



            CheckingGround();

            if (top == true)
            {
                
                RunLeft();
                if (Input.GetButtonDown("Jump") )
                {
                    _sprite.flipX = false;
                    JumpDouble();

                }

            }
            else
            {
                RunRight();
            }

            if (onGround)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    extalJump = 2;
                    Jump();
                }
                
               
            }else   if (onGround == false)
            {
                if (Input.GetButtonDown("Jump") && extalJump == 2)
                {
                    _sprite.flipX = true;
                    extalJump = 1;

                    JumpDouble();

                }
              
            }
               if (Health < 1)
            {
                Destroy(chunksPlacer);
                Die();
            }

        }

        void Rotate()
        {
            if (top == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 180);
               

            }
            else
            {
                transform.eulerAngles = Vector3.zero;
              
            }

            top = !top;
        }





        private void RunRight()
        {
            
            
                Vector3 dir = transform.right * 10;


           // transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed );
        }

        public void RunLeft()
        {
            
            Vector3 dir = transform.right * 10;
          //  transform.position = Vector3.MoveTowards(transform.position, transform.position - dir, speed * Time.deltaTime); 
            transform.position = Vector3.MoveTowards(transform.position, transform.position - dir, speed );
        }
        private void Jump()
        {
          
            animator.SetTrigger("Jump");

            rb.AddForce(transform.up * jumpForse, ForceMode2D.Impulse);
        }
       

        private void JumpDouble()
        {

            rb.AddForce(transform.up * jumpForse, ForceMode2D.Impulse);
            animator.SetTrigger("JumpDouble");
            rb.gravityScale *= -1;
            Rotate();


        }
   

        //public override void GetDamage()
        //{
        //    lives -= 1;

        //}
        public void Rig(bool rbBool)
        {
            rb.isKinematic = rbBool;
        }


        void CheckingGround()
        {
            onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, Ground);

        }

    }
}
    