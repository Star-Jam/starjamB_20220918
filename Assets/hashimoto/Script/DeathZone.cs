using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour,IDeath
{
    public void Death()
    {
        Debug.Log("����");//tryGetComponent��tag���Ȃ��Ă���
    }
}
