using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : Table
{
    public FoodContainer[] containers;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty() == false){
            Destroy(tablePoint.transform.GetChild(0).gameObject);

            foreach (FoodContainer container in containers){
                container.increaseNumber();
            }

        }
    }

     override public bool canUseTable(GameObject other){
         if(other.GetComponent<Animal>()){
             return true;
         }else{
             return false;
         }
     }
}
