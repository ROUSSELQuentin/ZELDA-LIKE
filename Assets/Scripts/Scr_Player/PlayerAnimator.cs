using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    Animator anim;
    PlayerController playerController;
    InputManager inputManager;
    Rigidbody rb;

	void Start () {
        anim = gameObject.GetComponent<Animator>();
        playerController = gameObject.GetComponent<PlayerController>();
        rb = gameObject.GetComponent<Rigidbody>();
        inputManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
	}
	
	void Update () {
		if(inputManager._moveInputY < 0 && inputManager._moveInputX < 1 && inputManager._moveInputX > -1)
        {
            anim.SetBool("isWalkFront", true);
            anim.SetBool("isWalkRight", false);
            anim.SetBool("isWalkLeft", false);
            anim.SetBool("isWalkBack", false);
        }
        else if(inputManager._moveInputX > 0 && inputManager._moveInputY < 1 && inputManager._moveInputY > -1)
        {
            anim.SetBool("isWalkRight", true);
            anim.SetBool("isWalkFront", false);
            anim.SetBool("isWalkLeft", false);
            anim.SetBool("isWalkBack", false);
        }
        else if(inputManager._moveInputX < 0 && inputManager._moveInputY > -1 && inputManager._moveInputY < 1)
        {
            anim.SetBool("isWalkLeft", true);
            anim.SetBool("isWalkRight", false);
            anim.SetBool("isWalkFront", false);
            anim.SetBool("isWalkBack", false);
        }
        else if(inputManager._moveInputY > 0 && inputManager._moveInputX < 1 && inputManager._moveInputX > -1)
        {
            anim.SetBool("isWalkBack", true);
            anim.SetBool("isWalkLeft", false);
            anim.SetBool("isWalkRight", false);
            anim.SetBool("isWalkFront", false);
        }
        else
        {
            anim.SetBool("isWalkRight", false);
            anim.SetBool("isWalkLeft", false);
            anim.SetBool("isWalkFront", false);
            anim.SetBool("isWalkBack", false);
        }
    }
}
