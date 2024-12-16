using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyscript : MonoBehaviour
{
    public Rigidbody rb;
    // public float lookradius = 10f;
    //   public float attackradius = 10f;
    public Animator animator;
    public GameObject target;
    public NavMeshAgent agent;
    //  public bool issee;
    public bool isdie;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z));
        // GetComponent<Rigidbody>().en = false;

        // movement();
    }
    private void OnCollisionEnter(Collision collision)
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
       

    }
   

   
}
