using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float CarMoveSpeed;
    private Vector3 a;
    private Vector3 b;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isDown = Input.GetMouseButtonDown(0);
        bool isUp = Input.GetMouseButtonUp(0);
        
        // isDown = Input.mousePosition;
        // 1. ��� �� ���� �ΰ��� �����´�
        // 2. �ΰ��� ��ǥ x���� ���� ����
        // 3. ����� ������ +, ������ ������ -
        // 4. �װ��� ����� �����Ŀ� if���� �Ἥ �˻縦 �Ѵ�.
        // 5. �ش� ���� ������ �ְ� �����̴� ���� �ִ´�.

        if(isDown)
        {
            this.a = Input.mousePosition;
            //this.CarMoveSpeed += 0.05f;
        }
        else if(isUp)
        {
            this.b = Input.mousePosition;
            //this.CarMoveSpeed -= 0.096f;
        }

        Vector3 number = a - b;


        Debug.Log($"<Color=yellow>{number}</color>");
        this.transform.Translate(number);
        

    }
}
