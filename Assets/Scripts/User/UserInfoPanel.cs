using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Homebrew;

public class UserInfoPanel : MonoBehaviour {
    private UserStat UserStatScr;

    [Foldout("User GameObjects", true)]
    public Text lvlUser;
    public Text moneyUser;
    // Use this for initialization
    void Start () {
        UserStatScr = gameObject.GetComponent<UserStat>();
        UpdateInfoUser();
	}

    public void UpdateInfoUser() {
        lvlUser.text = "Level: " + UserStat.levelUser;
        moneyUser.text = "Money: " + UserStat.moneyUser;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
