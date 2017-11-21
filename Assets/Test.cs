using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    private bool _Anonymous;
    private bool _AnonymousLamda;

    private bool _Closure;
    private bool _ClosureLamda;

    private bool _Predefined;

    private bool _CacheDele;

    private Action _Dele;
    private Action _Dele2;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 300, 150), "Anonymous"))
        {
            _Clear();
            _Anonymous = true;
        }

        if (GUI.Button(new Rect(500, 50, 300, 150), "AnonymousLamda"))
        {
            _Clear();
            _AnonymousLamda = true;
        }

        if (GUI.Button(new Rect(50, 300, 300, 150), "Closure"))
        {
            _Clear();
            _Closure = true;
        }

        if (GUI.Button(new Rect(500, 300, 300, 150), "ClosureLamda"))
        {
            _Clear();
            _ClosureLamda = true;
        }

        if (GUI.Button(new Rect(50, 550, 300, 150), "Predefined"))
        {
            _Clear();
            _Predefined = true;
        }

        if (GUI.Button(new Rect(500, 550, 300, 150), "CacheDele"))
        {
            _Clear();
            _CacheDele = true;
        }

        if (GUI.Button(new Rect(50, 800, 300, 150), "ClearAll"))
        {
            _Clear();
        }
    }

    private void Update()
    {
        if (_Anonymous)
        {
            _Dele = delegate() { Debug.Log("a"); };
        }

        if (_AnonymousLamda)
        {
            _Dele = () => { Debug.Log("a"); };
        }

        if (_Closure)
        {
            int v = 100;
            _Dele = delegate() { Debug.Log(v); };
        }

        if (_ClosureLamda)
        {
            int v = 100;
            _Dele = () => { Debug.Log(v); };
        }

        if (_Predefined)
        {
            _Dele = Update;
        }

        if (_CacheDele)
        {
            _Dele2 = _Dele;
        }
    }

    private void _Clear()
    {
        _Anonymous = false;
        _AnonymousLamda = false;
        _Closure = false;
        _ClosureLamda = false;
        _Predefined = false;
        _CacheDele = false;
    }
}
