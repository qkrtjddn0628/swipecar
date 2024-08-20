using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject textGo;   // 텍스트 파일을 필드로 만들기

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 깃발 찾기
        // 1번째 방법 GameObject.Find(string name) 사용하기
        GameObject flagGo = GameObject.Find("flag");
        GameObject carGo = GameObject.Find("car");

        // 거리를 출력하기.
        float flagGoVec = flagGo.transform.position.x;
        float carGoVec = carGo.transform.position.x;

        int distance = (int)flagGoVec - (int)carGoVec;

        Debug.Log(flagGoVec);
        Debug.Log(carGoVec);
        Debug.Log($"거리 : {distance}");

        Text text = textGo.GetComponent<Text>();
        text.text = $"거리 : {distance}";


        //// 3. 두 위치값이 동일시 반응하기
        //if (flagGoVec == carGoVec)
        //{
        //    text.text = "GameOver";
        //}
    }

}
