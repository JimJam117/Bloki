using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour {

    public paddle Paddle;
    private bool hasLaunched = false;
    private float ballDistance;
    public Vector2 minspeed = new Vector2(5f,5f);
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<AudioSource>().Play();
        Vector2 tweak = new Vector2(Random.Range(0.0f, 0.5f), Random.Range(0.0f, 0.5f));
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity += tweak;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        SceneManager.LoadScene("Lose");
        
    }


    // Use this for initialization
    void Start () {
        ballDistance = this.transform.position.y - Paddle.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        if (!hasLaunched) {
            this.transform.position = new Vector3(Paddle.transform.position.x, -4.11f, 0f);
        }

        

        if(Input.GetMouseButtonDown(0)){
            hasLaunched = true;   
           rigidbody.velocity = new Vector2(2f, 10f);
        }

        if (hasLaunched) {
            
        }
	}
}
