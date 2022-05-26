using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] GameObject storyLayer;    // ���� ��� �����

    [SerializeField] GameObject introText;     // ��������
    [SerializeField] GameObject pressE;        // ������� �� E
    [SerializeField] GameObject introStory1;   // ����������� ���� 1
    [SerializeField] GameObject introStory2;   // ����������� ���� 2
    [SerializeField] GameObject introStory3;   // ����������� ���� 3 
    [SerializeField] GameObject introStory4;   // ����������� ���� 4
    [SerializeField] GameObject introStory5;   // ����������� ���� 5

    public static bool introStoryEnd = false;  // ����������� �� �����������
    int numberOfClicks = 0;                    // ���-�� ������� "E" 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0) && introStoryEnd == false)
        {
                numberOfClicks++;
                switch(numberOfClicks)
                {
                    case 1:
                        introText.SetActive(false);
                        break;
                    case 2:
                        pressE.SetActive(false);
                        introStory1.SetActive(true);
                    break;
                    case 3:
                        introStory2.SetActive(true);
                    break;
                    case 4:
                        introStory3.SetActive(true);
                    break;
                    case 5:
                        introStory4.SetActive(true);
                    break;
                    case 6:
                        introStory5.SetActive(true);
                    break;
                    case 7:
                        storyLayer.SetActive(false);
                        introStoryEnd = true;
                    break;
                }

        }
    }
}
