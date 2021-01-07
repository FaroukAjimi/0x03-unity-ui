using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int score = 0;
    public int health = 5;
    private Scene scene;
    public Text scoreText;
    public Text healthText;
    public Text winloseText;
    public Image winloseBG;
    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        health = 5;
        score = 0;
        SceneManager.LoadScene(scene.name);
    }
    // Start is called before the first frame update
    void SetScoreText(){
        scoreText.text = string.Format("Score: {0}", this.score);
    }
    void SetHealthText(){
        healthText.text = string.Format("Health: {0}", this.health);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {          
            this.score += 1;
            SetScoreText();
            other.GetComponent<Renderer>().enabled = false;
            Destroy(other);
        }
        if (other.tag == "Trap")
        {
            health -= 1;
            SetHealthText();
        }
        if (other.tag == "Goal")
        {
            winloseText.color = Color.black;
            winloseText.text = "You win!";
            winloseBG.color = Color.green;
            winloseBG.enabled = true;
            StartCoroutine(LoadScene(3));
        }
        
    }
    void Update()
    {
        if (health == 0)
        {
            winloseText.text = "Game Over!";
            winloseText.color = Color.white;
            winloseBG.color = Color.red;
            winloseBG.enabled = true;
            StartCoroutine(LoadScene(3));
        }
    }
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        rb = GetComponent<Rigidbody>();
        winloseBG.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = this.transform.position;
        pos.y = 1.200F;
        this.transform.position = pos;
        if (Input.GetKey(KeyCode.Q))
        {
            pos.x = pos.x - speed;
            this.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x = pos.x + speed;
            this.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            pos.z = pos.z + speed;
            this.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.z = pos.z - speed;
            this.transform.position = pos;
        }        
    }
}
