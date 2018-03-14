using UnityEngine;

namespace VOLib.Unity.Manager.Universe
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UniverseManager<T> : MonoBehaviour where T : UniverseManager<T>
    {
        private static T instance;

        /// <summary>
        /// 
        /// </summary>
        public static T Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }

                instance = FindObjectOfType<T>();
                DontDestroyOnLoad(instance.gameObject);

                return instance;
            }
        }
    }
}