﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCanopy : MonoBehaviour
{

    ShakeCanopy shakeCanopy;
    public string buttonTag;
     
    void Start(){
        shakeCanopy = GetComponent<ShakeCanopy>();
    }

    void HandleTouch(){
        if(Input.touchCount > 0){

            if(Input.GetTouch(0).phase == TouchPhase.Began){
                Touch touch = Input.GetTouch(0);
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit)){
                    if(hit.collider.gameObject.tag != buttonTag){
                        Debug.Log("Not a hotdog");
                        return;
                    }
                    
                    hit.collider.gameObject.GetComponent<ShakeCanopy>().PlayParticles();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        HandleTouch();
    }
}
