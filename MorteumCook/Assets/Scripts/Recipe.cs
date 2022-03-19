using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : CatchableObjects
{
     public IngredientType recipeAcumulator;
     

    void Start()
    {
        recipeAcumulator = 0;    
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

     public void addIngredientToRecipe(IngredientType other){
             recipeAcumulator |= other;
        
    }
}
