using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    bool isStart = true;

    [SerializeField]
    JsonSetting jsonSetting;

    public bool[] fadeNum = new  bool[6]; 

    // Start is called before the first frame update
    void Start()
    {
        if(jsonSetting.AniType != 0)
        {
            Fade(jsonSetting.AniType);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fade(int n)
    {
        Debug.Log("테스트 " + n);

    /*
     * 1번 코드로 fade inout
     * 2번 애니메이션으로 fade inout
     * 3번 코드로 fade in만
     * 4번 코드로 fade out만
     * 5번 애니메이션으로 fade in만
     * 6번 애니메이션으로 fade out만
    */

        switch (n)
        {
                case 1:
                {
                    Debug.Log("코드 fade in out");
                    break;
                }
        }
    }
}
