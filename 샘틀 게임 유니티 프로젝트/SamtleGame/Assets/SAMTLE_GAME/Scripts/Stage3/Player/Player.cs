﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MIT.SamtleGame.Stage3
{
    public class Player : MonoBehaviour
    {
        public GameObject _playerModel;
        public PlayerController3D _controller;

        private void Update() {
            _playerModel.transform.localPosition = Vector3.zero;
        }
    }   
}
