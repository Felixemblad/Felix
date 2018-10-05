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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {     //nertryckning av olika knappar 
        if (Input.GetKey(KeyCode.A)) //om du trycker A
        {
            transform.Rotate(0f, 0f, rotatichoinSpeed * Time.deltaTime); //snura åt vänster
            rend.color = new Color(0.0f, 0.0f, 1.0f); //färg om du trycker A
        }
        if (Input.GetKey(KeyCode.D)) //om du trycker D 
        {
            transform.Rotate(0f, 0f, -rotatichoinSpeed * Time.deltaTime); //snura åt höger
            rend.color = new Color(0.0f, 1.0f, 0.0f); //färg om du trycker D 
        }

        transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);  //hastig het inställningar i unity
        if (Input.GetKey(KeyCode.S)) //om du trycker S
        {
          transform.Translate(-speed * Time.deltaTime, 0, 0, Space.Self); //går bakåt stannar
        }
    }
}
