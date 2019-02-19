using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchMovement : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
      ball = GameObject.Find("ballObj");
    }

    // Update is called once per frame
    void Update()
    {
     if (ball.transform.position.y >= 0){
        GetComponent<Transform>().position = new Vector3 (ball.transform.position.x, ball.transform.position.y, 10);
      }
    }
}
