using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinerCaps : MonoBehaviour {

    public GameObject Panel;
    public GameObject EndGamePanel;

    public static int[] winCaps;

    public GameObject WinPanelMenuCaps;


    private void Start()
    {
        winCaps = new int[8];
    }


    public void WinnerCapsCheck(GameObject Cap) {
        for (int i = 0; i < Panel.transform.childCount; i++)
        {


            if (Panel.transform.GetChild(i).GetComponent<Image>().sprite == null)
            {
                Sprite screenSprite = Resources.Load<Sprite>("Images/Caps/" + Cap.GetComponent<MeshRenderer>().material.mainTexture.name);
                Panel.transform.GetChild(i).GetComponent<Image>().sprite = screenSprite;
                winCaps[i] = Cap.GetComponent<CapsStatScr>().idCaps;

                for (int c = 0; c < UserStat.pokemonCapsUser.Length / 2; c++)
                {
                    if (UserStat.pokemonCapsUser[c, 0] == winCaps[i])
                    {
                        //UserStat.pokemonCapsUser[c, 1]++;
                        PlayerPrefs.SetInt("IdPok-" + c.ToString(), PlayerPrefs.GetInt("IdPok-" + c.ToString()) +1); ;
                        break;
                    }

                }

                break;
            }

        }
        Destroy(Cap);

        StartCoroutine(CountChild());
    }

    IEnumerator CountChild() {
        yield return new WaitForSeconds(0.2f);
        for (int i = 0; i < gameObject.transform.childCount; i++) {
            gameObject.transform.GetChild(i).GetComponent<ChekCaps>().ChekCapsDask();
        }
        if (gameObject.transform.childCount == 0) {
            WinnerPanel();
        }
    }

    void WinnerPanel() {
        for (int i = 0; i < Panel.transform.childCount; i++)
        {
            if (Panel.transform.GetChild(i).GetComponent<Image>().sprite != null)
            {

                WinPanelMenuCaps.transform.GetChild(i).GetComponent<Image>().sprite = Panel.transform.GetChild(i).GetComponent<Image>().sprite;
               
            }

        }

        EndGamePanel.SetActive(true);
    }

    public void MenuMainButt() {
        SceneManager.LoadScene("Game");
    }
}
