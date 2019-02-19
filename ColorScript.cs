using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      GetComponent<Rigidbody>().velocity = new Vector3(2,2,5);
    }

    void OnMouseDown()
    {
      if (GetComponent<Rigidbody>().velocity.z < 0 && GetComponent<Transform>().position.z < 0 && GetComponent<Transform>().position.z >= - 3){
        GetComponent<Rigidbody>().velocity = new Vector3(-3, 2, 8);
      }
      if (GetComponent<Rigidbody>().velocity.z < 0 && GetComponent<Transform>().position.z < -3 && GetComponent<Transform>().position.z >= - 6){
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 4, 8);
      }
      if (GetComponent<Rigidbody>().velocity.z < 0 && GetComponent<Transform>().position.z < -6 && GetComponent<Transform>().position.z >= -10){
        GetComponent<Rigidbody>().velocity = new Vector3(1, 6, 8);
      }
    }



    // Update is called once per frame
    void OnCollisionEnter (Collision col)
    {
      if (col.gameObject.name == "Racket" && GetComponent<Rigidbody>().position.y <= 2){
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 8, -8);
      }
      if (col.gameObject.name == "Racket" && GetComponent<Rigidbody>().position.y > 2 && GetComponent<Rigidbody>().position.y <= 5){
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, -8);
      }
      if (col.gameObject.name == "Racket" && GetComponent<Rigidbody>().position.y > 5) {
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 4, -8);
      }
     }
    void Update()
    {

    }
}
