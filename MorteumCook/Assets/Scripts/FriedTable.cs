using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriedTable : Table
{
    public int timeCook = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isEmpty() == false){
            timeCook ++;
            Debug.Log("Está entrando");
            if(timeCook >= 300){
                Cooked(tablePoint.transform.GetChild(0).GetComponent<Ingredient>()); 
                timeCook = 0;
            } 
        }else{
            timeCook = 0;
        }
        
    }

    

    
}
