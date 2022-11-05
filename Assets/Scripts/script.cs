using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Rigidbody2D rb;
    private Animator anim;
    
    
    public Transform destination;
    public Vector2 speed = new Vector2(50, 50);
    public float InputX;
    public float InputY;
    public float MovementSpeed = 1;
    public float JumpForce = 1;

    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
        

    // Update is called once per frame
    void Update()
    {
        //float dirX = Input.GetAxisRaw("Horizontal");

        //New movement
        var movement = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;


        //Smoothness
        //if (!Mathf.Approximately(0, movement))
        //    transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        //rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (rb.transform.position.y <-7)
        {
            void death()
            {
                this.rb.transform.position = destination.position;
            }

            death();
        }
        
        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            //Old movement
            //rb.velocity = new Vector2(rb.velocity.x, 11f);

            //New Movement
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if(movement > 0f)
        {
            anim.SetBool("Running", true);
        }
        else if(movement < 0f)
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
        //float inputX = Input.GetAxis("Horizontal");
        //float inputY = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        //movement *= Time.deltaTime;

        //transform.Translate(movement);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }


    }
}
