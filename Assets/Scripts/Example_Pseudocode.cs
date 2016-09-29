using UnityEngine;
using System.Collections;

public class Example_Pseudocode : MonoBehaviour {

    public Vector3 pos = Vector3.zero;
    public float speed = 0.2f;

    Vector3 Movement (float dist)
    {
        Vector3 vec = Vector3.zero;

        if(Input.GetKey(KeyCode.A))
        {
            vec.x -= dist;
        }
        if(Input.GetKey(KeyCode.D))
        {
            vec.x += dist;
        }
        if(Input.GetKey(KeyCode.W))
        {
            vec.z += dist;
        }
        if(Input.GetKey(KeyCode.S))
        {
            vec.z -= dist;
        }
        return vec;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Movement(speed);
	}
}
