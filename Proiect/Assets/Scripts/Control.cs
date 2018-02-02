using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    // Use this for initialization
    public float speed = 10.0F;  
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        float translationv = Input.GetAxis("Vertical") * speed;
        float translationo = Input.GetAxis("Horizontal") * speed;
        translationv += Time.deltaTime;
        translationo += Time.deltaTime;

        transform.Translate(translationo, 0, translationv);
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

    }
}
