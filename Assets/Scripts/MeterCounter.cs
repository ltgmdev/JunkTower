using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using TMPro;

public class MeterCounter : MonoBehaviour
{

    //cam center etc
    public BoxCollider2D camBox;
    Vector3 centerCamBox;
    public float altitude;
    public int altitudeint;

    //meter counter
    private TextMeshProUGUI textMesh;

    void Start()
    {
        camBox = GameObject.Find("Main Camera").GetComponent<BoxCollider2D>();
        
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        centerCamBox = camBox.bounds.center;
        altitude = centerCamBox.y;
        altitudeint = (int)Mathf.Round(altitude * 100f) / 100;

        textMesh.text = ("Meters: "+ altitude.ToString("F1"));
    }


}
