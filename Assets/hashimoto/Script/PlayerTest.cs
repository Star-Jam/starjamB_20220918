using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            death.Death();//Ç±ÇÒÇ»ä¥Ç∂Ç…èëÇ¢ÇƒÇ‡ÇÁÇ¶ÇÍÇŒÇ®Ç¡ÇØÅ[
        }
    }
}
