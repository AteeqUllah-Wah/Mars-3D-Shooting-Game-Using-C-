using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;

    //**************
    //**************
    //**************

  /*  private Animator myAnim;
    bool isRunning_Forword = false;
    bool isRunning_Backword = false;
    bool isJumping = false;
    bool isReload = false;
    bool isDead = false;*/

    //**************
    //**************
    //**************



    public float speed = 12f;
    public float gravity = -9;


    [SerializeField] private float jumpHight;





    //**************
    //**************
    //**************
    /*void Start()
    {
        myAnim = GetComponent<Animator>();
    }*/
    //**************
    //**************
    //**************





    Vector3 velocity; //3

    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        

        velocity.y += gravity * Time.deltaTime;   //3
        controller.Move(velocity * Time.deltaTime);  //3




        //**************
        //**************
        //**************

        /*isRunning_Forword = Input.GetKey(KeyCode.W);
        isJumping = Input.GetKey(KeyCode.Space);
        isRunning_Backword = Input.GetKey(KeyCode.S);

        isReload = Input.GetKey(KeyCode.R);
        //isDead = Input.GetKey(KeyCode.S);



        myAnim.SetBool("p_run_forword", isRunning_Forword);
        myAnim.SetBool("p_run_back", isRunning_Backword);
        myAnim.SetBool("p_jump", isJumping);

        myAnim.SetBool("p_reload", isReload);
        myAnim.SetBool("P_dead", isDead);*/
        //**************
        //**************
        //**************
        //**************
        //**************





        if (Input.GetKeyDown(KeyCode.Space))     //5
        {
            Jump();
            
        }
    }

    private void Jump()                                         //5
    {
        velocity.y = Mathf.Sqrt(jumpHight * -2 * gravity);
    }
}
