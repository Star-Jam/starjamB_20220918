using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// GoalInterface���p������Script
/// </summary>
public class Goal : MonoBehaviour,IGoal
{
    void IGoal.Goal()
    {
        Debug.Log("�S�[�����܂���");
    }
}
