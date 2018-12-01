﻿using UnityEngine;
using System.Collections;
using EasyWiFi.Core;
using System;
using UnityEngine.UI;

namespace EasyWiFi.ServerControls
{

    public class RightTouchpadServerController : MonoBehaviour, IServerController
    {

        public string control;
        public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;
        public EasyWiFiConstants.AXIS touchpadHorizontal = EasyWiFiConstants.AXIS.XAxis;
        public EasyWiFiConstants.AXIS touchpadVertical = EasyWiFiConstants.AXIS.YAxis;
        public EasyWiFiConstants.ACTION_TYPE action = EasyWiFiConstants.ACTION_TYPE.Position;
        public float sensitivity = .01f;

        //runtime variables
        TouchpadControllerType[] touchpad = new TouchpadControllerType[EasyWiFiConstants.MAX_CONTROLLERS];
        int currentNumberControllers = 1;
        Vector3 actionVector3;
        float horizontal;
        float vertical;
        bool isTouching = false;
        float lastFrameHorizontal;
        float lastFrameVertical;
        bool lastFrameIsTouching;

        private float firstTouchPosY;
        public float touchMoveYRight;
        public Text printText;

        void OnEnable()
        {
            EasyWiFiController.On_ConnectionsChanged += checkForNewConnections;

            //do one check at the beginning just in case we're being spawned after startup and after the callbacks
            //have already been called
            if (touchpad[0] == null && EasyWiFiController.lastConnectedPlayerNumber >= 0)
            {
                EasyWiFiUtilities.checkForClient(control, (int)player, ref touchpad, ref currentNumberControllers);
            }
        }

        void OnDestroy()
        {
            EasyWiFiController.On_ConnectionsChanged -= checkForNewConnections;
        }

        // Update is called once per frame
        void Update()
        {
            //iterate over the current number of connected controllers
            for (int i = 0; i < currentNumberControllers; i++)
            {
                if (touchpad[i] != null && touchpad[i].serverKey != null && touchpad[i].logicalPlayerNumber != EasyWiFiConstants.PLAYERNUMBER_DISCONNECTED)
                {
                    mapDataStructureToAction(i);
                }
            }
        }

        public void mapDataStructureToAction(int index)
        {
            lastFrameIsTouching = isTouching;
            if (!lastFrameIsTouching)
            {
                firstTouchPosY = touchpad[index].POSITION_VERTICAL; //记录第一次摸到的Yposition
            }

            isTouching = touchpad[index].IS_TOUCHING;
            vertical = touchpad[index].POSITION_VERTICAL;

            

            //only if we were touching both last frame and this
            if (isTouching && lastFrameIsTouching)
            {
                touchMoveYRight= vertical - firstTouchPosY; //如果持续触摸，就用这次的Y减去第一次摸到的Y
                printText.text = "touchMoveYRight" + touchMoveYRight;
            }
            if(!isTouching)
            {
                touchMoveYRight = 0; //手指离开就重置为0
            }
        }
        public void checkForNewConnections(bool isConnect, int playerNumber)
        {
            EasyWiFiUtilities.checkForClient(control, (int)player, ref touchpad, ref currentNumberControllers);
        }
    }

}
