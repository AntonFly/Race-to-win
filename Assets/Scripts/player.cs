using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 3f;
    public GameObject TargetObj; 
    private SpawnCars _actionTarget;
    

    public void Start()
    {
        _actionTarget = TargetObj.GetComponent<SpawnCars>();
    }

    void Update()
    {
    // Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
    // transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

        float hor = Input.GetAxisRaw("Horizontal");
        
        Vector3 dir = new Vector3(hor, 0, 0);
        transform.Translate(dir.normalized * (Time.deltaTime * speed));

    }
    
    private void OnTriggerEnter(Collider other)
    {
        _actionTarget.GameFinish();
    }

    // private void OnCollisionStay(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Car"))
    //     {
    //         _actionTarget.GameFinish();
    //         Destroy(gameObject);
    //     }
    //
    // }
    
}
