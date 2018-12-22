using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Homebrew;

public partial class CapsStatScr : MonoBehaviour {



    Caps1Evol caps1 = new Caps1Evol();
    Caps2Evol caps2 = new Caps2Evol();
    Caps3Evol caps3 = new Caps3Evol();

    public int quantityCaps;

    [Foldout("General", true)]
    public RARITY rarity;
    public Evolution evolution;
    public int idCaps;
    public string nameCaps, descriptionCaps;
    

    [Foldout("Specifications Caps", true)]
    [Header("Stats")]
    public int CapsToEvolution;
    public int MoneyToEvolution;
    public int ExpForEvolution;
    public int ChanceOfSuccess;



    private void Awake()
    {

        
        switch (rarity)
        {
            case RARITY.Common:         
                switch (evolution)
                {
                    case Evolution.First:
                        caps1.Common();
                        Stats1();
                        break;
                    case Evolution.Second:
                        caps2.Common();
                        Stats2();
                        break;
                    case Evolution.Third:
                        caps3.Common();
                        Stats3();
                        break;
                }
                break;
            case RARITY.Rare:
                switch (evolution)
                {
                    case Evolution.First:
                        caps1.Rare();
                        Stats1();
                        break;
                    case Evolution.Second:
                        caps2.Rare();
                        Stats2();
                        break;
                    case Evolution.Third:
                        caps3.Rare();
                        Stats3();
                        break;
                }
                break;
            case RARITY.Epic:
                switch (evolution)
                {
                    case Evolution.First:
                        caps1.Epic();
                        Stats1();
                        break;
                    case Evolution.Second:
                        caps2.Epic();
                        Stats2();
                        break;
                    case Evolution.Third:
                        caps3.Epic();
                        Stats3();
                        break;
                }
                break;
            case RARITY.Legend:
                switch (evolution)
                {
                    case Evolution.First:
                        caps1.Legend();
                        Stats1();
                        break;
                    case Evolution.Second:
                        caps2.Legend();
                        Stats2();
                        break;
                    case Evolution.Third:
                        caps3.Legend();
                        Stats3();
                        break;
                }
                
                break;
        }
       
    }

    private void Stats1() {
        CapsToEvolution = caps1.CapsToEvolution;
        MoneyToEvolution = caps1.MoneyToEvolution;
        ExpForEvolution = caps1.ExpForEvolution;
        ChanceOfSuccess = caps1.ChanceOfSuccess;
    }
    private void Stats2()
    {
        CapsToEvolution = caps2.CapsToEvolution;
        MoneyToEvolution = caps2.MoneyToEvolution;
        ExpForEvolution = caps2.ExpForEvolution;
        ChanceOfSuccess = caps2.ChanceOfSuccess;
    }
    private void Stats3()
    {
        CapsToEvolution = caps3.CapsToEvolution;
        MoneyToEvolution = caps3.MoneyToEvolution;
        ExpForEvolution = caps3.ExpForEvolution;
        ChanceOfSuccess = caps3.ChanceOfSuccess;
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
