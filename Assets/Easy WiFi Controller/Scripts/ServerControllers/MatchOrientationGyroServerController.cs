using UnityEngine;
using EasyWiFi.Core;
using Rewired;
using Rewired.ControllerExtensions;

namespace EasyWiFi.ServerControls
{

    [AddComponentMenu("EasyWiFiController/Server/UserControls/Match Orientation Gyro")]
    public class MatchOrientationGyroServerController : MonoBehaviour
    {

        public string control = "Gyro";
        //public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player2;

        //runtime variables
        GyroControllerType[] gyro = new GyroControllerType[EasyWiFiConstants.MAX_CONTROLLERS];
        int currentNumberControllers = 0;
        Quaternion orientation;
        
        //按下按钮后需要计算玩家在三秒准备时间内的位置平均值
        public bool isStartAverage = false;      //是否开始计算平均值
        public bool isEndAverage = false;        //是否算完平均值
        private int AverageCount = 0;            //计算平均值的次数
        private float calculateTime = 0;         //计算平均值的总时长
        private Quaternion averageOrientation;   //计算得到的平均值
        
        //using controller as input
        private Player player { get { return ReInput.players.GetPlayer(playerId); } }
        public int playerId = 0;



//        void OnEnable()
//        {
//            EasyWiFiController.On_ConnectionsChanged += checkForNewConnections;
//
//            //do one check at the beginning just in case we're being spawned after startup and after the callbacks
//            //have already been called
//            if (gyro[0] == null && EasyWiFiController.lastConnectedPlayerNumber >= 0)
//            {
//                EasyWiFiUtilities.checkForClient(control, (int)player, ref gyro, ref currentNumberControllers);
//            }
//        }

//        void OnDestroy()
//        {
//            EasyWiFiController.On_ConnectionsChanged -= checkForNewConnections;
//        }

        // Update is called once per frame
        void Update()
        {
            
            var ds4 = GetFirstDS4(player);
            
            if (ds4 != null)
            {
                // Set the model's rotation to match the controller's
                transform.rotation = ds4.GetOrientation();
            }


            //iterate over the current number of connected controllers
//            for (int i = 0; i < currentNumberControllers; i++)
//            {
////                if (gyro[i] != null && gyro[i].serverKey != null && gyro[i].logicalPlayerNumber != EasyWiFiConstants.PLAYERNUMBER_DISCONNECTED)
////                {
//                    if (isStartAverage)
//                    {
//                        CalculateAverage(i);            //如果还在计算平均值（玩家准备的三秒时间内），就继续计算平均值
//                    }
//                    if (isEndAverage)
//                    {
//                        mapDataStructureToAction(i);    //如果算完了（游戏正式开始），就把陀螺仪的数据传给盘子
//                    }
////                }
//            }
        }

        private IDualShock4Extension GetFirstDS4(Player player) {
            foreach(Joystick j in player.controllers.Joysticks) {
                // Use the interface because it works for both PS4 and desktop platforms
                IDualShock4Extension ds4 = j.GetExtension<IDualShock4Extension>();
                if(ds4 == null) continue;
                return ds4;
            }
            return null;
        }

        public void mapDataStructureToAction(int index)
        {
            //由于世界坐标系和unity坐标系不同，对轴进行更改
            orientation.w = gyro[index].GYRO_W;
            orientation.x = -gyro[index].GYRO_X;
            orientation.y = -gyro[index].GYRO_Z;
            orientation.z = -gyro[index].GYRO_Y;
            
            //游戏过程中陀螺仪的数据传入后再和玩家初始方向比较，得到的结果是盘子的旋转值
            transform.localRotation = Quaternion.Inverse(averageOrientation) * orientation;
        }
        
        
        public void StartCalculatePosition() //按下按钮之后调用的函数
        {
            averageOrientation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);  
            isStartAverage = true;
            AverageCount = 0;
            calculateTime = 0;
        }

        private void CalculateAverage(int index) //计算玩家初始角度
        {
            orientation.w = gyro[index].GYRO_W;
            orientation.x = -gyro[index].GYRO_X;
            orientation.y = -gyro[index].GYRO_Z;
            orientation.z = -gyro[index].GYRO_Y;
            
            //对每次获取的陀螺仪角度求平均值
            averageOrientation.w = (averageOrientation.w * AverageCount + orientation.w) / (AverageCount + 1);
            averageOrientation.x = (averageOrientation.x * AverageCount + orientation.x) / (AverageCount + 1);
            averageOrientation.y = (averageOrientation.y * AverageCount + orientation.y) / (AverageCount + 1);
            averageOrientation.z = (averageOrientation.z * AverageCount + orientation.z) / (AverageCount + 1);
            AverageCount++;
            
            calculateTime += Time.deltaTime;
            
            if (calculateTime > 4) //时间>4秒后，把计算好的四元数normalize，游戏正式开始
            {
                float w = averageOrientation.w;
                float x = averageOrientation.x;
                float y = averageOrientation.y;
                float z = averageOrientation.z;
                float lengthD = 1.0f / (w*w + x*x + y*y + z*z);
                averageOrientation.w *= lengthD;
                averageOrientation.x *= lengthD;
                averageOrientation.y *= lengthD;
                averageOrientation.z *= lengthD;
                
                isStartAverage = false;
                isEndAverage = true;
            }
            
            //倒计时显示
            else if (calculateTime > 3) 
            {
                GameObject.Find("Countdown").gameObject.GetComponent<TextMesh>().text ="Start";
            }
            else if (calculateTime > 2)
            {
                GameObject.Find("Countdown").gameObject.GetComponent<TextMesh>().text ="1";
            }
            else if (calculateTime > 1)
            {
                GameObject.Find("Countdown").gameObject.GetComponent<TextMesh>().text = "2";
            }
        }
        

//        public void checkForNewConnections(bool isConnect, int playerNumber)
//        {
//            EasyWiFiUtilities.checkForClient(control, (int)player, ref gyro, ref currentNumberControllers);
//        }
    }

}
