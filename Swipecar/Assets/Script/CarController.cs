using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    
    Vector3 startPos;
    private float moveSpeed =0;

    public GameObject textGo;


    void Start()
    {       

    }

    // Update is called once per frame
    void Update()
    {
        //스와이프 길이를 구한다
        if(Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 때었을 때 좌표
            Vector3 endPos = Input.mousePosition;
            float dirX = (endPos.x = this.startPos.x);

            // 스와이프 길이를 처음 속도로 변경한다
            //this.moveSpeed = dirX / 5000.0f;

            if (dirX > 0)
            {
                moveSpeed = 0.1f;
            }
            else if (dirX < 0)
            {
                moveSpeed = -0.1f;
            }
        }
        this.transform.Translate(moveSpeed, 0, 0);
        this.moveSpeed *= 0.98f;

    }
}
