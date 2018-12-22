using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Homebrew;

public class UserStat : MonoBehaviour {
    [SerializeField]
    private GameObject Pokedesk;
    [HideInInspector]
    public int QualCapsAll;

    [Foldout("General", true)]
    public string nameUser;
    [SerializeField]
    public static int moneyUser = 5000;
    [SerializeField]
    public static int levelUser = 1;

    [Foldout("Statistik", true)]
    public float pokestrayk;

    public static int[,] pokemonCapsUser;

    // Use this for initialization
    void Awake () {
        //PlayerPrefs.DeleteAll();
        QualCapsAll = Pokedesk.transform.childCount;
        pokemonCapsUser = new int[QualCapsAll, 2];
        QualCapsAllArray();

    }

    public void QualCapsAllArray() {
        for (int i = 0; i < QualCapsAll; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    pokemonCapsUser[i, j] = Pokedesk.transform.GetChild(i).GetComponent<CapsStatScr>().idCaps;
                }
                if (j == 1)
                    if (pokemonCapsUser[i, 0] != 0) {
                        if (!PlayerPrefs.HasKey("IdPok-" + i.ToString()))
                        {
                            PlayerPrefs.SetInt("IdPok-" + i.ToString(), Random.Range(0, 5));
                        }
                        pokemonCapsUser[i, j] = PlayerPrefs.GetInt("IdPok-" + i.ToString());
                        Pokedesk.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps = pokemonCapsUser[i, j];
                    } else
                    {
                        Pokedesk.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps = 0;
                    }

                    //pokemonCapsUser[i, j] = Pokedesk.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps;
            }
        }
        //Debug.Log(pokemonCapsUser.Length / 2);
    }

    public void QualCapsAllArray2()
    {
        for (int i = 0; i < QualCapsAll; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    pokemonCapsUser[i, j] = Pokedesk.transform.GetChild(i).GetComponent<CapsStatScr>().idCaps;
                }
                if (j == 1)
                    if (pokemonCapsUser[i, 0] != 0)
                    {
                        Pokedesk.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps = pokemonCapsUser[i, j];
                    }
                    else
                    {
                        Pokedesk.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps = 0;
                    }

             
            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
