using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class InputManager : MonoBehaviour
    {
        // Start is called before the first frame update


        [SerializeField] protected float forward;
        [SerializeField] protected float sideway;
        [SerializeField] protected float mouseX;
        [SerializeField] protected float mouseY;

        #region Get's
        public float getForward()
        {
            return this.forward;
        }
        public float getSideway()
        {
            return this.sideway;
        }

        public float getMouseX()
        {
            return this.mouseX;
        }
        public float getMouseY()
        {
            return this.mouseY;
        }
    #endregion


    // Update is called once per frame
    void Update()
        {
            this.handleInput();
        }
        protected void handleInput()
        {
            this.forward = Input.GetAxis("Vertical");
            this.sideway = Input.GetAxis("Horizontal");
            this.mouseX = Input.GetAxis("Mouse X");
            this.mouseY = Input.GetAxis("Mouse Y");
        }
    }
