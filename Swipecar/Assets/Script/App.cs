using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    // 벡터의 뺄셈을 연습
    // 필드를 만들자 A,b (GameObject)
    public GameObject A;
    public GameObject B;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

        //A.GetComponent<Transform>();
        Vector3 a = A.transform.position;
        Vector3 b = B.transform.position;

        Debug.Log(a);   // 위치 벡터
        Debug.Log(b);   // 위치 벡터


        //b - a = c
        Vector3 c = b - a;  // 방향 벡터 (크기, 방향)
        Debug.Log(c);
        
        // 위치, 방향, 시간, 색갈, 모양
        DrawArrow.ForDebug(a, c, 100, Color.yellow, ArrowType.Solid);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
