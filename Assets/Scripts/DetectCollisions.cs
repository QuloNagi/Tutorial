using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
    [SerializeField] int point;

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        player = GameObject.Find("Player");//プレイヤーを見つける
        pc = player.GetComponent<PlayerController>();//PlayerContorollerを保存
        pc.SetCountText(point);//Playerが持つScoreに対して加算する
        Destroy(gameObject);//アタッチされている自分自身を消す
        Destroy(other.gameObject);//ぶつかった相手（other）を消す
    }
}
