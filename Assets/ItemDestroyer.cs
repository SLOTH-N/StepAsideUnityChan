using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (this.transform.position.z < GameObject.Find("unitychan").transform.position.z-5) Destroy(this.gameObject);
        
    }
   


}
