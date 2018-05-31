﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweepe
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Tile : MonoBehaviour
    {
        public int x, y;
        public bool isMine = false;
        public bool isRevealed = false;
        [Header("Refrences")]
        public Sprite[] emptySprites;
        public Sprite[] mineSprites;
        private SpriteRenderer rend;

        void Awake()
        {
            rend = GetComponent<SpriteRenderer>();
        }
        void Start()
        {
            isMine = Random.value < .05f;
        }
        public void Reveal(int adjacentMines, int mineState = 0)
        {
            isRevealed = true;
            if (isMine)
            {
                rend.sprite = mineSprites[mineState];
            }
            else
            {
                rend.sprite = emptySprites[adjacentMines];
            }
        }
    }
}
