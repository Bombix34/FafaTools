using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FafaTools.Audio;

public class NewBehaviourScript1 : MonoBehaviour {

	public SimpleMusic sm;
	// Use this for initialization
	void Start () {
		StartCoroutine(sm.StartMusic(GetComponent<AudioSource>()));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
