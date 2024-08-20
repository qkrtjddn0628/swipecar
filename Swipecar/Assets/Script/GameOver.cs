using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject textGo;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���ӿ����� �����Ǿ����ϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        // 1. �� ������Ʈ ã�ƿ���
        GameObject flagGo = GameObject.Find("flag");
        GameObject carGo = GameObject.Find("car");

        // 2. �� ������Ʈ ��ġ�� �������� ã��
        float flagGoVec = flagGo.transform.position.x;
        float carGoVec = carGo.transform.position.x;

        // 3. �� ��ġ���� ���Ͻ� �����ϱ�
        if(flagGoVec == carGoVec)
        {
            Text text = textGo.GetComponent<Text>();
            text.text = $"GameOver";
        }
    }
}
