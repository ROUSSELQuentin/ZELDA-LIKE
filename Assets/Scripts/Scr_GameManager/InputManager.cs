using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public float _moveInputX;
    public float _moveInputY;

    void Start () {
		
	}	
	
	void Update () {
        _moveInputX = Input.GetAxisRaw("Horizontal");
        _moveInputY = Input.GetAxisRaw("Vertical");
    }
}
