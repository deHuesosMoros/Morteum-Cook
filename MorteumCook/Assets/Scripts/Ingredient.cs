using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   [System.Flags]
 public enum IngredientType
 {
     Worm = (1 << 0),
     Blood = (1 << 1),
     Bone = (1 << 2),
     Sesos = (1 << 3),
 }
public class Ingredient : CatchableObjects
{

    public IngredientType type;
    public bool isCooked; 



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(type);   
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
