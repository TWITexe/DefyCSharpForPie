using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskLayer : MonoBehaviour
{
    [SerializeField] private InputField inputTastText;   // �����-���� ������
    [SerializeField] private Text isTheAnswerTrue;       // ����� � �������� ������
    [SerializeField] private GameObject LayerTask;       // ���� � ��������
    [SerializeField] private GameObject DoorinStorange;  // ����� � ������
    public Sprite openDoor;                              // ������ �������� �����

    public static bool isAnswerTrue = false;             // ����� ��� ������



    private void Update()
    {
        if (Move.onTaskNow == true)
        {
            LayerTask.SetActive(true);
        }
        
    }

    public void GetAnswer()
    {
        if(inputTastText.text == "12")
        {
            isTheAnswerTrue.text = "������ �����, ��� �������! ";
            DoorinStorange.GetComponent<SpriteRenderer>().sprite = openDoor;
            StartCoroutine(EndTask());
        }
        else
        {
            isTheAnswerTrue.text = "����� �������� :(";
        }
    }
    IEnumerator EndTask()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Task close");
        LayerTask.SetActive(false);
        isAnswerTrue = true;
        Move.onTaskNow = false;
        DoorStorange.doorUnlocked = true;
    }
}
