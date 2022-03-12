using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerObjetos : MonoBehaviour
{
    private GameObject handPoint;
    private GameObject pickedObject = null;

    void Awake()
    {
        handPoint = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerStay(Collider other){
        agarrar(other);
        if(Input.GetKey("r")){
            Mesa mesa = other.gameObject.GetComponent<Mesa>();
            ElementoReceta elemento = pickedObject.gameObject.GetComponent<ElementoReceta>();
            if(mesa){
                GameObject mesaPoint = mesa.transform.GetChild(0).gameObject;
                if(elemento.revisarSoltar(mesaPoint)){
                    pickedObject.GetComponent<Rigidbody>().useGravity = true;
                    pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                    pickedObject.gameObject.transform.position =  mesaPoint.transform.position;
                    pickedObject.gameObject.transform.SetParent(mesaPoint.transform);
                    pickedObject = null;
                }
            } 
        }       
    }

    public void agarrar(Collider other){
        if(Input.GetKey("e") && pickedObject== null){
             if(other.gameObject.GetComponent<ElementoReceta>()){

                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = handPoint.transform.position;
                other.gameObject.transform.SetParent(handPoint.gameObject.transform);
                pickedObject = other.gameObject;

             } else if(other.gameObject.GetComponent<Animal>()) {
                 
             } 
             
        }

    }

    public void soltar(){

        if(Input.GetKey("r")){
            if(pickedObject != null){
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;
            }
        }
    }
}
