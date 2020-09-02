using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypeController : MonoBehaviour
{
    private float delay = 0.1f;
    public string FullText, CurrentText = "";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i < FullText.Length; i++)
        {
            CurrentText = FullText.Substring(0, i);
            this.GetComponent<Text>().text = CurrentText;
            yield return new WaitForSeconds(delay);
        }
    }
    public void RestartText()
    {
        StartCoroutine(ShowText());
    }
}
