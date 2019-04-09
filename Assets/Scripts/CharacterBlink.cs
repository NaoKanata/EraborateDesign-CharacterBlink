using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CharacterBlink : MonoBehaviour
{

    [SerializeField]
    Sprite[] sparray;

    int cnt = 0;
    int blinkcnt = 60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cnt++;
        cnt%=blinkcnt;
        if(cnt==0)
        {
            // 瞬きする処理
        }
    }
}
