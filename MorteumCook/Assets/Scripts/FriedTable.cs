using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriedTable : Table
{
    //public IngredientType ingredientEnum;
    //public IngredientType ingredient2;



    // Start is called before the first frame update
    void Start()
    {
        //ValidateIngredient(ingredientEnum);
        //AddIngredient(ingredientEnum);
        //AddIngredient(ingredient2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //RemoveIngredient(ingredientEnum);
            //ValidateRecipe();
        }

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
