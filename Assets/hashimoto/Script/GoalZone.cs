using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// GoalInterfaceを継承したScript
/// </summary>
public class GoalZone : MonoBehaviour,IGoal
{
    public void Goal()
    {
        Debug.Log("ゴールしました");
    }
}
