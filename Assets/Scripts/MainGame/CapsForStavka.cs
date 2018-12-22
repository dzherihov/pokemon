using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsForStavka : MonoBehaviour {

    public GameObject[] Caps;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < StavksScr.stavkaCaps.Length; i++) {
            for (int j = 0; j < Caps.Length; j++) {
                if (StavksScr.stavkaCaps[i] == Caps[j].GetComponent<CapsStatScr>().idCaps) {
                    GameObject Cap = Instantiate(Caps[j], transform.position, transform.rotation) as GameObject;
                    Cap.transform.parent = gameObject.transform;
                    Cap.transform.rotation = Quaternion.Euler(0, 180, 180);
                    break;
                }
            }
            for (int m = 0; m < gameObject.transform.childCount; m++)
            {
                gameObject.transform.GetChild(m).transform.position = new Vector3(-0.5f, -0.59f + (0.04f * (m + 1)), -0f);
            }
        }	
	}
}
