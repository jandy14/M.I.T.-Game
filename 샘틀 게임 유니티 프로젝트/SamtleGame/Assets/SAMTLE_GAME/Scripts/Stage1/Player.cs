﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MIT.SamtleGame.Stage1
{

    public class Player : MonoBehaviour
    {
        public PlayerController _controller;
        public static Vector3 _pos;

        [Header("플레이어 정보")]
        public int _maxHp = 100;
        public int _currentHp = 100;

        private void Start() 
        {
            _controller = GetComponent<PlayerController>();
        }

        void Update() 
        {
            _pos = this.gameObject.transform.position;
        }

        public Vector3 Pos { get { return _pos; } }
    }
}
