using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    int a;
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");
        a = 10;

        a = 20;
        int b = 50;
        a = 60;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
