using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Homebrew;

public class PanelInfoCaps : MonoBehaviour {

    [SerializeField]
    public GameObject PanelInfo;

    public EvolutionPokemon EvolutionPokemonScr;

    [Foldout("PanelInfoPokemon", true)]
    [Header("Main")]
    public Image imgCaps;
    public Text nameCaps;
    public Text descriptionCaps;
    public Text qualCaps;


    [Header("Panel Stat")]
    public Text chansCaps;
    public Text capsToEvol;

    [Header("Panel Type")]
    public Text rarity;
    public Text numEvolution;

    [Header("Panel Evolution")]
    public Text ButtEvolPrice;
    public Button ButtEvol;

    private int QualCapsAll;
    // Use this for initialization

    private void Start()
    {
        QualCapsAll = gameObject.transform.childCount;
    }
    public void InfoOpenCaps(int idCaps) {
        if (PanelInfo.activeSelf == false)
            PanelInfo.SetActive(true);
        for (int i = 0; i < QualCapsAll; i++) {
            if (gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().idCaps == idCaps) {

                imgCaps.sprite = gameObject.transform.GetChild(i).GetComponent<Image>().sprite;

                nameCaps.text = gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().nameCaps;

                descriptionCaps.text = gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().descriptionCaps;

                qualCaps.text = "Количество: "+gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps;

                ButtEvolPrice.text = "Эволюция: " + gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().MoneyToEvolution;

                capsToEvol.text = "Кэпсов до эволюции: " + gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().CapsToEvolution;

                CheckButtEvol(i);

                chansCaps.text = "Шанс: " + gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().ChanceOfSuccess + "%";

                switch (gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().rarity.ToString()) {
                    case "Common":
                        rarity.text = "Обычный";
                        break;
                    case "Rare":
                        rarity.text = "Редкий";
                        break;
                    case "Epic":
                        rarity.text = "Эпический";
                        break;
                    case "Legend":
                        rarity.text = "Легендарный";
                        break;
                }

                switch (gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().evolution.ToString())
                {
                    case "First":
                        numEvolution.text = "Эволюция 1";
                        break;
                    case "Second":
                        numEvolution.text = "Эволюция 2";
                        break;
                    case "Third":
                        numEvolution.text = "Эволюция 3";
                        break;
                }

                //параметры для эволюции нужного кэпса
                EvolutionPokemonScr.moneyToEvolution = gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().MoneyToEvolution;
                EvolutionPokemonScr.idPokemonEvolution = gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().idCaps;
                EvolutionPokemonScr.expInEvolution = gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().ExpForEvolution;
                EvolutionPokemonScr.capsToEvolution = gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().CapsToEvolution;
                EvolutionPokemonScr.i = i;
                break;
            }
        }

    }

    public void ClosePanel(int idCaps)
    {
        PanelInfo.SetActive(false);
    }

    public void CheckButtEvol(int i) {
        if (gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().MoneyToEvolution <= UserStat.moneyUser && gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().MoneyToEvolution != 0 && gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps >= gameObject.transform.GetChild(i).GetComponent<CapsStatScr>().CapsToEvolution)
            ButtEvol.interactable = true;
        else
            ButtEvol.interactable = false;
    }
}
