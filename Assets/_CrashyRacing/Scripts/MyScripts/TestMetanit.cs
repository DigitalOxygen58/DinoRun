//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;



//public class TestMetanit : MonoBehaviour
//{
//    (int,int) a = (1, 2);
//}
//// ������� ��������� ������ ��� ������ ��������
//delegate void CallMethod(string s);

//class Core
//{
//    public static void CoreMethod(CallMethod callBackFunction)
//    {
//        Console.WriteLine("����������� ����� ����");
//        callBackFunction("������ �� CallMethod");
//    }
//}

//class Level1
//{
//    public static void MethodForDelegate(string s)
//    {
//        Console.WriteLine("����������� ����� Level1 {0}", s);
//    }


//    static void Main(string[] args)
//    {
//        CallMethod Method1 = Level1.MethodForDelegate;
//        Core.CoreMethod(Method1);
//        Console.ReadKey();
//    }
//}