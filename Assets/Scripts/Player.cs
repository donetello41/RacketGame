using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class Player:Raket
    {
        public string axisName;
        float moveAxis;
        // Update is called once per frame
        void Update()
        {
            //moveAxis = Input.GetAxis(axisName);//-1 ile 1 Arasında değerler verir
            moveAxis = Input.GetAxisRaw(axisName);// -1 ile 1 değerlerini verir
            rb.velocity = new Vector2(0, moveAxis * moveSpeed);
        }
 
    }
}
