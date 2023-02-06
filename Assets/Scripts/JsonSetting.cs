using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

public class JsonSetting : MonoBehaviour {
    
    /*
     * 1번 코드로 fade inout
     * 2번 애니메이션으로 fade inout
     * 3번 코드로 fade in만
     * 4번 코드로 fade out만
     * 5번 애니메이션으로 fade in만
     * 6번 애니메이션으로 fade out만
    */
    public int AniType;

    public float FadeIn;
    public float FadeOut;

    public class Data
    {
        public int AniType;
        public float FadeIn;
        public float FadeOut;
    }

    void Awake()
    {
        Load();
    }

    //데이터 불러오기
    void Load()
    {
        string FromJsonData = File.ReadAllText(Application.streamingAssetsPath + "/Controller.json");

        Data myData = JsonUtility.FromJson<Data>(FromJsonData);

        AniType = myData.AniType;
        FadeIn = myData.FadeIn;
        FadeOut = myData.FadeOut;
    }

}
