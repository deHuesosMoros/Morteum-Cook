using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchAndRelease : MonoBehaviour
{
    public Animator chefAnimController;
    private GameObject handPoint;
    private GameObject pickedObject = null;

    void Awake()
    {
        handPoint = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            chefAnimController.SetTrigger("Grab");
        }  
    }

    private void OnTriggerStay(Collider other){
        canGrabSomething(other);
        if(Input.GetKey("r")){
            Table table = other.gameObject.GetComponent<Table>();
            if(pickedObject != null){
                CatchableObjects catchableObject = pickedObject.gameObject.GetComponent<CatchableObjects>();
                if(table && table.canUseTable(pickedObject))
                {                   
                    chefAnimController.SetBool("hasGrabbed", false);
                    pickedObject.GetComponent<Rigidbody>().useGravity = true;
                    pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                    pickedObject.gameObject.transform.position =  table.tablePoint.transform.position;
                    pickedObject.gameObject.transform.SetParent(table.tablePoint.transform);
                    pickedObject = null;
                } 
            }
            
        }       
    }

    public void grabSomething(GameObject other){
        other.GetComponent<Rigidbody>().useGravity = false;
        other.GetComponent<Rigidbody>().isKinematic = true;

        CatchableObjects catchableObject = other.gameObject.GetComponent<CatchableObjects>();
        if (catchableObject != null)
        {
            chefAnimController.SetBool("hasGrabbed", true);
            if (catchableObject.GetType() == typeof(Animal))
            {                
                Animal animal = catchableObject as Animal;
                animal.SetGrabbed();
            }
        }

        other.transform.position = handPoint.transform.position;
        other.gameObject.transform.SetParent(handPoint.gameObject.transform);
        pickedObject = other.gameObject;
    }

    public void canGrabSomething(Collider other){
        if(Input.GetKey("e") && pickedObject== null){


            FoodContainer food = other.gameObject.GetComponent<FoodContainer>();
            CatchableObjects catchable = other.gameObject.GetComponent<CatchableObjects>();
            if(catchable){
                grabSomething(other.gameObject);

            }else if(food){
                if(food.amountFood > 0 ){
                GameObject foodPicked = Instantiate(food.prefabFood);
                grabSomething(foodPicked);
                food.decreaseNumber();
                }
            }
             
        }

    }

   
}
