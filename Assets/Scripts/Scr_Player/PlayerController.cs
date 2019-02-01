using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    InputManager inputManager;
    Rigidbody rb;
    
    [SerializeField] float playerSpeed;

	void Start ()
    {
        inputManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        PlayerDeplacement();
	}

    void PlayerDeplacement()
    {
        rb.velocity = new Vector3(inputManager._moveInputX * playerSpeed, 0, inputManager._moveInputY * playerSpeed);
        
    }
}
