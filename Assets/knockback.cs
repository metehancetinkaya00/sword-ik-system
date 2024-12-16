using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public Rigidbody rb;
    //  public ParticleSystem blood;
    [SerializeField] public float thrust;
    public Vector3 moveDirection;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
  

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
