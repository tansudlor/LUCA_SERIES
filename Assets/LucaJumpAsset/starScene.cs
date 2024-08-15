using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class starScene : MonoBehaviour
{
    public GameObject sunnyJump;
    public static string level;
    public GameObject luca;



    float speed = 8f;
    float height = 30f;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NameDropDown());
        pos = luca.GetComponent<RectTransform>().anchoredPosition;
    }

    // Update is called once per frame

    private void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        luca.GetComponent<RectTransform>().anchoredPosition = new Vector3(luca.GetComponent<RectTransform>().anchoredPosition.x, newY, 0);


    }

    IEnumerator NameDropDown()
    {

        var t = 0f;
        while (t < 1f)
        {
            sunnyJump.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, Mathf.Lerp(666.46f, 126.96f, t), 0);
            t += 0.1f;
            yield return new WaitForSeconds(0.03f);
        }

        sunnyJump.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 126.96f, 0);
        luca.SetActive(true);
    }

    public void EasyGame()
    {
        level = "easy";
        SceneManager.LoadScene("Gameplay");
    }

    public void NormalGame()
    {
        level = "normal";
        SceneManager.LoadScene("Gameplay");
    }

    public void HardGame()
    {
        level = "hard";
        SceneManager.LoadScene("Gameplay");
    }
}
