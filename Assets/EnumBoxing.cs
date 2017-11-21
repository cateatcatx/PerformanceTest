using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumBoxing : MonoBehaviour
{
    enum MyEnum
    {
        A,
        B,
        C,
    };

    Dictionary<MyEnum, object> dic;
    Dictionary<MyEnum, object> dic2;
    object o = null;
    private bool Mode1;
    private bool Mode2;

    void Start()
    {
        dic = new Dictionary<MyEnum, object>();
        dic.Add(MyEnum.A, null);

        dic2 = new Dictionary<MyEnum, object>(new MyEnumComparer());
        dic2.Add(MyEnum.A, null);
    }

    void Update()
    {
        if (Mode1)
        {
            o = dic[MyEnum.A];
        }

        if (Mode2)
        {
            o = dic2[MyEnum.A];
        }
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 300, 150), "Mode1"))
        {
            Mode2 = false;

            Mode1 = true;
        }

        if (GUI.Button(new Rect(500, 50, 300, 150), "Mode2"))
        {
            Mode1 = false;

            Mode2 = true;
        }

        if (GUI.Button(new Rect(50, 300, 300, 150), "Stop"))
        {
            Mode2 = false;
            Mode1 = false;
        }
    }


    private class MyEnumComparer : IEqualityComparer<MyEnum>
    {
        public bool Equals(MyEnum x, MyEnum y)
        {
            return x == y;
        }

        public int GetHashCode(MyEnum obj)
        {
            return (int)obj;
        }
    }
}
