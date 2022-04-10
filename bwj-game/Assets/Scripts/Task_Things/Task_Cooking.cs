using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task_Cooking : MonoBehaviour
{
    public GameObject FryingPan;
    public GameObject Canvas;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    void Update()
    {
        if (FryingPan.gameObject.transform.position.y <= 195
            && FryingPan.gameObject.transform.position.x <= -65
            && FryingPan.gameObject.transform.position.y >= 145
            && FryingPan.gameObject.transform.position.x >= -200)
        {
            FryingPan.gameObject.SetActive(false);
        }
    }
    
}
//failed drag and drop
    /*
    private bool isDragging;

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
    */
//for knobs, canned from other image
    /*public GameObject image;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public Button button;
    int wincondition = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (image.gameObject.activeSelf && !image4.gameObject.activeSelf)
        {
            button.onClick.AddListener(() => {
                image.SetActive(false);
                image2.SetActive(true);
            });
        }
        if (image2.gameObject.activeSelf && !image.gameObject.activeSelf)
        {
            button.onClick.AddListener(() => {
                image2.SetActive(false);
                image3.SetActive(true);
            });
        }
        if (image3.gameObject.activeSelf && !image2.gameObject.activeSelf)
        {
            button.onClick.AddListener(() => {
                image3.SetActive(false);
                image4.SetActive(true);
            });
        }
        if (image4.gameObject.activeSelf && !image3.gameObject.activeSelf)
        {
            button.onClick.AddListener(() => {
                image4.SetActive(false);
                image.SetActive(true);
            });
        }
        if (image4.gameObject.activeSelf)
        {
            wincondition = 1;
        }
        if (wincondition == 1)
        {
            //button.gameObject.SetActive(false);
        }
    }
    */

