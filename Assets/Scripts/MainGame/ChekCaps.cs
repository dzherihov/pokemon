using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekCaps : MonoBehaviour {


    private RaycastHit info;
    private int mask = 1 << 8;
    public bool stayCaps = false;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, -transform.up * 4f, Color.yellow);
        }

    void OnTriggerStay(Collider other)
    {
        if (other.name == "Desk" && (gameObject.GetComponent<Rigidbody>().velocity.y <= 0.0007f && gameObject.GetComponent<Rigidbody>().velocity.y >= -0.0007f) && GameControll.chek == true) {
                ChekCapsDask();
            stayCaps = true;
        }
    }   

    public void ChekCapsDask() {
        if (Physics.Raycast(transform.position, -transform.up, out info, 4f, mask))
        {
            transform.root.GetComponent<WinerCaps>().WinnerCapsCheck(gameObject);
        }
    }


}
