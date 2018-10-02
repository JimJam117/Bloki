using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 PaddlePos = new Vector3(8f, -5.5f, 0f);

        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        PaddlePos.x = Mathf.Clamp( mousePosInBlocks, 0.5f, 15.5f);

        this.transform.position = PaddlePos;
    }
}
