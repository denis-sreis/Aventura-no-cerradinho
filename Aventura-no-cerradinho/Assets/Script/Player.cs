using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 8f;
    public float forcaPulo = 8f;
    



    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {

        rig = GetComponent<Rigidbody2D>();
   

    }

    // Update is called once per frame
    void Update()
    {
        movimentos();
        pulo();
        
    }


    void movimentos()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movimento * Time.deltaTime * velocidade;


    }

    void pulo()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rig.AddForce(new Vector2(0f,forcaPulo), ForceMode2D.Impulse);

        }
    }





    

}
