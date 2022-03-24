using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimator : MonoBehaviour
{

    public Animator leerAnimator;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            leerAnimator.SetBool("Grab", true);
            leerAnimator.SetBool("hasGrabbed", true);

        }



        if (Input.GetKeyDown(KeyCode.R))
        {
            leerAnimator.SetBool("Grab", false);
            leerAnimator.SetBool("hasGrabbed", false);

        }





        if (Input.GetAxis("Horizontal")>0 || Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
        {
            leerAnimator.SetBool("Walking", true);
        
        }
        else 
        {
            leerAnimator.SetBool("Walking", false);

        }

    }
}
