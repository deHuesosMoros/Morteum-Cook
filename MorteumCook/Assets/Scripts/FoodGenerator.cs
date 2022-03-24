using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : Table
{
    public FoodContainer[] containers;
    public Crusher chrush;
    public bool canIncrease = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty() == false){
            if(canIncrease == true){
                foreach (FoodContainer container in containers){
                container.increaseNumber();    
                }
            }
            
            canIncrease = false;
        //chrush.Crushing();
        Destroy(tablePoint.transform.GetChild(0).gameObject, 1);
            
        }
    }

    override public bool canUseTable(GameObject other){
         bool validator = false;
         if(isEmpty()){
             if(other.GetComponent<Animal>()){
                validator = true;
                canIncrease = true;
            }
         }
            
         return validator;
     } 
}
