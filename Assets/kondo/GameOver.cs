using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    [Header("�Q�[���I�[�o�[�̃p�l��")]
    GameObject _gameOverPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDeath death))
        {
            death.Death();//����Ȋ����ɏ����Ă��炦��΂������[
            Destroy(this.gameObject);
            _gameOverPanel.SetActive(true);
        }
    }
}
