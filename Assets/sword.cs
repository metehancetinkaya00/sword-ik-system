using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
   public enemyscript scriptenemy;
    public ragdoll dollrag;
  //  public ParticleSystem blood;
    public playeranimation animationplayer;
    //public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            if(animationplayer.isattacking==true)
            {



                // blood.Play();
            }
        }
}

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "body")
        {
            if (animationplayer.isattacking == true)
            {
                // blood.Play();
                dollrag.activeragdoll();
                scriptenemy.agent.enabled = false;
                scriptenemy.rb.detectCollisions = false;
                scriptenemy.isdie = true;
         
                //animationplayer.animator.speed = 0.2f;
            }
        }
        else
        {
            //animationplayer.animator.speed = 1;
        }
            }
  

}
