using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryTable : Table
{
    public GameManager manager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty() == false){
            Recipe recipeProvided = tablePoint.transform.GetChild(0).GetComponent<Recipe>();
            if(manager.choosedRecipe  == recipeProvided.recipeAcumulator){
                manager.winPoints();
                manager.newRecipe();
                Debug.Log("Mensaje de Plato Correcto de Receta");
            }else{
                Debug.Log("Mensaje de Error de Receta");
            }
            Destroy(tablePoint.transform.GetChild(0).gameObject);
        }
                    
        
    }

    override public bool canUseTable(GameObject other){
        bool validator = false;
        if(isEmpty()){
            Recipe isRecipe = other.transform.GetComponent<Recipe>();
            if(isRecipe){
                validator =  true;
            }
        }
        return validator;
    }

    
}
