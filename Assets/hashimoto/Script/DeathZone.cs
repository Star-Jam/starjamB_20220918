using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// これに触れたらゲームオーバーになる
/// </summary>
public class DeathZone : MonoBehaviour,IDeath
{
    public void Death()
    {
        Debug.Log("死んだ");//tryGetComponentでtagつけなくてすむ
    }
}
