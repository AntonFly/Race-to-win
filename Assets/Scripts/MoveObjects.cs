using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speed = 1.2f;
    
    public GameObject TargetObj; 
    private SpawnCars _actionTarget;
    

    public void Start()
    {
        _actionTarget = TargetObj.GetComponent<SpawnCars>();
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));

        if(transform.position.y < -6)
        	Destroy(gameObject);//
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
