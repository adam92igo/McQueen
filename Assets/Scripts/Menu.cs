using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// pour pouvoir changer la scène
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // pour avoir accès au boutons
    public void Jouer()
    {
        // pour recharger la scene
        SceneManager.LoadScene("menu");
    }

    
    public void Exit()
    {
        // pour quitter l'app Unity
        Application.Quit();
    }
}
