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
        // 1. 찍고 땐 좌포 두개를 가져온다
        // 2. 두개의 좌표 x축을 서로 뺀다
        // 3. 양수가 나오면 +, 음수가 나오면 -
        // 4. 그값이 양수냐 음수냐에 if문을 써서 검사를 한다.
        // 5. 해당 값을 변수에 넣고 움직이는 값에 넣는다.

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
