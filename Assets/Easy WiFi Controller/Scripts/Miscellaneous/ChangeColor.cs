using UnityEngine;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerControls;

[AddComponentMenu("EasyWiFiController/Miscellaneous/ChangeColor")]
public class ChangeColor : MonoBehaviour {
    public MatchOrientationGyroServerController GyroServer;
    MeshRenderer myRenderer;
    Material myMaterial;
    Color originalColor;
    bool isPressed;

    void Start() 
    {
        myRenderer = this.GetComponent<MeshRenderer>();
        myMaterial = myRenderer.material;
        originalColor = myMaterial.color;
    }

    void changeColor(ButtonControllerType button)
    {
        isPressed = button.BUTTON_STATE_IS_PRESSED;

        if (isPressed)
        {
            if ((GyroServer.isStartAverage == false) && (GyroServer.isEndAverage == false))
            {
                GyroServer.GetComponent<MatchOrientationGyroServerController>().StartCalculatePosition();
                print("READY");
            }
        }
        else
            myMaterial.color = originalColor;

    }
}
