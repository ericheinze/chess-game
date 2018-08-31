using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject wPawn1;

    // Use this for initialization
    void Start () {

        wPawn1 = GameObject.Find("W_Pawn_2D (8)");
        Debug.Log ("Hello World");

        wPawn1.transform.position = new Vector3(10, 10, 0);

        
    }

    // Update is called once per frame
    void Update () {

        Debug.Log(wPawn1.transform.position);
        


    }
}
