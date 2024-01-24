using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerB : MonoBehaviour
{









    void Start()
    {

    }

    [SerializeField] private Animator myAnimationController;




    void Update()
    {





            // Input Special Move

            if (Input.GetKey(KeyCode.E))
            {
                myAnimationController.SetBool("SPMove", true);
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                myAnimationController.SetBool("SPMove", false);
            }

        

            // left
            if (Input.GetKey(KeyCode.A))
            {

                myAnimationController.SetBool("MovingL", true);

                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    myAnimationController.SetBool("RunningL", true);
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    myAnimationController.SetBool("RunningL", false);
                }

            }
            else
            {
                myAnimationController.SetBool("MovingL", false);

            }

            // right
            if (Input.GetKey(KeyCode.D))
            {

                myAnimationController.SetBool("MovingR", true);

                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    myAnimationController.SetBool("RunningR", true);
                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    myAnimationController.SetBool("RunningR", false);
                }
            }
            else
            {
                myAnimationController.SetBool("MovingR", false);

            }


            // jump
            if (Input.GetKey(KeyCode.Space))
            {
                myAnimationController.SetBool("Jump", true);
            }
            else
            {
                myAnimationController.SetBool("Jump", false);
            }

    }
}

