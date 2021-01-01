using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapConfigsDestroy : MonoBehaviour
{
    public int id;

    EdgeCollider2D edgeCam;
    BoxCollider2D centerCam;
    BoxCollider2D centerPlayer;

    public float distance;

    void Start()
    {
        GameObject camObjScriptRef = GameObject.Find("Main Camera");
        edgeCam = camObjScriptRef.GetComponent<EdgeCollider2D>();
        centerCam = camObjScriptRef.GetComponent<BoxCollider2D>();
        GameObject playerObjScriptRef = Ga

    }

    // Update is called once per frame
    void Update()
    {        
        Debug.Log("DESTROYER?: "+edgeCam.bounds.center);

        //7.3


    }
}

