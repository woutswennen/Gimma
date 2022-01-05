using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoesWandel : MonoBehaviour
{
   [SerializeField] float walkSpeed;
   [SerializeField] float runSpeed;
   private float currentSpeed;
   [SerializeField] Animator anim;
   [SerializeField] GameController gameController;
   [SerializeField] float runCost;
   [SerializeField] float staminaRegen;
   public bool isGrounded = false;

    void Start()
    {
       anim.SetBool("front", true);
    }

    void Update()
    {
        if(!gameController.isPaused()){
            gameController.GainStamina(staminaRegen * Time.deltaTime);
            bool leftShift = Input.GetKey(KeyCode.LeftShift);
            bool spacebar = Input.GetKeyDown(KeyCode.Space);
            float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
            float vertical = Input.GetAxis("Vertical") * Time.deltaTime;
            if(leftShift){
                anim.SetBool("fast", true);
                currentSpeed = runSpeed;
                gameController.LoseStamina(runCost * Time.deltaTime);
            }
            else{
                anim.SetBool("fast", false);
                currentSpeed = walkSpeed;
            }
            
            if(spacebar && isGrounded){
                Jump();
            }else{
                
            }
            if(horizontal == 0){
                anim.SetBool("front", false);
                anim.SetBool("back", false);
            }
            if(horizontal > 0)
            {
                anim.SetBool("front", true);
                anim.SetBool("back", false);
            }
            if(horizontal < 0)
            {
                anim.SetBool("back", true);
                anim.SetBool("front", false);
            }
            
            transform.Translate(horizontal * currentSpeed, 0,0);
        }
       
       

       
       

    }

    void Jump(){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
    }

    
}

