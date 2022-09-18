using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    [Header("ゲームオーバーのパネル")]
    GameObject _gameOverPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDeath death))
        {
            death.Death();//こんな感じに書いてもらえればおっけー
            Destroy(this.gameObject);
            _gameOverPanel.SetActive(true);
        }
    }
}
