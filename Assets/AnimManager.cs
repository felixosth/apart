﻿using UnityEngine;
using System.Collections;

public class AnimManager : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {


	
	}

    public void GoToMenu()
    {
        animator.SetTrigger("ToMenu");
    }

    public void GoToCredits()
    {
        animator.SetTrigger("ToCredits");
    }
}
