using UnityEngine;
using System.Collections;

public struct BoxParameters
{
    public float width;
    public float height;
    public float deph;
    public Color color;
}

public class Struct : MonoBehaviour {

    public BoxParameters myParameters;

	// Use this for initialization
	void Start () {
        myParameters.width = 2;
        myParameters.height = 3;
        myParameters.deph = 4;
        myParameters.color = new Color(1, 0, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
        float h = (100 * Mathf.Sin(Time.fixedTime))/10;
        myParameters.height = h;
        UpdateCube(myParameters);
	}

    void UpdateCube(BoxParameters box)
    {
        Vector3 size = new Vector3(box.width, box.height, box.deph);
        gameObject.transform.localScale = size;
        gameObject.GetComponent<Renderer>().material.color = box.color;
    }
}
