using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerJump _pj;
    [SerializeField]
    [Header("�X�s�[�h")]
    float speed = 3f;
    [SerializeField]
    [Header("�����[�X�s�[�h")]
    float airSpeed = 1f;
    float moveX = 0f;
    float moveZ = 0f;
    private Rigidbody rb;
    [SerializeField]
    [Header("�Q�[���I�[�o�[�̃p�l��")]
    GameObject _gameOverPanel;
    [SerializeField]
    [Header("�Q�[���N���A�̃p�l��")]
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
            death.Death();//����Ȋ����ɏ����Ă��炦��΂������[
            Destroy(this.gameObject);
            _gameOverPanel.SetActive(true);
        }
    }
}
