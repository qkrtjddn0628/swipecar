using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App2 : MonoBehaviour
{
    private Vector3 mouseDownPosition;
    private float yDir;
    public List<GameObject> arrGo;


    void Start()
    {

    }

    //�̺�Ʈ �Լ� 
    private void Update()
    {
        //���� ���콺 ��ư�� �������� ��� 
        //0: left button
        bool isDown = Input.GetMouseButtonDown(0);

        bool isUp = Input.GetMouseButtonUp(0);
        

        if (isDown)
        {
            Debug.Log("ȭ���� �������ϴ�.");

            this.mouseDownPosition = Input.mousePosition;

        }
        else if (isUp)
        {
            Debug.Log("���콺�� �������ϴ�.");
            Vector3 mouseUpPosition = Input.mousePosition;

            //Debug.Log($"{this.mouseDownPosition}, {mouseUpPosition}");

            this.yDir = mouseUpPosition.y - this.mouseDownPosition.y;

            //Debug.Log($"{this.yDir}");

            if (this.yDir > 0)
            {
                //��� 
                Debug.Log("�������� �������� �׼��� ��!");
                
                //this.transform.Translate(0, this.yDir, 0, Space.World);
            }
            else if (this.yDir < 0)
            {
                //���� 
                Debug.Log("�Ʒ���");
                //this.transform.Translate(0, this.yDir, 0, Space.World);
            }

        }
        this.yDir = this.yDir / 5000.0f;
        this.transform.Translate(0, this.yDir, 0, Space.World);
        //this.yDir *= 0.096f;


    }
}