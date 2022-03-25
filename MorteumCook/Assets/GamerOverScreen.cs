using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamerOverScreen : MonoBehaviour
{

    public Text pointText;
    public void setup(int score) 
    {
        gameObject.SetActive(true);
        pointText.text = score.ToString() + "POINTS";
                           
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
           
      public void RestarButton()
    {
        SceneManager.LoadScene("Escenario");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenuEsb");
    }
         
            

}
