using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCanopy : MonoBehaviour
{

    ShakeCanopy shakeCanopy;
     
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
                    shakeCanopy.PlayParticles();
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
