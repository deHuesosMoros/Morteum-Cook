using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : Table
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty() == false){
            Destroy(tablePoint.transform.GetChild(0).gameObject);

            FoodContainer[] containers = this.transform.GetComponentsInChildren<FoodContainer>();

            foreach (FoodContainer container in containers){
                container.increaseNumber();
            }

        }
    }
}
