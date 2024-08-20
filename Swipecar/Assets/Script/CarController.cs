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
        //�������� ���̸� ���Ѵ�
        if(Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            // ���콺 ��ư���� �հ����� ������ �� ��ǥ
            Vector3 endPos = Input.mousePosition;
            float dirX = (endPos.x = this.startPos.x);

            // �������� ���̸� ó�� �ӵ��� �����Ѵ�
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
