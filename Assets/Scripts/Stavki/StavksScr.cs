using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StavksScr : MonoBehaviour {

    // Use this for initialization
    public static int[] stavkaCaps;
    public const int CountCapsForStavka = 4;
    public GameObject ParentPanelCaps;

    public Button StartButt;

    private int flag = 0;
	void Start () {
        stavkaCaps = new int[CountCapsForStavka];
        flag = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StavkaButt(GameObject Butt) {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {


            if (gameObject.transform.GetChild(i).GetComponent<Image>().sprite == null && (int.Parse(Butt.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text) >0))
            {
                

                Text QualText = Butt.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>(); 
                QualText.text = (int.Parse(QualText.text) - 1).ToString();


                stavkaCaps[i] = Butt.GetComponent<CapsStatScr>().idCaps;

                for (int c = 0; c < UserStat.pokemonCapsUser.Length/2; c++)
                {
                    if (UserStat.pokemonCapsUser[c, 0] == stavkaCaps[i])
                    {
                        // UserStat.pokemonCapsUser[c, 1]--;
                        PlayerPrefs.SetInt("IdPok-" + c.ToString(), PlayerPrefs.GetInt("IdPok-" + c.ToString()) -1);
                        break;
                    }

                }
                gameObject.transform.GetChild(i).GetComponent<Image>().sprite = Butt.GetComponent<Image>().sprite;
                flag++;
                if (int.Parse(Butt.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text) <= 0)
                {
                    Butt.GetComponent<Button>().interactable = false;
                }
                if (flag == CountCapsForStavka)
                {
                    StartButt.interactable = true;
                    for (int q = 0; q < ParentPanelCaps.transform.childCount; q++)
                    {
                        ParentPanelCaps.transform.GetChild(q).GetComponent<Button>().interactable = false;
                    }
                }
                else
                {
                    StartButt.interactable = false;
                }
                break;
            } 

        }
    }

    public void StartGame() {
        SceneManager.LoadScene("GameBattle");
    }
    public void MenuGame()
    {
        SceneManager.LoadScene("Game");
    }
}
