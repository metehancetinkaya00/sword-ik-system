using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyaddforce : MonoBehaviour
{
      public Rigidbody rb;
     public ParticleSystem blood;
    [SerializeField] public float thrust;
    public Vector3 moveDirection;
    public GameObject player;
    //  public bool addforced;
    // Start is called before the first frame update
    void Start()
    {  
         rb = GetComponent<Rigidbody>();
           rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    private void OnCollisionEnter(Collision collision)
    {
       

    }
    private void OnTriggerEnter(Collider other)
    {
        moveDirection = rb.transform.position - player.transform.position;
        rb.AddForce(moveDirection.normalized * thrust);

          blood.Play();
        rb.isKinematic = false;
          
            //  rb.useGravity = true;
        

    }
}

