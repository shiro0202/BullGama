using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager instance;

    [SerializeField] int SceneNumber = 1;
    Uresa urusa;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))    
        {
            LoadnextScene();
        }*/
    }



    public void LoadnextScene()
    {
        if (SceneNumber == 1)
        {
            Debug.Log("Boss_Lung");
            SceneManager.LoadScene("Boss_Lung");
            //������ �ε�
            SceneNumber++;

        }

        else if (SceneNumber == 2)
        {
            Debug.Log("Game1");
            SceneManager.LoadScene("Game1");
            //������2 �ε�
            SceneNumber++;
        }

        else if (SceneNumber == 3)
        {
            //���� 2 �ε�
            SceneManager.LoadScene("Boss_Heart");
            SceneNumber++;
        }

        else if (SceneNumber == 4)
        {
            //���� ��Ʈ
            SceneManager.LoadScene("Game2");
            SceneNumber++;
        }
        else if (SceneNumber == 5)
        {
            urusa = FindAnyObjectByType<Uresa>();
            urusa.GanTrue();
        }


    }

    public void end()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}