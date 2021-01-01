using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Transform BG1;
    public Transform BG2;
    private float size;

    private Vector3 cameraTargetPos = new Vector3();
    private Vector3 BG1TargetPos = new Vector3();
    private Vector3 BG2TargetPos = new Vector3();
    
    BoxCollider2D camColliderBox;
    public Vector3 centerCamColliderBox;

    void Start()
    {
        size = BG1.GetComponent<BoxCollider2D>().size.y;
        size = BG2.GetComponent<BoxCollider2D>().size.y;
        camColliderBox = GetComponent<BoxCollider2D>();

    }

    void FixedUpdate()
    {

        centerCamColliderBox = camColliderBox.bounds.center;
        //old: (Input.GetKey(KeyCode.UpArrow)) && ...
        if ((target.transform.position.y >= centerCamColliderBox.y))
        {
            Vector3 targetPos = SetPos(cameraTargetPos, target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, 0.5f);
            //transform.position = targetPos;

            if (transform.position.y >= BG2.position.y)
            {
                BG1.position = SetPos(BG1TargetPos, BG1.position.x, BG2.position.y + size, BG1.position.z);
                SwitchingBG();
            }

            if (transform.position.y <= BG1.position.y)
            {
                BG1.position = SetPos(BG2TargetPos, BG1.position.x, BG2.position.y - size, BG1.position.z);
                SwitchingBG();
            }
        }

    }


    private void SwitchingBG()
    {
        Transform temp = BG1;
        BG1 = BG2;
        BG2 = temp;
    }

    private Vector3 SetPos(Vector3 pos, float x, float y, float z)
    {
        pos.x = x;
        pos.y = y;
        pos.z = z;
        return pos;
    }

}
