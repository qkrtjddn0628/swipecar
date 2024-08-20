using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    // ������ ������ ����
    // �ʵ带 ������ A,b (GameObject)
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

        Debug.Log(a);   // ��ġ ����
        Debug.Log(b);   // ��ġ ����


        //b - a = c
        Vector3 c = b - a;  // ���� ���� (ũ��, ����)
        Debug.Log(c);
        
        // ��ġ, ����, �ð�, ����, ���
        DrawArrow.ForDebug(a, c, 100, Color.yellow, ArrowType.Solid);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
