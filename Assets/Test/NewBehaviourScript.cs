using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public FafaFloat flo;
	void Start(){
		//flo.setVariable(3f);
	} 

	void Update(){
		print(flo.getVariable());
	}
}
