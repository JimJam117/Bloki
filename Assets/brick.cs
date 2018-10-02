using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour {

    public int maxHits = 1;
    private int timesHit = 0;
    public ball ball;
    public static int numberOfBricks = 0;


    SpriteRenderer sprite;

    public Sprite Odin;
    public Sprite Dva;
    public Sprite Tri;
    public Sprite Chiteri;
    public Sprite Pyat;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name == "Ball") {
            timesHit++;
        }

    }

    // Use this for initialization
    void Start () {

        numberOfBricks++;



        sprite = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (timesHit >= maxHits) {
            numberOfBricks--;
            Destroy(this.gameObject);
        }

        switch (maxHits - timesHit) {
            case 1:
                sprite.sprite = Odin;
                break;

            case 2:
                sprite.sprite = Dva;
                break;

            case 3:
                sprite.sprite = Tri;
                break;

            case 4:
                sprite.sprite = Chiteri;
                break;

            case 5:
                sprite.sprite = Pyat;
                break;

        }
	}
}
