using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerJump _pj;
    [SerializeField]
    [Header("スピード")]
    float speed = 3f;
    [SerializeField]
    [Header("えあースピード")]
    float airSpeed = 1f;
    float moveX = 0f;
    float moveZ = 0f;
    private Rigidbody rb;
    [SerializeField]
    [Header("ゲームオーバーのパネル")]
    GameObject _gameOverPanel;
    [SerializeField]
    [Header("ゲームクリアのパネル")]
    GameObject _gameCrealPanel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _pj = GetComponent<PlayerJump>();
    }
    void Update()
    {
        float s = 0;
        float g = 0;
        if (_pj.IsGround)
        {
            s = speed;
        }
        else
        {
            s = airSpeed;
            g = -0.98f;
        }
        moveX = Input.GetAxis("Horizontal") * s;
        moveZ = Input.GetAxis("Vertical") * s;
        rb.AddForce(new Vector3(moveX, g, moveZ));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IGoal goal))
        {
            goal.Goal();
            Destroy(gameObject);
            _gameCrealPanel.SetActive(true);
        }

        if (other.TryGetComponent(out IDeath death))
        {
            death.Death();//こんな感じに書いてもらえればおっけー
            Destroy(this.gameObject);
            _gameOverPanel.SetActive(true);
        }
    }
}
