using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Homebrew;
using UnityEngine.SceneManagement;


public class ControllerButtMenu : MonoBehaviour {

    [Foldout("Menu panel", true)]
    public GameObject PokedeskPanel;
    public GameObject StartPandel;
    public GameObject ShopPanel;

    // Use this for initialization
    void Start () {
		
	}

    public void OpenPokedeskMenu() {
        if (PokedeskPanel.activeSelf == false)
            PokedeskPanel.SetActive(true);
        if (StartPandel.activeSelf == true)
            StartPandel.SetActive(false);
        if (ShopPanel.activeSelf == true)
            ShopPanel.SetActive(false);
    }

    public void OpenStartMenu()
    {
        if (PokedeskPanel.activeSelf == true)
            PokedeskPanel.SetActive(false);
        //if (StartPandel.activeSelf == false)
        //    StartPandel.SetActive(true);
        if (ShopPanel.activeSelf == true)
            ShopPanel.SetActive(false);
        //SceneManager.LoadScene("GameBattle");
        SceneManager.LoadScene("Stavki");
    }

    public void OpenShopMenu()
    {
        if (PokedeskPanel.activeSelf == true)
            PokedeskPanel.SetActive(false);
        if (StartPandel.activeSelf == true)
            StartPandel.SetActive(false);
        if (ShopPanel.activeSelf == false)
            ShopPanel.SetActive(true);
    }

}
