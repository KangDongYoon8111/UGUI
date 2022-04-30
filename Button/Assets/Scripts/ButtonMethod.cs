using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonMethod : MonoBehaviour
{
    public TextMeshProUGUI text;

    public Button button;

    public void SetText(string num)
    {
        text.text = "Button " + num + " : Click";
    }

    public void Enter(Button button)
    {
        button.Select();
    }

    private void Start()
    {
        //button.onClick.Invoke();
        button.Select();
    }
}
