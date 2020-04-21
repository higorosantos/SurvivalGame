using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class InputManager : MonoBehaviour
    {
        // Start is called before the first frame update


        [SerializeField] protected float vertical;
        [SerializeField] protected float horizontal;
        [SerializeField] protected float mouseX;
        [SerializeField] protected float mouseY;

        #region Get's
        public float getVertical()
        {
            return this.vertical;
        }
        public float getHorizontal()
        {
            return this.horizontal;
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
            this.vertical = Input.GetAxis("Vertical");
            this.horizontal = Input.GetAxis("Horizontal");
            this.mouseX = Input.GetAxis("Mouse X");
            this.mouseY = Input.GetAxis("Mouse Y");
        }
    }
