using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControll : MonoBehaviour {

    public GameObject Caps;
    public static bool chek = false;
    private int flag = 0;
    // Use this for initialization
    void Start () {
        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {

       
        if (Input.gyro.userAcceleration.y > 0.8f && chek == false)
        {
            AddForce();
        }

        if (chek == true) {
            flag = 0;
            for (int i = 0; i < Caps.transform.childCount; i++)
            {
                if (Caps.transform.GetChild(i).GetComponent<ChekCaps>().stayCaps == true)
                {
                    flag++;
                }
                if (flag == Caps.transform.childCount)
                {
                    chek = false;
                    Caps.transform.GetChild(i).GetComponent<ChekCaps>().stayCaps = false;
                }
            }
        }
    }

    public void AddForce()
    {
        for (int i = 0; i < Caps.transform.childCount; i++)
        {
            Caps.transform.GetChild(i).transform.position = new Vector3(-0.5f, -0.59f + (0.04f * (i + 1)), -0f);
            //Caps.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        for (int i = 0; i < Caps.transform.childCount; i++)
        {
            Caps.transform.GetChild(i).GetComponent<CapsJump>().AddForceCaps();
            Caps.transform.GetChild(i).GetComponent<ChekCaps>().stayCaps = false;
        }
        chek = true;
    }

    public void RestartButt() {
        SceneManager.LoadScene("GameBattle");
    }

    public void CloseButt()
    {
        SceneManager.LoadScene("Game");
    }

    public void StartForceCaps() {
        if (chek == false)
        {    
            AddForce();
        }
    }
}
