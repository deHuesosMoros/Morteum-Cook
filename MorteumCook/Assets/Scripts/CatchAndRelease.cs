using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchAndRelease : MonoBehaviour
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
        canGrabSomething(other);
        if(Input.GetKey("r")){
            Table table = other.gameObject.GetComponent<Table>();
            if(pickedObject != null){
                CatchableObjects catchableObject = pickedObject.gameObject.GetComponent<CatchableObjects>();
                if(table && table.canUseTable(pickedObject)){

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
