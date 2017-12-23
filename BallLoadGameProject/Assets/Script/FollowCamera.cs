using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public float disrance = 5.0f;
    public float horizontalAngle = 0.0f;

    public float verticalAngle = 13.0f;
    public Transform lookTarget;
    public Vector3 offset = Vector3.zero;
	
	// Update is called once per frame
	void Update () {

        //カメラの移動
        if (lookTarget != null)
        {
             Vector3 lookPosition = lookTarget.position + offset;
             Vector3 relativePos = Quaternion.Euler(verticalAngle, horizontalAngle, 0) * new Vector3(0, 0, -disrance);
            //ポジション移動
             transform.position = lookPosition + relativePos;

            //ターゲットに向かせる
            transform.LookAt(lookTarget);

            //壁や地面にめり込み防止
            RaycastHit hitInfo;
           if (Physics.Linecast(lookPosition, transform.position, out hitInfo, 1 << LayerMask.NameToLayer("Load")))
            {
                transform.position = hitInfo.point;
            }
        }
    }
}
