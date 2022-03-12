using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriedTable : Table
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty()){
            Ingredient ingredient =  tablePoint.transform.GetChild(0).GetComponent<Ingredient>();            
            ingredient.isCooked = true; 
        }

        
    }

    public bool canUseTable(GameObject other){
        if(isEmpty()){
            return true;
        }else{
            return false;
        }

    }
}
