using UnityEngine;
using System.Collections;

public class Estirar : MonoBehaviour {
	private Rigidbody rb;
	public bool Est;
	public int Rot;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire2"))		
		{ if(Est)
			{
				rb.transform.Rotate(new Vector3(-Rot, 0, 0), Space.Self);
				Est = false	;
			}
			else
			{
				rb.transform.Rotate(new Vector3(Rot, 0, 0), Space.Self);
				Est = true;
			}
		}
	}
}
