using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMPTest : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public TextMeshProUGUI textVariable;

    void Start()
    {
        textVariable = GetComponent<TextMeshProUGUI>();

        // Text Input Box�� �ִ� �ؽ�Ʈ ���� ����
        textVariable.text = "This font can't support korean.";
        // Vertex Color
        textVariable.color = Color.red;
        // Font Size
        textVariable.fontSize = 40;
        // Font Style
        textVariable.fontStyle = FontStyles.Bold | FontStyles.Italic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
