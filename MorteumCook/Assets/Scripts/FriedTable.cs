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
        if(isEmpty() == false){
            Ingredient ingredient =  tablePoint.transform.GetChild(0).GetComponent<Ingredient>();            
            ingredient.isCooked = true; 
        }

        
    }

    override public bool canUseTable(GameObject other){
        if(isEmpty()){
            if(other.transform.GetComponent<Ingredient>().type.ToString() == "Bone"){
                    return true;               
            }else{
                return false;
            }
        }else{
            return false;
        }

    }
}
