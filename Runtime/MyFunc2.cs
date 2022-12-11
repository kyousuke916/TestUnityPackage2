using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test2
{
    public class MyFunc2 : MonoBehaviour
    {
        public int Value = 0;

        public void SetValue(int value)
        {
            Value = value;
        }

        public void Execute()
        {
            Debug.Log($"MyFunc2.Execute Value:{Value} !!");
        }
    }
}