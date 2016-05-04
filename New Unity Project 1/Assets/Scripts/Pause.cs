using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public Light L1;
	public Light L2;
	public GUIText P;
	public GUIText TP;
	public GUITexture Tx;
	public GUIText TH;
	public GUIText TQ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p")) {
			if (Time.timeScale == 1.0F)
			{
				Time.timeScale = 0F;
				L1.enabled= false;
				L2.enabled= false;
				P.enabled = true;
				TP.enabled = true;
				TH.enabled = true;
				TQ.enabled = true;
				Tx.enabled= true;
			}
			else
			{
				Time.timeScale = 1.0F;
				L1.enabled= true;
				L2.enabled= true;
				P.enabled = false;
				TP.enabled = false;
				TH.enabled = false;
				TQ.enabled = false;
				Tx.enabled= false;
			}
			
		}
	}
}
