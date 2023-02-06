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
        Debug.Log("�׽�Ʈ " + n);

    /*
     * 1�� �ڵ�� fade inout
     * 2�� �ִϸ��̼����� fade inout
     * 3�� �ڵ�� fade in��
     * 4�� �ڵ�� fade out��
     * 5�� �ִϸ��̼����� fade in��
     * 6�� �ִϸ��̼����� fade out��
    */

        switch (n)
        {
                case 1:
                {
                    Debug.Log("�ڵ� fade in out");
                    break;
                }
        }
    }
}
