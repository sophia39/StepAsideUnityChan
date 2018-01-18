using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    

    // Use this for initialization
    void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {

        float position = gameObject.transform.position.z;
        var unitiyChan = GameObject.Find("unitychan").transform.position.z;
        if (position < unitiyChan - 10)
        {
            Destroy(gameObject);
        }

    }
}
