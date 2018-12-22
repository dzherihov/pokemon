using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokeInfoStat : MonoBehaviour {
    private int quantityCaps;
    private CapsStatScr CapsStatScr;
    private Text QualText;
    // Use this for initialization
    void Start () {

        QualCaps();
        CheckQualCaps();
    }


    public void QualCaps() {
        CapsStatScr = gameObject.GetComponent<CapsStatScr>();
        quantityCaps = CapsStatScr.quantityCaps;
        QualText = gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
        QualText.text = quantityCaps.ToString();
    }

    void CheckQualCaps() {
        if(quantityCaps <=0 ) {
            gameObject.GetComponent<Button>().interactable = false;
            QualText.text = " ";
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
