using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// GoalInterfaceを継承したScript
/// </summary>
public class Goal : MonoBehaviour,IGoal
{
    void IGoal.Goal()
    {
        Debug.Log("ゴールしました");
    }
}
