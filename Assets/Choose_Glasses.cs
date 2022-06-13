using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Choose_Glasses : MonoBehaviour
{
    public GameObject Glasses1;
    public GameObject Glasses2;
    public GameObject Glasses3;

    Button Glasses1Button;
    Button Glasses2Button;
    Button Glasses3Button;
    Button Scale_plus;
    Button Scale_minus;

    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        Glasses1Button=GameObject.Find("Canvas/Glasses1_Button").GetComponent<Button>();
        Glasses2Button=GameObject.Find("Canvas/Glasses2_Button").GetComponent<Button>();
        Glasses3Button=GameObject.Find("Canvas/Glasses3_Button").GetComponent<Button>();
        Scale_plus = GameObject.Find("Canvas/Scale +").GetComponent<Button>();
        Scale_minus = GameObject.Find("Canvas/Scale -").GetComponent<Button>();

        Glasses1Button.onClick.AddListener(Glasses1_Selected);
        Glasses2Button.onClick.AddListener(Glasses2_Selected);
        Glasses3Button.onClick.AddListener(Glasses3_Selected);
        Scale_plus.onClick.AddListener(Scaling_plus);
        Scale_minus.onClick.AddListener(Scaling_minus);

        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Glasses1_Selected()
    {
        Glasses1.SetActive(true);
        Glasses2.SetActive(false);
        Glasses3.SetActive(false);
    }
    public void Glasses2_Selected()
    {
        Glasses1.SetActive(false);
        Glasses2.SetActive(true);
        Glasses3.SetActive(false);
    }
    public void Glasses3_Selected()
    {
        Glasses1.SetActive(false);
        Glasses2.SetActive(false);
        Glasses3.SetActive(true);
    }

    public void Scaling_plus()
    {
        Glasses1.transform.localScale += scaleChange;
        Glasses2.transform.localScale += scaleChange;
        Glasses3.transform.localScale += scaleChange;
    }

    public void Scaling_minus()
    {
        Glasses1.transform.localScale -= scaleChange;
        Glasses2.transform.localScale -= scaleChange;
        Glasses3.transform.localScale -= scaleChange;

    }
}
