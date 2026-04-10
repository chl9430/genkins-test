using NUnit.Framework;
using UnityEngine;
using UnityEditor;

// [TestFixture]는 이 클래스가 테스트를 포함하고 있음을 유니티에 알립니다.
[TestFixture]
public class MyGameTests
{
    [Test]
    public void SimpleArithmeticTest()
    {
        // 결과 확인을 위해 일부러 틀린 값(0)을 넣었습니다.
        // 나중에 성공을 확인하려면 0을 30으로 수정하세요.
        int expected = 0;
        int actual = 10 + 20;

        Debug.Log($"[TestLog] Expected: {expected}, Actual: {actual}");

        Assert.AreEqual(expected, actual, "10 + 20은 30이어야 합니다.");
    }
}