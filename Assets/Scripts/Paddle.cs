using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 22f;
    [SerializeField] float speed = 0.08f;
    [SerializeField] float horizontalMove = 0f;
    private Joystick joystick;

    // cached refrences
    GameSession theGameSession;
    Ball theBall;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
    }
    void Update()
    {
        horizontalMove += joystick.Horizontal * speed;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(horizontalMove, minX, maxX);
        transform.position = paddlePos;
    }
}
