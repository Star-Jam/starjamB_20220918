using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����ɐG�ꂽ��Q�[���I�[�o�[�ɂȂ�
/// </summary>
public class DeathZone : MonoBehaviour,IDeath
{
    public void Death()
    {
        Debug.Log("����");//tryGetComponent��tag���Ȃ��Ă���
    }
}
