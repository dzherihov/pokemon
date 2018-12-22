using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionPokemon : MonoBehaviour {

    public FuncCRUD funcCRUDScr;
    public PanelInfoCaps PanelInfoCapsScr;

    [HideInInspector]
    public int idPokemonEvolution;
    [HideInInspector]
    public int moneyToEvolution;
    [HideInInspector]
    public int expInEvolution;
    [HideInInspector]
    public int capsToEvolution;
    [HideInInspector]
    public int i;

    // Use this for initialization
    public void EvolutionPokemonButt() {
        funcCRUDScr.BuyMoney(moneyToEvolution);
        funcCRUDScr.DelPokemon(idPokemonEvolution, capsToEvolution);
        funcCRUDScr.AddPokemon(idPokemonEvolution+1, 1);
        PanelInfoCapsScr.CheckButtEvol(i);
    }
}
