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

    //�̺�Ʈ �Լ� 
    private void Update()
    {
        

        //Z������ ȸ���Ѵ� 
        this.transform.Rotate(0, 0, -0.1f);

        //Y������ �̵��մϴ�.
        //this.transform.Translate(0, 0.001f, 0, Space.World);


    }
}