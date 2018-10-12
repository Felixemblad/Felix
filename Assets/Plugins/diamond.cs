using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class diamond : MonoBehaviour
{
    public int controller;
    [Range(-720, 720)]
    public float rotatichoinSpeed;
    public Transform turn;
    [Range(-720, 720)]
    public int speed;
    public SpriteRenderer rend;
    public float timer;
    public float seconds = 1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {     //nertryckning av olika knappar 
        if (Input.GetKey(KeyCode.A)) //om du trycker A
        {
            transform.Rotate(0f, 0f, rotatichoinSpeed * 0.70f * Time.deltaTime); //snura åt vänster
            rend.color = new Color(0.0f, 0.0f, 1.0f); //färg om du trycker A
        }
        if (Input.GetKey(KeyCode.D)) //om du trycker D 
        {
            transform.Rotate(0f, 0f, -rotatichoinSpeed * Time.deltaTime); //snura åt höger långsamare än om du svänger om vänster 
            rend.color = new Color(0.0f, 1.0f, 0.0f); //färg om du trycker D 
        }

        transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);  //hastig het inställningar i unity
        if (Input.GetKey(KeyCode.S)) //om du trycker S
        {
            transform.Translate(-speed / 2 * Time.deltaTime, 0, 0, Space.Self); //saktar ned farten med 50% om du trycker på S
        }
        print(timer + 1); //skriv ut timer 
        timer = timer + 1 * Time.deltaTime; //om tiden är lika med tidern som den alltid är läg till 1 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));

        }


    }

}   //Time.delatatime = rörelse operoande av fpsen 
