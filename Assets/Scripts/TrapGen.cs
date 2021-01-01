using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGen : MonoBehaviour
{
    MeterCounter altitudeCounter;
    CameraController camBoxCenter;

    public GameObject[] trapsArray;
    int limiter;

    [SerializeField] GameObject trapContainer;

    void Start()
    {
        GameObject metercounterScriptRef = GameObject.Find("MeterTxt");
        altitudeCounter = metercounterScriptRef.GetComponent<MeterCounter>();

        GameObject cameracontrollerScriptRef = GameObject.Find("Main Camera");
        camBoxCenter = cameracontrollerScriptRef.GetComponent<CameraController>();
        limiter = 0;

    }

    void LateUpdate()
    {
        Debug.Log("ALTITUDECOUNTER: " + altitudeCounter.altitudeint);
        Debug.Log("CAMCENTER: " + camBoxCenter.centerCamColliderBox.y);

        if (altitudeCounter.altitudeint % 10 == 0 && altitudeCounter.altitudeint == limiter)
            {
                limiter += 10;
                Debug.Log("instantiation point");
                InstantiateTrap();            
            }

        
    }

    void InstantiateTrap()
    {
       Debug.Log("instantiated.");

       Vector3 trapsPos = new Vector3(0f, camBoxCenter.centerCamColliderBox.y + 15f, -3f);
       Instantiate(trapsArray[UnityEngine.Random.Range(0, 10)], trapsPos, Quaternion.identity, trapContainer.transform);
    }
}
