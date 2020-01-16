using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayVowels()
    {
        SceneManager.LoadScene("Vowels");
    }
	
    public void GoToVowels()
    {
        SceneManager.LoadScene("Vowels");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToVowelsGame()
    {
        SceneManager.LoadScene("AlphabetMenu");
    }


    public void GoTo_A_Letter()
    {
        SceneManager.LoadScene("ARPsycho_A_Letter");
    }

    public void GoTo_E_Letter()
    {
        SceneManager.LoadScene("ARPsycho_E_Letter");
    }

    public void GoTo_I_Letter()
    {
        SceneManager.LoadScene("ARPsycho_I_Letter");
    }

    public void GoTo_O_Letter()
    {
        SceneManager.LoadScene("ARPsycho_O_Letter");
    }

    public void GoTo_U_Letter()
    {
        SceneManager.LoadScene("ARPsycho_U_Letter");
    }
}
