using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {
	public float mouseSentitivity = 5.0f;
	public float upDownRange = 60.0f;
	private Rigidbody rb;
	public float Speed;
	public float RotYX;
	public float verticalRotation=0;
	public float horizontalRotation=0;
	void Start()
	{
		rb = GetComponent<Rigidbody>();

	}
	void FixedUpdate () {	
	 	RotYX = Input.GetAxis ("Mouse X") * mouseSentitivity;

		verticalRotation -=Input.GetAxis("Mouse Y") * mouseSentitivity;
		rb.transform.Rotate (0, RotYX, 0);	
		verticalRotation= Mathf.Clamp(verticalRotation, 290 +(-upDownRange), 290+(upDownRange));
		rb.transform.rotation = Quaternion.Euler(verticalRotation,0,0);

		    

	}

}
