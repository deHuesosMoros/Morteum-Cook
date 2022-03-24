using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookTable : Table
{
    public float timeCook = 0;
    public RawImage progres;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty() == false){
            if(tablePoint.transform.GetChild(0).GetComponent<Ingredient>().isCooked == false){
                timeCook ++;

                if(timeCook >= 80){
                Cooked(tablePoint.transform.GetChild(0).GetComponent<Ingredient>()); 
            } 
            }
        }else{
            timeCook = 0;
        }
    }
}
