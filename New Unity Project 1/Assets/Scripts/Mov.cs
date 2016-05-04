using UnityEngine;
using System.Collections;

public class Mov : MonoBehaviour {
	
	public float speed;	
	private Rigidbody rb;	
	Vector3 Jump = new Vector3(0.0f, 0.0f, 10.0f);
	int T = 0;
	bool Adelante = false;
	void Start ()	{
		rb = GetComponent<Rigidbody>();
	}	
	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");
		if (((moveVertical < 0 && rb.position.z > -25)||(moveVertical > 0 && rb.position.z < 10)) 	&&!Adelante)	
		{
			Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);		
			rb.transform.Translate (movement * speed);
		}


	}
	void Update()
	{ 
		if (Input.GetButtonDown("Fire1"))		
		{ 
			rb.transform.Translate (Jump);
			T = 0;
			Adelante = true;
		}
		if ((T == 50 || Input.GetButtonUp("Fire1"))&& Adelante) 
		{
			rb.transform.Translate (-Jump);
			Adelante = false;
		}
		T++;
	}
	
	
}