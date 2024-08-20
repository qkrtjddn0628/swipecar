using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingStarsController : MonoBehaviour
{
    private Vector3 mouseDownPosition;

    //public List<GameObject> throwingStars;

    void Start()
    {

    }

    //이벤트 함수 
    private void Update()
    {
        

        //Z축으로 회전한다 
        this.transform.Rotate(0, 0, -0.1f);

        //Y축으로 이동합니다.
        //this.transform.Translate(0, 0.001f, 0, Space.World);


    }
}