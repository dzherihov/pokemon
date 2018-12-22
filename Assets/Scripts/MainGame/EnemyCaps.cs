using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCaps : MonoBehaviour {


    private CapsForStavka CapsStavScr;
	// Use this for initialization
	void Start () {

        CapsStavScr = gameObject.GetComponent<CapsForStavka>();
        for (int i = 0; i < 4; i++)
        {
            int rand = Random.Range(0,CapsStavScr.Caps.Length);
            GameObject Cap = Instantiate(CapsStavScr.Caps[rand], transform.position, transform.rotation) as GameObject;
            Cap.transform.parent = gameObject.transform;
            Cap.transform.rotation = Quaternion.Euler(0, 180, 180);

            for (int m = 0; m < gameObject.transform.childCount; m++)
            {
                gameObject.transform.GetChild(m).transform.position = new Vector3(-0.5f, -0.59f + (0.04f * (m + 1)), -0f);
            }
        }
    }
}
