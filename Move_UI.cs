using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_UI : MonoBehaviour {
    public RectTransform RT, MoveTile;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance (RT.position, MoveTile.position) > 1)
            RT.position = Vector3.Lerp (RT.position, MoveTile.position, 2f * Time.deltaTime);
        else {
            RT.position = MoveTile.position;
            // 이동한 타일의 이벤트 or 몬스터와 전투 실행
        }
    }
}
