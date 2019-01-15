using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstable : MonoBehaviour {

    public int damage = 1;
    private Vector3 pos;
    public float speed = 7.5f;
    public float destroyPosition = 138f;
    private TextMeshProUGUI LifeDamage;
    private GameObject LifeText;
   // private Transform lifeText;

    // Use this for initialization
    void Start () {
        pos = transform.position;
        LifeText = GameObject.FindGameObjectWithTag("obstacle");
        LifeDamage = LifeText.GetComponent<TextMeshProUGUI>();
        
    }
	
	// Update is called once per frame
	void Update () {
        pos.y -= speed* Time.deltaTime;
        transform.position = pos;

        if (gameObject.transform.position.y < destroyPosition)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //player take damage
            collision.GetComponent<Move>().health -= damage;
            Debug.Log(collision.GetComponent<Move>().health);
            LifeDamage.text = collision.GetComponent<Move>().health.ToString();
            Destroy(gameObject);
        }
    }
}
