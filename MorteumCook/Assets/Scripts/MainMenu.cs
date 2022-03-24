using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject canvasControl;
    public GameObject canvasMenu;
    public GameObject canvasGuia;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

    }

    public void EscenaJuego()

    {
        //SceneManager.LoadScene("Game");
        SceneManager.LoadScene("Escenario");
    }

    public void EscenaControl(string nombreGuia)

    {
        canvasMenu.SetActive(false);
        canvasControl.SetActive(true);
        //SceneManager.LoadScene("EscControl");
    }

    public void ShowMenu()
    {


    }

    public void Salir()
    {
        Application.Quit();

    }

    public void Volver()

    {
        canvasControl.SetActive(false);
        canvasMenu.SetActive(true);
        //SceneManager.LoadScene("MainMenuEsb");

        canvasGuia.SetActive(false);
        canvasMenu.SetActive(true);
    }

    public void Guia()
    {

        SceneManager.LoadScene("McGuia");
    }

        
       
    
    public void Guia(string nombreGuia)

    {
        canvasGuia.SetActive(true);
      canvasMenu.SetActive(false);
      
    }
 }