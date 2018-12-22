using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCaps : MonoBehaviour {

    public GameObject ParentPanel;

    void Start () {
            for (int i = 0; i < ParentPanel.transform.childCount; i++)
            {
                if (UserStat.pokemonCapsUser[i, 0] == ParentPanel.transform.GetChild(i).GetComponent<CapsStatScr>().idCaps)
                {
                    ParentPanel.transform.GetChild(i).gameObject.SetActive(true);
                    ParentPanel.transform.GetChild(i).GetComponent<CapsStatScr>().quantityCaps = UserStat.pokemonCapsUser[i, 1];
                }
        }
        
	}	
	// Update is called once per frame
	void Update () {
		
	}
}
