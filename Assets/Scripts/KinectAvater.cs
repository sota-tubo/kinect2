using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Windows.Kinect;

public class KinectAvater : MonoBehaviour {
    [SerializeField]
    BodySourceManager bodySourceManager;

    //自分の関節とUnityちゃんのボーンを入れるよう
    [SerializeField] GameObject Ref;
    [SerializeField] GameObject Hips;
    [SerializeField] GameObject LeftUpLeg;
    [SerializeField] GameObject LeftLeg;
    [SerializeField] GameObject RightUpLeg;
    [SerializeField] GameObject RightLeg;
    [SerializeField] GameObject Spine1;
    [SerializeField] GameObject Spine2;
    [SerializeField] GameObject LeftShoulder;
    [SerializeField] GameObject LeftArm;
    [SerializeField] GameObject LeftForeArm;
    [SerializeField] GameObject LeftHand;
    [SerializeField] GameObject RightShoulder;
    [SerializeField] GameObject RightArm;
    [SerializeField] GameObject RightForeArm;
    [SerializeField] GameObject RightHand;
    [SerializeField] GameObject Neck;
    [SerializeField] GameObject Head;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //最初に追尾している人のBodyデータを取得する
        Body body = bodySourceManager.GetData().FirstOrDefault(b => b.IsTracked);

        // Kinectを斜めに置いてもまっすぐにするようにする
        var floorPlane = bodySourceManager.FloorClipPlane;
        Quaternion comp = Quaternion.FromToRotation(
            new Vector3(-floorPlane.X, floorPlane.Y, floorPlane.Z), Vector3.up);


        Quaternion SpineBase;
        Quaternion SpineMid;
        Quaternion SpineShoulder;
        Quaternion ShoulderLeft;
        Quaternion ShoulderRight;
        Quaternion ElbowLeft;
        Quaternion WristLeft;
        Quaternion HandLeft;
        Quaternion ElbowRight;
        Quaternion WristRight;
        Quaternion HandRight;
        Quaternion KneeLeft;
        Quaternion AnkleLeft;
        Quaternion KneeRight;
        Quaternion AnkleRight;

        Quaternion q;
        Quaternion comp2;
        CameraSpacePoint pos;

        // 関節の回転を取得する
        if (body != null)
        {
            var joints = body.JointOrientations;

            //Kinectの関節回転情報をUnityのクォータニオンに変換
            SpineBase = joints[JointType.SpineBase].Orientation.ToMirror().ToQuaternion(comp);
            SpineMid = joints[JointType.SpineMid].Orientation.ToMirror().ToQuaternion(comp);
            SpineShoulder = joints[JointType.SpineShoulder].Orientation.ToMirror().ToQuaternion(comp);
            ShoulderLeft = joints[JointType.ShoulderRight].Orientation.ToMirror().ToQuaternion(comp);
            ShoulderRight = joints[JointType.ShoulderLeft].Orientation.ToMirror().ToQuaternion(comp);
            ElbowLeft = joints[JointType.ElbowRight].Orientation.ToMirror().ToQuaternion(comp);
            WristLeft = joints[JointType.WristRight].Orientation.ToMirror().ToQuaternion(comp);
            HandLeft = joints[JointType.HandRight].Orientation.ToMirror().ToQuaternion(comp);
            ElbowRight = joints[JointType.ElbowLeft].Orientation.ToMirror().ToQuaternion(comp);
            WristRight = joints[JointType.WristLeft].Orientation.ToMirror().ToQuaternion(comp);
            HandRight = joints[JointType.HandLeft].Orientation.ToMirror().ToQuaternion(comp);
            KneeLeft = joints[JointType.KneeRight].Orientation.ToMirror().ToQuaternion(comp);
            AnkleLeft = joints[JointType.AnkleRight].Orientation.ToMirror().ToQuaternion(comp);
            KneeRight = joints[JointType.KneeLeft].Orientation.ToMirror().ToQuaternion(comp);
            AnkleRight = joints[JointType.AnkleLeft].Orientation.ToMirror().ToQuaternion(comp);

            // 関節の回転を計算する 
            q = transform.rotation;
            transform.rotation = Quaternion.identity;

            comp2 = Quaternion.AngleAxis(90, new Vector3(0, 1, 0)) *
                             Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));

            Spine1.transform.rotation = SpineMid * comp2;

            RightArm.transform.rotation = ElbowRight * comp2;
            RightForeArm.transform.rotation = WristRight * comp2;
            RightHand.transform.rotation = HandRight * comp2;

            LeftArm.transform.rotation = ElbowLeft * comp2;
            LeftForeArm.transform.rotation = WristLeft * comp2;
            LeftHand.transform.rotation = HandLeft * comp2;

            RightUpLeg.transform.rotation = KneeRight * comp2 * Quaternion.AngleAxis(-90, new Vector3(1, 0, 0));
            RightLeg.transform.rotation = AnkleRight * comp2 * Quaternion.AngleAxis(-90, new Vector3(1, 0, 0));

            
           /* RightUpLeg.transform.rotation = KneeRight *
                        Quaternion.AngleAxis(0, new Vector3(0, 0, 1)) *
                        Quaternion.AngleAxis(-90, new Vector3(0, 1, 0));

            RightLeg.transform.rotation = AnkleRight *
                        Quaternion.AngleAxis(0, new Vector3(0, 0, 1)) *
                        Quaternion.AngleAxis(-90, new Vector3(0, 1, 0));*/
            

            LeftUpLeg.transform.rotation = KneeLeft *
                        Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));

            LeftLeg.transform.rotation = AnkleLeft *
                        Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));


            // モデルの回転を設定する
            transform.rotation = q;

            // モデルの位置を移動する
            pos = body.Joints[JointType.SpineMid].Position;
            Ref.transform.position = new Vector3(-pos.X, pos.Y, -pos.Z);
        }
    }
}
