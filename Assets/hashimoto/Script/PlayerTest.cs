using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �v���C���[�̃e�X�gScript
/// </summary>
public class PlayerTest : MonoBehaviour
{
    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDeath death))
        {
            death.Death();//����Ȋ����ɏ����Ă��炦��΂������[
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IDeath death))
        {
            death.Death();
        }
    }
}
