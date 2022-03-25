using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject animalPrefab;
    public IngredientType[] combinations = new IngredientType[11];
    public IngredientType choosedRecipe;
    static public int playerScore;
    public GameObject sesosRecipe;
    public GameObject wormRecipe;
    public GameObject boneRecipe;
    public GameObject bloodRecipe;
    public Text scoreText;
    
    void Start()
    {
        newRecipe();
    }

    // Update is called once per frame
    void Update()
    {   
        scoreText.text = playerScore.ToString();
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
        sesosRecipe.SetActive(true);
        boneRecipe.SetActive(true);
        bloodRecipe.SetActive(true);
        wormRecipe.SetActive(true);

        choosedRecipe = combinations[Random.Range(0,9)];
         Debug.Log(choosedRecipe.ToString());
        switch (choosedRecipe.ToString()) {
        case "Blood, Bone":
        case "Bone, Blood":
            sesosRecipe.SetActive(false);
            wormRecipe.SetActive(false);
        break; 
        case "Blood, Sesos":
        case "Sesos, Blood":
            wormRecipe.SetActive(false);
            boneRecipe.SetActive(false);
        break; 
        case "Blood, Worm":
        case "Worm, Blood":
            sesosRecipe.SetActive(false);
            boneRecipe.SetActive(false);
        break;
        case "Sesos, Bone":
        case "Bone, Sesos":
            bloodRecipe.SetActive(false);
            wormRecipe.SetActive(false);
        break;
        case "Sesos, Worm":
        case "Worm, Sesos":
            boneRecipe.SetActive(false);
            bloodRecipe.SetActive(false);
        break;
        case "Bone, Worm":
        case "Worm,Bone":
            sesosRecipe.SetActive(false);
            bloodRecipe.SetActive(false);
        break;
        case "Blood, Sesos, Worm":
        case "Blood, Worm, Sesos":
        case "Sesos, Blood, Worm":
        case "Sesos, Worm, Blood":
        case "Worm, Sesos, Blood":
        case "Worm, Blood, Sesos":
            boneRecipe.SetActive(false);
        break;
        case "Blood, Worm, Bone":
        case "Blood, Bone, Worm":
        case "Worm, Blood, Bone":
        case "Worm, Bone, Blood":
        case "Bone, Worm, Blood":
        case "Bone, Blood, Worm":
             sesosRecipe.SetActive(false);
        break;
        case "Bone, Blood, Sesos":
        case "Bone, Sesos, Blood":
        case "Blood, Sesos, Bone":
        case "Blood, Bone, Sesos":
        case "Sesos, Bone, Blood":
        case "Sesos, Blood, Bone":
            wormRecipe.SetActive(false);
        break;
        case "Sesos, Worm, Bone":
        case "Sesos, Bone, Worm":
        case "Worm, Sesos, Bone":
        case "Worm, Bone, Sesos":
        case "Bone, Worm, Sesos":
        case "Bone, Sesos, Worm":
            bloodRecipe.SetActive(false);
        break;
       
      }
    }

}
