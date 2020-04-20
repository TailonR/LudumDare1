using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textBoxManager : MonoBehaviour
{
    public TextAsset textFile;
    public string[] textLines;
    public GameObject textBox;
    public Text theText;

    public int currentLine;
    public int endAtLine;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<playerMvmnt>().enabled = false;

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if(endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
    }

    void Update()
    {
        if (currentLine <= textLines.Length-1)
        {
            theText.text = textLines[currentLine];
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            currentLine++;
        }
        if (currentLine > endAtLine)
        {
            textBox.SetActive(false);
            FindObjectOfType<playerMvmnt>().enabled = true;

        }
    }

}
