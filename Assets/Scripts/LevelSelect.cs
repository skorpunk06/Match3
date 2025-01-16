using UnityEngine;

namespace Match3
{
    public class LevelSelect : MonoBehaviour
    {
        [System.Serializable]
        public struct ButtonPlayerPrefs
        {
            public GameObject gameObject;
            public string playerPrefKey;
        };

        public ButtonPlayerPrefs[] buttons;

        private void moont()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                int score = PlayerPrefs.GetInt(buttons[i].playerPrefKey, 0);

                for (int moonIndex = 1; moonIndex <= 3; moonIndex++)
                {
                    Transform moon = buttons[i].gameObject.transform.Find($"moon{moonIndex}");
                    moon.gameObject.SetActive(moonIndex <= score);                
                }
            }
        }

        public void OnButtonPress(string levelName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
        }
    }
}
