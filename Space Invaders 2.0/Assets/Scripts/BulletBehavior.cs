using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {
    public float moveBy = 0.001f;
	// Use this for initialization
	
    void Start () {
        InvokeRepeating("MoveBullet", 0, 0.01f);	
	}
	
    void MoveBullet(){
        Vector3 position = gameObject.transform.position;
        Vector3 newPosition = new Vector3(position.x, position.y + moveBy, 0f);
        gameObject.transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Alien"){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
