using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CharacterBlink : MonoBehaviour
{
    [SerializeField]
    Image eyeimage;

    [SerializeField]
    Sprite[] sparray;

    int cnt = 0;    //まばたきするタイミングカウンタ
    int blinkcnt = 60;  //まばたきするタイミング
    int aniPos = 0; //アニメーション位置
    int frate = 6; //アニメーションフレーム

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
            aniPos = frate*sparray.Length;
        }
        if(aniPos>0)
        {
            aniPos--;
            eyeimage.sprite = sparray[aniPos/frate];
        }
    }
}
