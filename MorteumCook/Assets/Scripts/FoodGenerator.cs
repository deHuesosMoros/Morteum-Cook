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
            foreach (FoodContainer container in containers){
                container.increaseNumber();
            }
            //StartCoroutine(putAnimal());
           //Destroy(tablePoint.transform.GetChild(0).gameObject, 5.0f);
            
        }
    }

     IEnumerator putAnimal()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(3);
        Debug.Log("Final");
         
    }
    override public bool canUseTable(GameObject other){
         bool validator = false;
         if(isEmpty()){
             if(other.GetComponent<Animal>()){
                validator = true;
            }
         }
            
         return validator;
     } 
}
