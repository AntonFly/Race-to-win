using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveRoad : MonoBehaviour
{
	public float speed = 2.2f;
	public GameObject road;
    
    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.down * (speed * Time.deltaTime));

        if(transform.position.y < -11f){
        	Instantiate(road, new Vector3(0.004f,13.4f,0), Quaternion.identity);
        	Destroy(gameObject);
        }
    }
}
