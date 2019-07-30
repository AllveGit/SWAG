﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class PlayerHead : MonoBehaviour
{
    Vector3 moveVector = new Vector3(0, 0, 0);
    [SerializeField]
    protected float speed = 3.0f;
    [SerializeField]
    protected Player player = null;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        Vector3 pos = Input.mousePosition;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(pos);

        mousePos.z = 0;
        if (Vector3.Distance(transform.position, mousePos) < 0.5f) return;

        transform.position = Vector3.MoveTowards(transform.position, mousePos, 
            Time.fixedDeltaTime * speed * player.timeScale);

        Vector3 direction = mousePos - transform.position;
        direction.z = 0;

        direction.Normalize();

        float rot_z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
}
