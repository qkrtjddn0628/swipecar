using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject textGo;   // �ؽ�Ʈ ������ �ʵ�� �����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ��� ã��
        // 1��° ��� GameObject.Find(string name) ����ϱ�
        GameObject flagGo = GameObject.Find("flag");
        GameObject carGo = GameObject.Find("car");

        // �Ÿ��� ����ϱ�.
        float flagGoVec = flagGo.transform.position.x;
        float carGoVec = carGo.transform.position.x;

        int distance = (int)flagGoVec - (int)carGoVec;

        Debug.Log(flagGoVec);
        Debug.Log(carGoVec);
        Debug.Log($"�Ÿ� : {distance}");

        Text text = textGo.GetComponent<Text>();
        text.text = $"�Ÿ� : {distance}";


        //// 3. �� ��ġ���� ���Ͻ� �����ϱ�
        //if (flagGoVec == carGoVec)
        //{
        //    text.text = "GameOver";
        //}
    }

}
