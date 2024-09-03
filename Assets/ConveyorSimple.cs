using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorSimple : MonoBehaviour
{
    public float speed;
    Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody=GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position -= transform.right * speed * Time.fixedDeltaTime; //y軸無論是什麼，物體都能沿著傳送帶導軌方向移動
        rBody.MovePosition(pos);
    }
    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
