using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
  public Vector3 _ballDirection; //Vector3 türünde bir değişken oluşturduk.

  private void Start()
  {
    _ballDirection = Vector3.left; //_ballDirection'un başlangıç yönü Left olacak. 
  }
 
  private void Update()
  {
    HandleBallInputs();
  }

  private void HandleBallInputs()//Ball'ın Inputlarını buradan alacağız.
  {
    if (Input.GetMouseButton(0)) //Ekrana her dokunduğumuzda 
    {
      ChangeBallDirection();
    }
  }
 
  private void ChangeBallDirection()//Ball'ın yönünü burada değiştiriyoruz.
  {
    if (_ballDirection.x == -1) //Ball default olarak lefte gidiyor. Eğer lefte gidiyor ise;
    {
      _ballDirection = Vector3.forward; //GetMouseButton(0) çağırdığımızda yönünü forward olarak değiştir.
    }
    else
    {
      _ballDirection = Vector3.left;//Tekrar GetMouseButton(0) çağırdığımızda yönünü tekrar left'e çekmiş oluyoruz.
    }
  }
}
