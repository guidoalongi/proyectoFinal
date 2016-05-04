using UnityEngine;
using System.Collections;

public class T1 : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody>();

	}
	void Update()
	{
		rb.transform.Translate(speed,0,0);
	}
}
