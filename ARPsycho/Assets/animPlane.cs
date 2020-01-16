using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPlane : MonoBehaviour {

    #region VARIABLES
    public Animator anim;
    #endregion


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        anim.speed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
         
	}

    //Button functions
    public void Animate()
    {
        anim.Play("fly", -1, 0f);
        anim.speed = 1f;
    }
}
