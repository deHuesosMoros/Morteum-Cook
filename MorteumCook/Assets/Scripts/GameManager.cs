using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject animalPrefab;
    public IngredientType[] combinations = new IngredientType[11];
    public IngredientType choosedRecipe;
    public int playerScore;

    void Start()
    {
        newRecipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindObjectOfType(typeof(Animal)) == null)
        {
            GameObject newAnimal = Instantiate(animalPrefab);
            newAnimal.transform.position = this.transform.position;
            
        }
    }

    public void winPoints(){
        playerScore++;
    }

    public void newRecipe(){
        choosedRecipe = combinations[Random.Range(0,9)];
         Debug.Log(choosedRecipe.ToString());
    }

}
