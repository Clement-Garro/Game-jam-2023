using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string start = "Scene_Start";
    public void PlayButton(){
        SceneManager.LoadScene(start);
    }
}
