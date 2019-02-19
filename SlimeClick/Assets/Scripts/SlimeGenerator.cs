using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// メインカメラに入っている
/// クリックするとスライムが生成されるスクリプト
/// </summary>
public class SlimeGenerator : MonoBehaviour
{

    //スライムオブジェクトを入れる
    private GameObject[] slime = new GameObject[5];

    // Use this for initialization
    void Start()
    {
        //スライムの設定
        slime[0] = Resources.Load("Prefabs/SlimeBlue") as GameObject;
        slime[1] = Resources.Load("Prefabs/SlimeGreen") as GameObject;
        slime[2] = Resources.Load("Prefabs/SlimePurple") as GameObject;
        slime[3] = Resources.Load("Prefabs/SlimeRed") as GameObject;
        slime[4] = Resources.Load("Prefabs/SlimeYellow") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //スライムを生成
        if (Input.GetMouseButtonDown(0))
        {

            int ran = Random.Range(0, 5);
            Instantiate(slime[ran], new Vector3(0, 10, 0), slime[ran].gameObject.transform.rotation);

        }
    }
}
