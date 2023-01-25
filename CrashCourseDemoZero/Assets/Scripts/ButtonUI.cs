using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string cible;
    public void PlayButton(){
        SceneManager.LoadScene(cible);
    }

    public void doExitGame() {
        Application.Quit();
    }
}

