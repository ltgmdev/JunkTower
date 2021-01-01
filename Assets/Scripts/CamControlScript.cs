using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControlScript : MonoBehaviour
{
    [SerializeField] public float speed;
    public Transform player;

    private Vector3 contrPos = new Vector3();
    private Vector3 contrFollowPlayer = new Vector3();

    void Awake()
    {
        Vector3 contrPos = GameObject.Find("CamControl").transform.position;
    }

    void FixedUpdate()
    {
        Debug.Log("PLAYERPOS:"+ player.position.y);
        Debug.Log("CONTROLLERPOS:"+ contrPos.y);   
        
        //if (Input.GetKey(KeyCode.UpArrow))
            //{
                if (player.position.y >= (Screen.width / 2))
                {
                Debug.Log("It is");
            //transform.Translate(Vector3.up * speed * Time.deltaTime);
                //contrPos.y = player.position.y;
                Vector3 followP = SetPos(contrFollowPlayer, player.position.x, player.position.y, transform.position.z);
        }
            //}    

    }

    private Vector3 SetPos(Vector3 pos, float x, float y, float z)
    {
        pos.x = x;
        pos.y = y;
        pos.z = z;
        return pos;
    }
}
