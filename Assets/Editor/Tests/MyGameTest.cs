using NUnit.Framework;
using UnityEngine;

// 클래스 이름이 파일명(MyGameTests.cs)과 일치해야 합니다.
public class MyGameTest
{
    [Test] // [UnityTest]가 아닙니다!
    public void MySimpleTest()
    {
        Assert.AreEqual(30, 10 + 20);
    }
}