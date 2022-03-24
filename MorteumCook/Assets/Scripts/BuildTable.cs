using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTable : Table
{
    public GameObject dishPrefab;

   

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty()){
            GameObject newDish = Instantiate(dishPrefab);
            newDish.transform.position = tablePoint.transform.position;
            newDish.gameObject.transform.SetParent(tablePoint.gameObject.transform);
            
            
        }
    }

    override public bool canUseTable(GameObject other){
        bool validator = false;
           Ingredient ingredient = other.transform.GetComponent<Ingredient>();
           if(ingredient){
               if(ingredient.isCooked){
                   Recipe recipe = tablePoint.transform.GetChild(0).GetComponent<Recipe>();
                    IngredientType ingredientProvided = ingredient.type;
                    IngredientType recipeAcum = recipe.recipeAcumulator;
                    //if(recipeAcum.HasFlag(ingredientProvided) == false){
                        validator = true;
                        recipe.addIngredientToRecipe(ingredientProvided);
                        Destroy(other);
                    //}
               }
               
           }
            
       return validator;
    }

   

}
