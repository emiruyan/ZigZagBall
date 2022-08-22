using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ZigZagBall.Ground
{
    public class GroundColorController : MonoBehaviour
    {
        [SerializeField] private Material groundMaterial;

        [SerializeField] private Color[] colors;

        private int colorIndex = 0;

        [SerializeField] private float lerpValue;

        [SerializeField] private float time;

        private float currentTime;

        private void Update()
        {
            SetColorChangeTime();
            SetGroundMaterialSmootColorChange();
        }

        private void SetColorChangeTime() //Burada bir Timer oluşturduk.
        {
            if (currentTime <= 0) 
            {
                CheckColorIndexValue();
                currentTime = time;
            }
            else
            {
                currentTime -= Time.deltaTime; //Eğer yukarıdaki koşul sağlanmaz ise burada kendini eksiltip tekrar yukarıdaki koşula dönecek
            }
        }

        private void CheckColorIndexValue() 
        {
            colorIndex++; //Buradaki colorIndex bir bir artarak dizimizin içerisinde dolaşacak.

            if (colorIndex >= colors.Length) //colorIndex dizi içerisinde ki colorsın Lengthine büyük veya eşitse
            {
                colorIndex = 0; //colorIndex'i 0'a atıyoruz
            }
        }

        private void SetGroundMaterialSmootColorChange()//Color'ı Lerp ile burada değiştiriyoruz.
        {
            groundMaterial.color = Color.Lerp(groundMaterial.color, colors[colorIndex], lerpValue * Time.deltaTime);
            //Başlangıç = groundMaterial.color Hedef = colors[colorIndex]
;       }

        private void OnDestroy() //Son kaydedilen color default olarak kalmasın diye böyle bir method yazdık.
        {
            groundMaterial.color = colors[1]; //OnDestroy olduğunda colors'ın 1.indexini al
        }
    }

}

