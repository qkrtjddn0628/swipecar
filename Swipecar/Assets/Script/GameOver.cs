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
        Debug.Log("게임오버가 생성되었습니다.");
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 각 오브젝트 찾아오기
        GameObject flagGo = GameObject.Find("flag");
        GameObject carGo = GameObject.Find("car");

        // 2. 두 오브젝트 위치값 갱신으로 찾기
        float flagGoVec = flagGo.transform.position.x;
        float carGoVec = carGo.transform.position.x;

        // 3. 두 위치값이 동일시 반응하기
        if(flagGoVec == carGoVec)
        {
            Text text = textGo.GetComponent<Text>();
            text.text = $"GameOver";
        }
    }
}
