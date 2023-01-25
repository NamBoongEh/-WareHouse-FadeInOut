using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

public class JsonSetting : MonoBehaviour {
   public float FadeIn;
   public float FadeOut;

    public class Data
    {
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

        FadeIn = myData.FadeIn;
        FadeOut = myData.FadeOut;
    }

}
