using UnityEngine;
using System.Collections;

public class Tocar : MonoBehaviour {
	public Light luz;
	float timeLeft;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			luz.enabled=false;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Target") {
		Destroy (other.gameObject);
			luz.enabled=true;
			timeLeft = .5f;

				
		}

	}
}
