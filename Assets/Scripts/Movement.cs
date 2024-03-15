using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public float speed;


    void Start()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
      

    }

    private void PrintPosition()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Sea pulsado el espacio");
            Debug.Log("Posicion en X:" + this.transform.position.x);
            Debug.Log("Posicion en Y:" + this.transform.position.y);
            Debug.Log("Posicion en Z:" + this.transform.position.z);


        }
    }


    private void checkMovement()
    {
        PrintPosition();
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Button ");
            this.transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.transform.position += Vector3.back * speed;
        }

    }
}
