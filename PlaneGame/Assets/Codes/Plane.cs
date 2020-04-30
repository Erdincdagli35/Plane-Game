using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Plane : MonoBehaviour {

    public float speed, heightSpeed,distanCe,scoreDis;
    public Transform startLine;
    public Text distanceText,distanceGameOver,scoreDistance;
    public GameObject gameisDonePanel,gamePanel,startPanel;
	void Start () {
      
        gameisDonePanel.SetActive(false);
        gamePanel.SetActive(false);
        startPanel.SetActive(true);
        speed = 0;
        heightSpeed = 0;
        GetComponent<Rigidbody2D>().gravityScale = 0;
	}
	
	void Update () {

        distanCe = Vector2.Distance(startLine.position,transform.position );
        distanceText.text = (int)distanCe + "  M";
        transform.Translate(speed*Time.deltaTime,0,0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * heightSpeed);
        }
	}
    void OnTriggerEnter2D(Collider2D nesne)
    {
        if (nesne.gameObject.tag=="Go")
        {
            GameObject gameObject1 = nesne.gameObject;
            gameObject1.transform.root.gameObject.GetComponent<Road>().active=true;

        }
    }
    void OnCollisionEnter2D(Collision2D nesne)
    {
        if (nesne.gameObject.tag=="Barrier")
        {
            Time.timeScale = 0;
            GameOverr();
        }
    }
    public void buttons(int b)
    {
        if (b==0)
        {
            speed = 5;
            heightSpeed = 200;
            GetComponent<Rigidbody2D>().gravityScale = 1;
            gamePanel.SetActive(true);
            gameisDonePanel.SetActive(false);
            startPanel.SetActive(false);

        }
    }
    public void GameOverr()
    {
        gamePanel.SetActive(false);
        startPanel.SetActive(false);
        gameisDonePanel.SetActive(true);
        distanceGameOver.text = "DISTANCE : "+(int)distanCe + " M";
        scoreDis = PlayerPrefs.GetFloat("NEW HIGH SCORE");
        if (scoreDis>distanCe)
        {
            scoreDistance.text = "HIGH SCORE :  "+(int)scoreDis+" M";
        }
        else
        {
            scoreDis = distanCe;
            PlayerPrefs.SetFloat("NEW HIGH SCORE : ",scoreDis);
            scoreDistance.text = "HIGH SCORE :  " + (int)scoreDis + " M"; 
        }
        
    }
    



}
