#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Example : SerializedMonoBehaviour
{
    [BoxGroup("Skill_Editor")]
    public int[,] Data_A = new int[3, 3]; //九宫格
    public int[][] Data_B = new int[3][];
}

#endif