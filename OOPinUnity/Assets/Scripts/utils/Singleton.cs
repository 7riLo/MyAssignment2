/*
 * Levi Wyant
 * Assignment 6
 */

using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        public static T instance;

        public static T Instance
        {
            get { return instance;}
        }

        public static bool IsIntialized
        {
            get { return instance != null; }
        }

        private void Awake()
        {
            if(instance != null)
            {
                Debug.LogError("[Singleton] trying to instantiate a second instance of a singleton class");
            }
            else
            {
                instance = (T)this;
            }
        
        }

        protected virtual void OnDestroy()
        {
            //if this object is destroyed, make instance null so another can be destroyed
            if (instance == this)
            {
                instance = null;
            }
        }    

    }
}