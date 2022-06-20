using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeslocamentoBG_script : MonoBehaviour
{
    public GameObject cam;
    public float parallaxEffetc;
    private float largura, altura, positionX, positionY;

    private void Start()
    {
        largura = GetComponent<SpriteRenderer>().bounds.size.x;
        altura = GetComponent<SpriteRenderer>().bounds.size.y;
        positionX = transform.position.x;
        positionY = transform.position.y;

    }

    private void Update()
    {
        float parallaxDistancex = cam.transform.position.x * parallaxEffetc;
        float remanejaDistanciax = cam.transform.position.x * (1 - parallaxEffetc);
        float parallaxDistancey = cam.transform.position.y * parallaxEffetc;
        float remanejaDistanciay = cam.transform.position.y * (1 - parallaxEffetc);

        transform.position = new Vector3(positionX + parallaxDistancex, parallaxDistancey, transform.position.z);
        if (remanejaDistanciax > positionX + largura) 
        {
            positionX += largura;
        }
        if (remanejaDistanciay > positionY + altura)
        {
            positionY += altura;
        }
    }

    /*private Transform cameraTransform;
     private Vector3 lastCameraPosition;


     void Start() {
         cameraTransform = GameObject.Find("FaseVermelha_Raiva").transform;
         lastCameraPosition = cameraTransform.position;
     }

     void LateUpdate(){
         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
         transform.position += deltaMovement;
         lastCameraPosition = cameraTransform.position;
     }*/


    /* private float startPos;
     private float length;
     private GameObject cam;
     [SerializeField] private float parallaxEffect;
     [SerializeField] private bool endless = true;

     void Start()
     {
         cam = GameObject.Find("FaseVermelha_Raiva");
         startPos = transform.position.x;
         length = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
     }

     void LateUpdate()
     {
         float distance = cam.transform.position.x * parallaxEffect;
         float temp = cam.transform.position.x * (1 - parallaxEffect);

         transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

         if (endless)
         {
             if (temp > startPos + length)
             {
                 startPos += length;
             }
             else if (temp < startPos - length)
             {
                 startPos -= length;
             }
         }
     }*/
}