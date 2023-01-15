using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public string prefix;

    public void Start()
    {
        RequireComponent.RequireNotEmptyThrow(this, prefix);
    }

    public void DoLog(string log)
    {
        Debug.Log(prefix + ' ' + log);
    }
}
