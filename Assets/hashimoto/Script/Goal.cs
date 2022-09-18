using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// GoalInterface‚ğŒp³‚µ‚½Script
/// </summary>
public class Goal : MonoBehaviour,IGoal
{
    void IGoal.Goal()
    {
        Debug.Log("ƒS[ƒ‹‚µ‚Ü‚µ‚½");
    }
}
