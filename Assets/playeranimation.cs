using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimation : MonoBehaviour
{
    public Animator animator;
    public bool ikactive = false;
    public Transform target;
    public float lookweight;
    public Transform player;
   Vector3 dir;
    public bool isattacking;
    public float rotationspeed;
    Quaternion rotationtotarget;
   // public sword words;

    public BoxCollider colllider;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

       



    }
     IEnumerator waittoattack()
    {
   

   
        yield return new WaitForSeconds(0.4f);
        colllider.enabled = true;
        

    }
    public void updateanimation()
    {
        dir = player.position - target.position;
        Debug.DrawRay(player.position, player.forward * 4, Color.red);
        Debug.DrawLine(target.position, player.position, Color.red);
        // Debug.Log(Vector3.Angle(player.forward, dir));

        if (Input.GetMouseButton(0))
        {
            StartCoroutine(waittoattack());
          
          //  swordtrigger.SetActive(false);
            Vector3 dirr = target.position - transform.position;
            Quaternion rotattion = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dirr), rotationspeed * Time.deltaTime);
            rotattion.x = 0;
            rotattion.z = 0;
            transform.rotation = rotattion;
            isattacking = true;

            if (isattacking == true)
            {

             
              

             //   transform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));

                if (Vector3.Angle(player.forward, dir) >= 90)
                {

                    animator.SetBool("attack", true);
                    animator.SetBool("360attack", false);
           
                }

                if (Vector3.Angle(player.forward, dir) <= 90)
                {
                    animator.SetBool("attack", false);
                    animator.SetBool("360attack", true);
               
                }
                // 
            }
          

        }
       
    
        //  animator.SetBool("attack", true);


        else
        {
            StopCoroutine(waittoattack());
            colllider.enabled = false;
            isattacking = false;
            animator.SetBool("attack", false);
            animator.SetBool("360attack", false);
        }

        if (!Input.anyKey)
        {
            animator.SetBool("idle", true);

        }
        else
        {
            animator.SetBool("idle", false);
        }

        if (Input.GetKey("s"))
        {

            animator.SetBool("walkback", true);


        }
        else
        {
            animator.SetBool("walkback", false);
        }


        if (Input.GetKey("w"))
        {
            animator.SetBool("walk", true);

        }
        else
        {
            animator.SetBool("walk", false);
            //animator.SetBool("idle", true);
        }



    }
    // Update is called once per frame
    void Update()
    {
        colllider.enabled = false;



        updateanimation();

        float distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance < lookweight)
        {

            ikactive = true;

        }
        else
        {
            ikactive = false;
        }

    }

    private void limit()
    {

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, lookweight);
    }
    private void OnAnimatorIK(int layerIndex)
    {
        if (animator)
        {
            if (ikactive)
            {
                if (target != null)
                {
                    animator.SetLookAtWeight(lookweight);
                    animator.SetLookAtPosition(target.position);
                }
            }
            else
            {
                animator.SetLookAtWeight(0);
            }
        }
    }

}
