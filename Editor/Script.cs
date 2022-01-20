using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WORK
{
    public static class Script
    {
        // Update is called once per frame
        public static void ChangeSomething(this GameObject obj)
        {
            var button = Input.GetAxis("Horizontal");
            obj.transform.position += new Vector3(button * 5 * Time.deltaTime, 0, 0);
        }
    }
}
