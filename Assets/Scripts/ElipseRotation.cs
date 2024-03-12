using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllipseRotation : MonoBehaviour
{
    [SerializeField] //Para verlo en unity
    private GameObject sun;

    public float a = 5f;
    public float b = 2.5f;

    private float ang = 0;

    public float speed;

    private float x;
    private float y;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckRotation();
    }

    private void CheckRotation()
    {
        ang += Time.deltaTime * speed;
        x = a * Mathf.Cos(ang);
        y = b * Mathf.Sin(ang);

        transform.position = new Vector3(x + sun.transform.position.x + 2, 0, y + sun.transform.position.y);
    }
}