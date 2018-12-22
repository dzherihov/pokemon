using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CapsJump : MonoBehaviour {
    public static float lenthForce;
    private float xDir, yDir, zDir;


    public void AddForceCaps() {
        yDir = Random.Range(17f, 22f);
        xDir = Random.Range(-0.5f, 0.5f);
        zDir = Random.Range(-0.5f, 0.5f);
        gameObject.GetComponent<Rigidbody>().AddForce(xDir, yDir, zDir, ForceMode.Impulse);
        transform.Rotate(zDir*35f, zDir* 35f, zDir* 35f);
    }
}
