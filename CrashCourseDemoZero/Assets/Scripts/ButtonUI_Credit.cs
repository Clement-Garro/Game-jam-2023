using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI_Credit : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject credit;

    public void AfficheCredit(){
        menu.SetActive(false);
        credit.SetActive(true);
    }

    public void EnleveCredit(){
        credit.SetActive(false);
        menu.SetActive(true);
    }
}