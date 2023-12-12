using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{

	public Image sprite;

	


    // Start is called before the first frame update
    void Start()
    {
    	sprite.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) {
        	sprite.enabled = true;
        }
        else {
        	sprite.enabled = false;
        }
    }
}
