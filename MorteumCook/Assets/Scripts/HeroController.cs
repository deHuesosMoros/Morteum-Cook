using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    CharacterController controlador;
    Vector3 vectorMovimiento;
    
    public float velocidad = 100.0F;

    private void Awake(){

        controlador = GetComponent<CharacterController>();
        vectorMovimiento = Vector3.zero;    
    }

    void Update(){

        //mover();

    }

    public void mover(){

        float Ejeh = Input.GetAxis("Horizontal");
        float Ejev = Input.GetAxis("Vertical");
     
        vectorMovimiento.x = Ejeh;
        vectorMovimiento.y = 0f;
        vectorMovimiento.z = Ejev; 

        controlador.Move(vectorMovimiento * (velocidad * Time.deltaTime));

        if(vectorMovimiento != Vector3.zero){
            transform.forward = vectorMovimiento;
        }
    }


        
}
  