using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score = 0;//�X�R�A
    public Text scoreText;//�X�R�A��UI

    private float horizontalInput;
    [SerializeField] private float speed;
    [SerializeField] private float xRange;
    [SerializeField] private GameObject projectilePrefab;//�H�ו��v���n�u�i���Ƃŕ����j

    void Start()
    {
        //UI��������
        score = 0;
        SetCountText(0);
    }
    public void SetCountText(int point)
    {
        // �X�R�A�����Z���܂�
        score += point;

        // �X�R�A�̕\�����X�V
        scoreText.text = "score: " + score.ToString();

    }



    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput 
                * Time.deltaTime * speed);
        if(transform.position.x < -xRange) {
            transform.position = new Vector3(   -xRange, 
                                                transform.position.y,
                                                transform.position.z);
        }
        if(xRange < transform.position.x ) {
            transform.position = new Vector3(   xRange,
                                                transform.position.y,
                                                transform.position.z);
        }
        //�X�y�[�X�L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.Space)) {
            //�����ŐH�ו��𕡐�����i���̎g�����A�Ƃ��������\�b�h���o���āI�j
            Instantiate(    projectilePrefab, 
                            transform.position,
                            projectilePrefab.transform.rotation);
        }
        
    }

}
