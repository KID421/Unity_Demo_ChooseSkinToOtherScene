using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorSystem : MonoBehaviour
{
    #region 要帶到下個場景的資料
    public static Color playerColor;

    public static RuntimeAnimatorController controller;
    #endregion

    #region 資料有幾種
    public RuntimeAnimatorController red, green, blue;
    #endregion

    public void ChooseColor(int chooseColor)
    {
        switch (chooseColor)
        {
            case 1:
                playerColor = Color.red;
                controller = red;
                break;

            case 2:
                playerColor = Color.green;
                controller = green;
                break;

            case 3:
                playerColor = Color.blue;
                controller = blue;
                break;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}
