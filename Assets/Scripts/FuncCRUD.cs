using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Homebrew;

public class FuncCRUD : MonoBehaviour
{

    [Foldout("Scripts", true)]
    public UserInfoPanel UserInfoPanelScr;
    public UserStat UserStatScr;
    public PanelInfoCaps PanelInfoCapsScr;

    [Foldout("Game Objects", true)]
    public GameObject PokedeskParent;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BuyMoney(int count)
    {
        if (UserStat.moneyUser >= count)
            UserStat.moneyUser = UserStat.moneyUser - count;
        UserInfoPanelScr.UpdateInfoUser();
    }

    public void AddMoney(int count)
    {
        UserStat.moneyUser = UserStat.moneyUser - count;
        UserInfoPanelScr.UpdateInfoUser();
    }

    public void AddPokemon(int idPokemon, int count)
    {
        for (int i = 0; i < UserStatScr.QualCapsAll; i++)
        {
            if (PokedeskParent.transform.GetChild(i).GetComponent<CapsStatScr>().idCaps == idPokemon)
            {
                PokedeskParent.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps += count;
                UserStatScr.QualCapsAllArray();
                PokedeskParent.transform.GetChild(i).GetComponent<PokeInfoStat>().QualCaps();
                
                break;
            }
        }
    }

    public void DelPokemon(int idPokemon, int count)
    {
        for (int i = 0; i < UserStatScr.QualCapsAll; i++)
        {
            if (PokedeskParent.transform.GetChild(i).GetComponent<CapsStatScr>().idCaps == idPokemon)
            {
                PokedeskParent.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps -= count;
                UserStatScr.QualCapsAllArray();
                PokedeskParent.transform.GetChild(i).GetComponent<PokeInfoStat>().QualCaps();
                PanelInfoCapsScr.InfoOpenCaps(idPokemon);
                break;
            }
        }
    }
}
