using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class Player : MonoBehaviour {

	
		public CharacterController controller;

	public float speed;
		public float turnSpeed;
		public Vector3 moveDirection = Vector3.zero;
	public float gravity = 20.0f;
	//public NavMeshAgent agent;

	void Start ()
	{
		//agent = GetComponent<NavMeshAgent>();
		controller = GetComponent <CharacterController>();
		
		}

	
		void Update ()
	{

		


		if (controller.isGrounded)
        {
			moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
		}




			float turn = Input.GetAxis("Horizontal");
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			controller.Move(moveDirection * Time.deltaTime);
		moveDirection.y -= gravity * Time.deltaTime;
	}


}
