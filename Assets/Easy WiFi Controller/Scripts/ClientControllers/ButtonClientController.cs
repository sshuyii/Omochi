using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using EasyWiFi.Core;

namespace EasyWiFi.ClientControls
{
    [AddComponentMenu("EasyWiFiController/Client/UserControls/Button")]
    public class ButtonClientController : MonoBehaviour, IClientController
    {

        public string controlName = "Button1";
        public Sprite buttonPressedSprite;

        ButtonControllerType button;
        //Image currentImage;
        //Sprite buttonRegularSprite;
        string buttonKey;
        //Rect screenPixelsRect;
        int touchCount = 0;
        public bool pressed;
        public Text pressedText;
        
        // Use this for initialization
        void Awake()
        {
            buttonKey = EasyWiFiController.registerControl(EasyWiFiConstants.CONTROLLERTYPE_BUTTON, controlName);
            button = (ButtonControllerType)EasyWiFiController.controllerDataDictionary[buttonKey];
            //currentImage = gameObject.GetComponent<Image>();
            //buttonRegularSprite = currentImage.sprite;
            
        }
        

        void Start()
        {
            //screenPixelsRect = EasyWiFiUtilities.GetScreenRect(currentImage.rectTransform);
        }
        public void mapInputToDataStream()
        {
            pressedText.text = touchCount.ToString();
            if (!pressed)
            {
                pressed = true;
            }
            else
            {
                pressed = false;
            }

        }
        //here we grab the input and map it to the data list
        void Update()
        {
            if (pressed)
            {
                button.BUTTON_STATE_IS_PRESSED = true;            
            }
            else
            {
                button.BUTTON_STATE_IS_PRESSED = false;
            }
        }

        /*IEnumerator WaitForSeconds()
        {
            yield return new WaitForSeconds(0.2f);
            pressed = false;
            button.BUTTON_STATE_IS_PRESSED = false;
        }

        public void mapInputToDataStream()
        {
            if (!pressed)
            {
                pressed = true;
                button.BUTTON_STATE_IS_PRESSED = true;
                StartCoroutine(WaitForSeconds());
            }

        }*/
        /*public void mapInputToDataStream()
        {

            //reset to default values;
            //touch count is 0
            button.BUTTON_STATE_IS_PRESSED = false;
            pressed = false;

            //mouse
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (Input.mousePosition.x >= screenPixelsRect.x &&
                        Input.mousePosition.x <= (screenPixelsRect.x + screenPixelsRect.width) &&
                        Input.mousePosition.y >= screenPixelsRect.y &&
                        Input.mousePosition.y <= (screenPixelsRect.y + screenPixelsRect.height))
                {
                    pressed = true;
                   
                }

            }

            //touch
            touchCount = Input.touchCount;

            if (touchCount > 0)
            {
                for (int i = 0; i < touchCount; i++)
                {
                    Touch touch = Input.GetTouch(i);

                    //touch somewhere on control
                    if (touch.position.x >= screenPixelsRect.x &&
                            touch.position.x <= (screenPixelsRect.x + screenPixelsRect.width) &&
                            touch.position.y >= screenPixelsRect.y &&
                            touch.position.y <= (screenPixelsRect.y + screenPixelsRect.height))
                    {

                        pressed = true;
                        break;
                    }
                }
            }

            //show the correct image
            if (pressed)
            {
                button.BUTTON_STATE_IS_PRESSED = true;
                currentImage.sprite = buttonPressedSprite;
               
            }
            else
            {
                button.BUTTON_STATE_IS_PRESSED = false;
                currentImage.sprite = buttonRegularSprite;

            }

        }*/

    }

}